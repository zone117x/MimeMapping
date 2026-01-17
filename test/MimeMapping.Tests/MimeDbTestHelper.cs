using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Test
{
    internal static class MimeDbTestHelper
    {
        public const string MIMEDB_URL = "https://raw.githubusercontent.com/jshttp/mime-db/v1.54.0/db.json";

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
