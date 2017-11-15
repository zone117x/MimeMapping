using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using MimeMapping;

namespace Test
{
    [TestClass]
    public class BasicTest
    {
        Dictionary<string, string> _expectedTypes = new Dictionary<string, string> {
            { "PNG", "image/png"},
            { "png", "image/png"},
            { "JPG", "image/jpeg"},
            { "mp4", "video/mp4" },
            { "exe", "application/x-msdownload" },
            { "zip", "application/zip" },
            { "torrent", "application/x-bittorrent" },
            { "json", "application/json" },
            { "asdfunknown", "application/octet-stream" }
        };

        [TestMethod]
        public void TestCommonTypes()
        {
            foreach (var t in _expectedTypes)
            {
                var foundType = MimeUtility.GetMimeMapping(t.Key);
                Assert.AreEqual(t.Value, foundType, "Mime string mismatch");
            }
        }

        [TestMethod]
        public void TestCommonTypesAsFilePaths()
        {
            foreach (var t in _expectedTypes)
            {
                var filePath = Path.Combine(Path.GetTempPath(), "examplefile." + t.Key);
                var foundType = MimeUtility.GetMimeMapping(t.Key);
                Assert.AreEqual(t.Value, foundType, "Mime string mismatch");
            }
        }

        [TestMethod]
        public void TestMimeTypeDictionaryCount()
        {
            Assert.IsTrue(MimeUtility.TypeMap.Count > 900, $"Type map only has {MimeUtility.TypeMap.Count} entries, something wrong");
        }
    }
}
