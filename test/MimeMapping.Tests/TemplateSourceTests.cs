using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TemplateSourceTests
    {
        private const string MIMEDB_URL = "https://raw.githubusercontent.com/jshttp/mime-db/v1.54.0/db.json";

        [TestMethod]
        public async Task TestMimeDbMimeTypesAsync()
        {
            var keyPairs = await GetMimeTypesFromJsonAsync(MIMEDB_URL);
            Assert.IsTrue(keyPairs.Any());
        }

        private static async Task<string> GetPageContentAsync(string url)
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(url);
        }

        private static async Task<IEnumerable<string[]>> GetMimeTypesFromJsonAsync(string url)
        {
            var content = await GetPageContentAsync(url);
            if (string.IsNullOrEmpty(content)) return Enumerable.Empty<string[]>();

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
