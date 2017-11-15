using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace MimeMapping
{
    /// <summary>
    /// MIME type utility to lookup by file extension
    /// </summary>
    public static class MimeUtility
    {
        /// <summary>
        /// The "octet-stream" subtype is used to indicate that a body contains arbitrary binary data.
        /// See <a href="https://www.iana.org/assignments/media-types/application/octet-stream">application/octet-stream</a>
        /// </summary>
        public const string UnknownMimeType = "application/octet-stream";

        static Lazy<ReadOnlyDictionary<string, string>> _lazyDict = new Lazy<ReadOnlyDictionary<string, string>>(
            () => new ReadOnlyDictionary<string, string>(KnownMimeTypes.ALL_EXTS.Value.ToDictionary(e => e, e => KnownMimeTypes.LookupType(e)))
        );

        /// <summary>
        /// Dictionary of all available types (lazy loaded on first call)
        /// </summary>
        public static ReadOnlyDictionary<string, string> TypeMap => _lazyDict.Value;

        /// <param name="file">The file extensions (ex: "zip"), the file name, or file path</param>
        /// <returns>The mime type string, returns "application/octet-stream" if no known type was found</returns>
        public static string GetMimeMapping(string file)
        {
            string fileExtension;
            if (file.Contains("."))
            {
                fileExtension = Path.GetExtension(file).Substring(1);
            }
            else
            {
                fileExtension = file;
            }
            string mimeType = KnownMimeTypes.LookupType(fileExtension.ToLowerInvariant());
            return mimeType ?? UnknownMimeType;
        }
        
    }
}
