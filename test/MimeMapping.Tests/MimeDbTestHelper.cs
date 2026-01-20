using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Test
{
    internal static class MimeDbTestHelper
    {
        public const string MIMEDB_URL = "https://raw.githubusercontent.com/jshttp/mime-db/v1.54.0/db.json";

        // Get priority for source (higher is better)
        // iana=3, apache=2, nginx=1, other=0
        private static int GetSourcePriority(string source) => source switch
        {
            "iana" => 3,
            "apache" => 2,
            "nginx" => 1,
            _ => 0
        };

        // Get priority for mime type category (higher is better)
        // Prefer specific types (video/*, audio/*, image/*, text/*) over application/*
        private static int GetTypePriority(string mimeType)
        {
            if (mimeType.StartsWith("video/")) return 4;
            if (mimeType.StartsWith("audio/")) return 4;
            if (mimeType.StartsWith("image/")) return 4;
            if (mimeType.StartsWith("text/")) return 3;
            if (mimeType.StartsWith("font/")) return 3;
            if (mimeType.StartsWith("model/")) return 2;
            if (mimeType.StartsWith("application/")) return 1;
            return 0;
        }

        /// <summary>
        /// Fetches mime types with conflict resolution matching the generator logic.
        /// Returns a dictionary of extension -> mime type.
        /// </summary>
        public static async Task<Dictionary<string, string>> FetchMimeTypesWithResolutionAsync()
        {
            using var client = new HttpClient();
            var content = await client.GetStringAsync(MIMEDB_URL);
            using var doc = JsonDocument.Parse(content);

            var result = new Dictionary<string, string>();
            var entryDict = new Dictionary<string, (string mimeType, string source)>();

            foreach (var mimeTypeEntry in doc.RootElement.EnumerateObject())
            {
                var mimeType = mimeTypeEntry.Name;
                var source = mimeTypeEntry.Value.TryGetProperty("source", out var sourceEl)
                    ? sourceEl.GetString()
                    : null;

                if (mimeTypeEntry.Value.TryGetProperty("extensions", out var extensions))
                {
                    foreach (var ext in extensions.EnumerateArray())
                    {
                        var extStr = ext.GetString()!;

                        if (entryDict.TryGetValue(extStr, out var existing))
                        {
                            if (existing.mimeType != mimeType)
                            {
                                var existingSourcePri = GetSourcePriority(existing.source);
                                var newSourcePri = GetSourcePriority(source);
                                var existingTypePri = GetTypePriority(existing.mimeType);
                                var newTypePri = GetTypePriority(mimeType);

                                var shouldReplace = newSourcePri > existingSourcePri ||
                                    (newSourcePri == existingSourcePri && newTypePri > existingTypePri);

                                if (shouldReplace)
                                {
                                    result[extStr] = mimeType;
                                    entryDict[extStr] = (mimeType, source);
                                }
                            }
                        }
                        else
                        {
                            result[extStr] = mimeType;
                            entryDict[extStr] = (mimeType, source);
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Legacy method that returns raw entries without conflict resolution.
        /// </summary>
        public static async Task<List<string[]>> FetchMimeTypesAsync()
        {
            using var client = new HttpClient();
            var content = await client.GetStringAsync(MIMEDB_URL);
            using var doc = JsonDocument.Parse(content);
            var results = new List<string[]>();

            foreach (var mimeTypeEntry in doc.RootElement.EnumerateObject())
            {
                var mimeType = mimeTypeEntry.Name;
                if (mimeTypeEntry.Value.TryGetProperty("extensions", out var extensions))
                {
                    foreach (var ext in extensions.EnumerateArray())
                    {
                        results.Add(new[] { mimeType, ext.GetString()! });
                    }
                }
            }

            return results;
        }
    }
}
