using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace Test
{
    [TestClass]
    public class TemplateSourceTests
    {
        private const string APACHE_URL = "https://svn.apache.org/repos/asf/httpd/httpd/trunk/docs/conf/mime.types";
        private const string NGINX_URL = "https://raw.githubusercontent.com/h5bp/server-configs-nginx/master/mime.types";
        private const string MIMEDB_URL = "https://raw.githubusercontent.com/jshttp/mime-db/master/src/custom-types.json";

        [TestMethod]
        public async Task TestApacheMimeTypesAsync()
        {
            var keyPairs = await GetMimeTypesFromTextAsync(APACHE_URL, line =>
            {
                if (line[0] == '#') return null;
                var parts = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                return parts.Length < 2 ? null : parts;
            });

            Assert.IsTrue(keyPairs.Any());
        }

        [TestMethod]
        public async Task TestNginxMimeTypesAsync()
        {
            var keyPairs = await GetMimeTypesFromTextAsync(NGINX_URL, line =>
            {
                line = line.Trim().TrimEnd(';');
                if (line[0] == '#' || line[0] == '}' || line.StartsWith("types {")) return null;
                var parts = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                return parts.Length < 2 ? null : parts;
            });

            Assert.IsTrue(keyPairs.Any());
        }

        [TestMethod]
        public async Task TestMimeDbMimeTypesAsync()
        {
            var keyPairs = await GetMimeTypesFromJsonAsync(MIMEDB_URL, resource =>
            {
                return from mimeTypes in resource.Children()
                       let mimeType = ((JProperty)mimeTypes).Name
                       from mimeTypeProperties in mimeTypes.Children()
                       from mimeTypeProperty in mimeTypeProperties.Children()
                       from mimeTypeValue in mimeTypeProperty.Values()
                       where (mimeTypeProperty as JProperty)?.Name == "extensions"
                       select new[]
                       {
                           mimeType,
                           mimeTypeValue.Value<string>()
                       };
            });

            Assert.IsTrue(keyPairs.Any());
        }

        private static async Task<string> GetPageContentAsync(string url)
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(url);
        }

        private static async Task<IEnumerable<string[]>> GetMimeTypesFromTextAsync(string url, Func<string, string[]> processLine)
        {
            var content = await GetPageContentAsync(url);
            if (string.IsNullOrEmpty(content)) return Enumerable.Empty<string[]>();
            var lines = content.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            return lines.Select(processLine).Where(newKeyPairs => newKeyPairs != null).ToList();
        }

        private static async Task<IEnumerable<string[]>> GetMimeTypesFromJsonAsync(string url, Func<JObject, IEnumerable<string[]>> processObject)
        {
            var content = await GetPageContentAsync(url);
            if (string.IsNullOrEmpty(content)) return Enumerable.Empty<string[]>();
            var resource = JObject.Parse(content);
            return processObject(resource);
        }
    }
}
