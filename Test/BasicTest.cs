using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MimeMapping;

namespace Test
{
    [TestClass]
    public class BasicTest
    {
        private readonly Dictionary<string, string> _expectedTypes = new Dictionary<string, string>
        {
            {"PNG", "image/png"},
            {"png", "image/png"},
            {"JPG", "image/jpeg"},
            {"mp4", "video/mp4"},
            {"mpd", "application/dash+xml" },
            {"exe", "application/x-msdownload"},
            {"zip", "application/zip"},
            {"torrent", "application/x-bittorrent"},
            {"json", "application/json"},
            {"asdfunknown", "application/octet-stream"}
        };

        [TestMethod]
        public void TestCommonTypes()
        {
            foreach (var t in _expectedTypes)
            {
                var filePath = Path.Combine(Path.GetTempPath(), "examplefile." + t.Key);
                var foundType = MimeUtility.GetMimeMapping(filePath);
                Assert.AreEqual(t.Value, foundType, "Mime string mismatch");
            }
        }

        [TestMethod]
        public void TestCommonTypesAsFilePaths()
        {
            foreach (var t in _expectedTypes)
            {
                var filePath = Path.Combine(Path.GetTempPath(), "examplefile." + t.Key);
                var foundType = MimeUtility.GetMimeMapping(filePath);
                Assert.AreEqual(t.Value, foundType, "Mime string mismatch");
            }
        }

        [TestMethod]
        public void TestCommonTypesWithOnlyFileNames()
        {
            foreach (var t in _expectedTypes)
            {
                var fileName = "examplefile." + t.Key;
                var foundType = MimeUtility.GetMimeMapping(fileName);
                Assert.AreEqual(t.Value, foundType, "Mime string mismatch");
            }
        }

        [TestMethod]
        public void TestEmptyStringFileArgumentReturnsUnknownMimeType()
        {
            Assert.AreEqual(MimeUtility.UnknownMimeType, MimeUtility.GetMimeMapping(string.Empty));
        }

        [TestMethod]
        public void TestNullFileArgumentThrowsException()
        {
            try
            {
                MimeUtility.GetMimeMapping(null);
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(ArgumentNullException));
            }
        }

        [TestMethod]
        public void TestMimeTypeDictionaryCount()
        {
            Assert.IsTrue(MimeUtility.TypeMap.Count > 900, $"Type map only has {MimeUtility.TypeMap.Count} entries, something wrong");
        }

        [TestMethod]
        public void TestUrlWithoutExtensionReturnsUnknownMimeType()
        {
            var myFile = "https://test.com/file/random-file";
            string mimeType = MimeUtility.GetMimeMapping(myFile);
            Assert.AreEqual(MimeUtility.UnknownMimeType, mimeType);
        }

        [TestMethod]
        public void TestMimeTypeLookupToGetExtensions()
        {
            var expected = new[] { KnownMimeTypes.Extensions._json, KnownMimeTypes.Extensions._map, KnownMimeTypes.Extensions._topojson };
            var actual = MimeUtility.GetExtensions(KnownMimeTypes.Json);
            Assert.IsTrue(actual.All(x => expected.Contains(x)));

            var @null = MimeUtility.GetExtensions("invalid");
            Assert.IsNull(@null);
        }
    }
}
