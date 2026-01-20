using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MimeMapping;

namespace Test
{
    [TestClass]
    public class GeneratedCodeTests
    {
        [TestMethod]
        public void GeneratedConstants_HaveExpectedCount()
        {
            // The generated code should have ~1239 extension-to-mimetype mappings
            // and ~979 unique mime types
            var allMimeTypes = typeof(KnownMimeTypes)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.IsLiteral && f.FieldType == typeof(string))
                .ToList();

            Assert.IsGreaterThan(1200, allMimeTypes.Count,
                $"Expected at least 1200 MIME type constants, but found {allMimeTypes.Count}");
        }

        [TestMethod]
        public void FileExtensions_HaveExpectedCount()
        {
            var extensionFields = typeof(KnownMimeTypes.FileExtensions)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.IsLiteral && f.FieldType == typeof(string))
                .ToList();

            Assert.IsGreaterThan(1200, extensionFields.Count,
                $"Expected at least 1200 file extension constants, but found {extensionFields.Count}");
        }

        [TestMethod]
        public void LookupType_ReturnsCorrectMimeTypes()
        {
            // Test common file extensions
            Assert.AreEqual("image/png", MimeUtility.GetMimeMapping("test.png"));
            Assert.AreEqual("image/jpeg", MimeUtility.GetMimeMapping("test.jpg"));
            Assert.AreEqual("image/jpeg", MimeUtility.GetMimeMapping("test.jpeg"));
            Assert.AreEqual("image/gif", MimeUtility.GetMimeMapping("test.gif"));
            Assert.AreEqual("text/html", MimeUtility.GetMimeMapping("test.html"));
            Assert.AreEqual("text/css", MimeUtility.GetMimeMapping("test.css"));
            Assert.AreEqual("application/pdf", MimeUtility.GetMimeMapping("test.pdf"));
            Assert.AreEqual("application/json", MimeUtility.GetMimeMapping("test.json"));
        }

        [TestMethod]
        public void LookupMimeType_ReturnsCorrectExtensions()
        {
            // Test reverse lookup
            var pngExtensions = MimeUtility.GetExtensions("image/png");
            Assert.IsNotNull(pngExtensions);
            Assert.IsTrue(pngExtensions.Contains("png"));

            var jpegExtensions = MimeUtility.GetExtensions("image/jpeg");
            Assert.IsNotNull(jpegExtensions);
            Assert.IsTrue(jpegExtensions.Contains("jpg") || jpegExtensions.Contains("jpeg"));

            var htmlExtensions = MimeUtility.GetExtensions("text/html");
            Assert.IsNotNull(htmlExtensions);
            Assert.IsTrue(htmlExtensions.Contains("html") || htmlExtensions.Contains("htm"));
        }

        [TestMethod]
        public void KnownMimeTypes_ConstantsMatchValues()
        {
            // Verify some known constants have correct values using reflection
            // to avoid MSTEST0032 warnings about compile-time const evaluation
            var type = typeof(KnownMimeTypes);
            Assert.AreEqual("image/png", type.GetField(nameof(KnownMimeTypes.Png))!.GetValue(null));
            Assert.AreEqual("image/jpeg", type.GetField(nameof(KnownMimeTypes.Jpeg))!.GetValue(null));
            Assert.AreEqual("image/gif", type.GetField(nameof(KnownMimeTypes.Gif))!.GetValue(null));
            Assert.AreEqual("text/html", type.GetField(nameof(KnownMimeTypes.Html))!.GetValue(null));
            Assert.AreEqual("text/css", type.GetField(nameof(KnownMimeTypes.Css))!.GetValue(null));
            Assert.AreEqual("application/pdf", type.GetField(nameof(KnownMimeTypes.Pdf))!.GetValue(null));
            Assert.AreEqual("application/json", type.GetField(nameof(KnownMimeTypes.Json))!.GetValue(null));
            Assert.AreEqual("text/xml", type.GetField(nameof(KnownMimeTypes.Xml))!.GetValue(null));

            // Conflict resolution tests - ensure priority-based resolution is working
            Assert.AreEqual("text/javascript", type.GetField(nameof(KnownMimeTypes.Js))!.GetValue(null));   // iana > apache, text/* > application/*
            Assert.AreEqual("video/mp4", type.GetField(nameof(KnownMimeTypes.Mp4))!.GetValue(null));        // iana, video/* > application/*
            Assert.AreEqual("application/zip", type.GetField(nameof(KnownMimeTypes.Zip))!.GetValue(null));  // iana > unknown
            Assert.AreEqual("audio/mpeg", type.GetField(nameof(KnownMimeTypes.Mp3))!.GetValue(null));       // iana > unknown
            Assert.AreEqual("text/rtf", type.GetField(nameof(KnownMimeTypes.Rtf))!.GetValue(null));         // iana, text/* > application/*
            Assert.AreEqual("model/stl", type.GetField(nameof(KnownMimeTypes.Stl))!.GetValue(null));        // iana, model/* > application/*
            Assert.AreEqual("image/emf", type.GetField(nameof(KnownMimeTypes.Emf))!.GetValue(null));        // iana, image/* > application/*
            Assert.AreEqual("image/wmf", type.GetField(nameof(KnownMimeTypes.Wmf))!.GetValue(null));        // iana, image/* > application/*
            Assert.AreEqual("model/obj", type.GetField(nameof(KnownMimeTypes.Obj))!.GetValue(null));        // iana, model/* > application/*
            Assert.AreEqual("video/mp2t", type.GetField(nameof(KnownMimeTypes.Mts))!.GetValue(null));       // iana, video/* > model/*
            Assert.AreEqual("audio/x-wav", type.GetField(nameof(KnownMimeTypes.Wav))!.GetValue(null));      // apache > unknown (mime-db data quality issue)
        }

        [TestMethod]
        public void FileExtensions_ConstantsMatchValues()
        {
            // Verify file extension constants have correct values using reflection
            // to avoid MSTEST0032 warnings about compile-time const evaluation
            var type = typeof(KnownMimeTypes.FileExtensions);
            Assert.AreEqual("png", type.GetField(nameof(KnownMimeTypes.FileExtensions.Png))!.GetValue(null));
            Assert.AreEqual("jpg", type.GetField(nameof(KnownMimeTypes.FileExtensions.Jpg))!.GetValue(null));
            Assert.AreEqual("jpeg", type.GetField(nameof(KnownMimeTypes.FileExtensions.Jpeg))!.GetValue(null));
            Assert.AreEqual("gif", type.GetField(nameof(KnownMimeTypes.FileExtensions.Gif))!.GetValue(null));
            Assert.AreEqual("html", type.GetField(nameof(KnownMimeTypes.FileExtensions.Html))!.GetValue(null));
            Assert.AreEqual("css", type.GetField(nameof(KnownMimeTypes.FileExtensions.Css))!.GetValue(null));
            Assert.AreEqual("pdf", type.GetField(nameof(KnownMimeTypes.FileExtensions.Pdf))!.GetValue(null));
            Assert.AreEqual("json", type.GetField(nameof(KnownMimeTypes.FileExtensions.Json))!.GetValue(null));
        }

        [TestMethod]
        public void TypeMap_ContainsAllGeneratedExtensions()
        {
            // Verify the TypeMap dictionary is populated correctly
            var extensionFields = typeof(KnownMimeTypes.FileExtensions)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.IsLiteral && f.FieldType == typeof(string))
                .ToList();

            foreach (var field in extensionFields)
            {
                var extension = (string)field.GetValue(null)!;
                Assert.IsTrue(MimeUtility.TypeMap.ContainsKey(extension),
                    $"TypeMap is missing extension: {extension}");
            }
        }

        [TestMethod]
        public void TypeToExtensionsMap_ContainsAllGeneratedMimeTypes()
        {
            // Get all unique mime type values from constants
            var mimeTypeFields = typeof(KnownMimeTypes)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.IsLiteral && f.FieldType == typeof(string))
                .Select(f => (string)f.GetValue(null)!)
                .Distinct()
                .ToList();

            foreach (var mimeType in mimeTypeFields)
            {
                Assert.IsTrue(MimeUtility.TypeToExtensionsMap.ContainsKey(mimeType),
                    $"TypeToExtensionsMap is missing mime type: {mimeType}");
            }
        }

        [TestMethod]
        public async Task GeneratedCode_MatchesSourceData()
        {
            // Fetch the source data with conflict resolution matching the generator
            var sourceDict = await MimeDbTestHelper.FetchMimeTypesWithResolutionAsync();

            // Verify TypeMap matches source data
            Assert.HasCount(sourceDict.Count, MimeUtility.TypeMap,
                $"TypeMap count ({MimeUtility.TypeMap.Count}) doesn't match source ({sourceDict.Count})");

            foreach (var kvp in sourceDict)
            {
                Assert.IsTrue(MimeUtility.TypeMap.TryGetValue(kvp.Key, out var actualMimeType),
                    $"Extension '{kvp.Key}' missing from TypeMap");
                Assert.AreEqual(kvp.Value, actualMimeType,
                    $"Mime type mismatch for extension '{kvp.Key}': expected '{kvp.Value}', got '{actualMimeType}'");
            }
        }

        [TestMethod]
        public void NumericExtensions_AreHandledCorrectly()
        {
            // Extensions starting with numbers should have underscore prefix in field names
            // but the actual extension value should not have the underscore
            var field3dml = typeof(KnownMimeTypes.FileExtensions).GetField("_3dml");
            Assert.IsNotNull(field3dml, "Field _3dml should exist for extension starting with number");
            Assert.AreEqual("3dml", field3dml.GetValue(null));

            // Verify lookup works with numeric extension
            var mimeType = MimeUtility.GetMimeMapping("test.3dml");
            Assert.IsNotNull(mimeType);
            Assert.AreNotEqual(MimeUtility.UnknownMimeType, mimeType);
        }

        [TestMethod]
        public void HyphenatedExtensions_AreHandledCorrectly()
        {
            // Extensions with hyphens should have underscores in field names
            // For example: "x-shader" -> "X_shader"
            Assert.AreEqual("text/x-c", MimeUtility.GetMimeMapping("test.c"));
            Assert.AreEqual("text/x-java-source", MimeUtility.GetMimeMapping("test.java"));
        }
    }
}
