using System;
using System.Collections.Generic;
using System.Text.Json;

namespace MimeMapping.SourceGenerator
{
    /// <summary>
    /// Parses mime-db JSON and applies conflict resolution logic
    /// </summary>
    internal static class MimeDbParser
    {
        /// <summary>
        /// Get priority for source (higher is better)
        /// iana=3, apache=2, nginx=1, other=0
        /// </summary>
        public static int GetSourcePriority(string? source) => source switch
        {
            "iana" => 3,
            "apache" => 2,
            "nginx" => 1,
            _ => 0
        };

        /// <summary>
        /// Get priority for mime type category (higher is better)
        /// Prefer specific types (video/*, audio/*, image/*, text/*) over application/*
        /// </summary>
        public static int GetTypePriority(string mimeType)
        {
            if (mimeType.StartsWith("video/", StringComparison.Ordinal)) return 4;
            if (mimeType.StartsWith("audio/", StringComparison.Ordinal)) return 4;
            if (mimeType.StartsWith("image/", StringComparison.Ordinal)) return 4;
            if (mimeType.StartsWith("text/", StringComparison.Ordinal)) return 3;
            if (mimeType.StartsWith("font/", StringComparison.Ordinal)) return 3;
            if (mimeType.StartsWith("model/", StringComparison.Ordinal)) return 2;
            if (mimeType.StartsWith("application/", StringComparison.Ordinal)) return 1;
            return 0;
        }

        /// <summary>
        /// Parse mime-db JSON and return structured data with conflict resolution applied
        /// </summary>
        public static MimeDbData Parse(string json, string sourceUrl)
        {
            var extensionToMimeType = new Dictionary<string, string>();
            var mimeTypeToExtensions = new Dictionary<string, List<string>>();
            var conflictComments = new List<string>();

            // Track source info for conflict resolution
            var entryDict = new Dictionary<string, (string mimeType, string? source)>();

            using var doc = JsonDocument.Parse(json);

            foreach (var mimeTypeEntry in doc.RootElement.EnumerateObject())
            {
                var mimeType = mimeTypeEntry.Name;
                string? source = null;

                if (mimeTypeEntry.Value.TryGetProperty("source", out var sourceEl))
                {
                    source = sourceEl.GetString();
                }

                if (!mimeTypeEntry.Value.TryGetProperty("extensions", out var extensions))
                {
                    continue;
                }

                foreach (var ext in extensions.EnumerateArray())
                {
                    var extStr = ext.GetString();
                    if (string.IsNullOrEmpty(extStr))
                    {
                        continue;
                    }

                    // After the null check above, extStr is guaranteed non-null
                    var extension = extStr!;

                    if (entryDict.TryGetValue(extension, out var existing))
                    {
                        if (existing.mimeType != mimeType)
                        {
                            // Compare priorities to decide which one wins
                            var existingSourcePri = GetSourcePriority(existing.source);
                            var newSourcePri = GetSourcePriority(source);
                            var existingTypePri = GetTypePriority(existing.mimeType);
                            var newTypePri = GetTypePriority(mimeType);

                            var shouldReplace = newSourcePri > existingSourcePri ||
                                (newSourcePri == existingSourcePri && newTypePri > existingTypePri);

                            if (shouldReplace)
                            {
                                // Remove from old reverse dict entry
                                if (mimeTypeToExtensions.TryGetValue(existing.mimeType, out var oldList))
                                {
                                    oldList.Remove(extension);
                                    if (oldList.Count == 0)
                                    {
                                        mimeTypeToExtensions.Remove(existing.mimeType);
                                    }
                                }

                                // Update to new value
                                extensionToMimeType[extension] = mimeType;
                                entryDict[extension] = (mimeType, source);

                                if (!mimeTypeToExtensions.TryGetValue(mimeType, out var keyList))
                                {
                                    keyList = new List<string>();
                                    mimeTypeToExtensions.Add(mimeType, keyList);
                                }
                                keyList.Add(extension);

                                // Add conflict comment
                                conflictComments.Add(
                                    $"// Dupe for {extension}: using {mimeType} ({source ?? "unknown"}/type:{newTypePri}) over {existing.mimeType} ({existing.source ?? "unknown"}/type:{existingTypePri})");
                            }
                            else
                            {
                                // Keep existing, add conflict comment
                                conflictComments.Add(
                                    $"// Dupe for {extension}: keeping {existing.mimeType} ({existing.source ?? "unknown"}/type:{existingTypePri}) over {mimeType} ({source ?? "unknown"}/type:{newTypePri})");
                            }
                        }
                    }
                    else
                    {
                        // First occurrence
                        extensionToMimeType[extension] = mimeType;
                        entryDict[extension] = (mimeType, source);

                        if (!mimeTypeToExtensions.TryGetValue(mimeType, out var keyList))
                        {
                            keyList = new List<string>();
                            mimeTypeToExtensions.Add(mimeType, keyList);
                        }
                        keyList.Add(extension);
                    }
                }
            }

            return new MimeDbData(
                extensionToMimeType,
                mimeTypeToExtensions,
                conflictComments,
                DateTime.UtcNow,
                sourceUrl);
        }
    }
}
