using System;
using System.Collections.Generic;

namespace MimeMapping.SourceGenerator
{
    /// <summary>
    /// Data model containing parsed MIME type mappings from mime-db
    /// </summary>
    internal sealed class MimeDbData
    {
        /// <summary>
        /// Extension to MIME type mapping (after conflict resolution)
        /// Key: extension (e.g., "png"), Value: MIME type (e.g., "image/png")
        /// </summary>
        public Dictionary<string, string> ExtensionToMimeType { get; }

        /// <summary>
        /// MIME type to extensions mapping (reverse lookup)
        /// Key: MIME type, Value: list of extensions
        /// </summary>
        public Dictionary<string, List<string>> MimeTypeToExtensions { get; }

        /// <summary>
        /// Conflict resolution comments to include in generated code
        /// </summary>
        public List<string> ConflictComments { get; }

        /// <summary>
        /// Timestamp when the data was generated
        /// </summary>
        public DateTime GeneratedAt { get; }

        /// <summary>
        /// Source URL of the mime-db data
        /// </summary>
        public string SourceUrl { get; }

        public MimeDbData(
            Dictionary<string, string> extensionToMimeType,
            Dictionary<string, List<string>> mimeTypeToExtensions,
            List<string> conflictComments,
            DateTime generatedAt,
            string sourceUrl)
        {
            ExtensionToMimeType = extensionToMimeType ?? throw new ArgumentNullException(nameof(extensionToMimeType));
            MimeTypeToExtensions = mimeTypeToExtensions ?? throw new ArgumentNullException(nameof(mimeTypeToExtensions));
            ConflictComments = conflictComments ?? throw new ArgumentNullException(nameof(conflictComments));
            GeneratedAt = generatedAt;
            SourceUrl = sourceUrl ?? throw new ArgumentNullException(nameof(sourceUrl));
        }
    }
}
