using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace Test
{
    [TestClass]
    public class TemplateSourceTests
    {
        private const string APACHE_URL = "http://svn.apache.org/repos/asf/httpd/httpd/trunk/docs/conf/mime.types";
        private const string NGINX_URL = "https://raw.githubusercontent.com/h5bp/server-configs-nginx/master/mime.types";
        private const string MIMEDB_URL = "https://raw.githubusercontent.com/jshttp/mime-db/master/src/custom-types.json";

        [TestMethod]
        public void TestApacheMimeTypes()
        {
            var keyPairs = GetMimeTypesFromText(APACHE_URL, line =>
            {
                if (line[0] == '#') return null;
                var parts = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                return parts.Length < 2 ? null : parts;
            });

            Assert.IsTrue(keyPairs.Any());
        }

        [TestMethod]
        public void TestNginxMimeTypes()
        {
            var keyPairs = GetMimeTypesFromText(NGINX_URL, line =>
            {
                line = line.Trim().TrimEnd(';');
                if (line[0] == '#' || line[0] == '}' || line.StartsWith("types {")) return null;
                var parts = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                return parts.Length < 2 ? null : parts;
            });

            Assert.IsTrue(keyPairs.Any());
        }

        [TestMethod]
        public void TestMimeDbMimeTypes()
        {
            var content = GetPageContent(MIMEDB_URL);
            var resource = JObject.Parse(content);
            var entries = from mimeTypes in resource.Children() 
                let mimeType = ((JProperty) mimeTypes).Name 
                from mimeTypeProperties in mimeTypes.Children() 
                from mimeTypeProperty in mimeTypeProperties.Children() 
                where (mimeTypeProperty as JProperty)?.Name == "extensions" 
                select new[]
                {
                    mimeType, 
                    mimeTypeProperty.Values().First().Value<string>()
                };

            Assert.IsTrue(entries.Any());
        }

        private static string GetPageContent(string url)
        {
            using (var responseStream = WebRequest.CreateHttp(url).GetResponse().GetResponseStream())
            using (var streamReader = new StreamReader(responseStream, Encoding.UTF8))
            {
                return streamReader.ReadToEnd();
            }
        }

        private static IEnumerable<string[]> GetMimeTypesFromText(string url, Func<string, string[]> processLine)
        {
            var content = GetPageContent(url);
            var lines = content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return lines.Select(processLine).Where(newKeyPairs => newKeyPairs != null).ToList();
        }
    }
}
