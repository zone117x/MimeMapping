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
        private readonly Dictionary<string, string> _expectedTypes = new()
        {
            { "PNG", "image/png" },
            { "png", "image/png" },
            { "JPG", "image/jpeg" },
            { "mp4", "application/mp4" },
            { "exe", "application/octet-stream" },
            { "zip", "application/x-zip-compressed" },
            { "torrent", "application/x-bittorrent" },
            { "json", "application/json" },
            { "asdfunknown", "application/octet-stream" },
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
            Assert.ThrowsExactly<ArgumentNullException>(() => MimeUtility.GetMimeMapping(null!));
        }

        [TestMethod]
        public void TestMimeTypeDictionaryCount()
        {
            Assert.IsGreaterThan(900, MimeUtility.TypeMap.Count,
                $"Type map only has {MimeUtility.TypeMap.Count} entries, something wrong");
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
            var expected = new[]
            {
                KnownMimeTypes.FileExtensions.Json,
                KnownMimeTypes.FileExtensions.Map,
            };
            var actual = MimeUtility.GetExtensions(KnownMimeTypes.Json);
            Assert.IsTrue(Array.TrueForAll(actual, x => expected.Contains(x)));

            var @null = MimeUtility.GetExtensions("invalid");
            Assert.IsNull(@null);
        }

        [TestMethod]
        public void TestMimeTypeToExtenstionsLookup()
        {
            Assert.IsTrue(MimeUtility.TypeToExtensionsMap.TryGetValue(KnownMimeTypes.Doc, out var extensions));
            Assert.IsNotNull(extensions);
            Assert.IsGreaterThanOrEqualTo(2, extensions.Length,
                $"The {KnownMimeTypes.Doc} has only {extensions.Length} extensions. It should be 2 (doc, dot).");

            Assert.IsTrue(MimeUtility.TypeToExtensionsMap.TryGetValue(KnownMimeTypes.Jpeg, out extensions));
            Assert.IsNotNull(extensions);
            Assert.IsGreaterThanOrEqualTo(3, extensions.Length,
                $"The {KnownMimeTypes.Jpeg} has only {extensions.Length} extensions. It should be 3.");

            Assert.IsGreaterThan(900, MimeUtility.TypeToExtensionsMap.Count,
                $"TypeToExtensions map only has {MimeUtility.TypeToExtensionsMap.Count} entries, something wrong");

            foreach (var kv in MimeUtility.TypeToExtensionsMap)
            {
                Assert.IsNotEmpty(kv.Value, $"{kv.Key} cannot have zero extensions.");
            }
        }
    }
}
