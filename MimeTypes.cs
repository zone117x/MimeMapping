using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace MimeMapping
{
    public static partial class MimeTypes
    {
        public const string UnknownMimeType = "application/octet-stream";

        static Lazy<ReadOnlyDictionary<string, string>> _lazyDict = new Lazy<ReadOnlyDictionary<string, string>>(() => new ReadOnlyDictionary<string, string>(ALL_EXTS.ToDictionary(e => e, e => LookupType(e))));

        /// <summary>
        /// Dictionary of all available types
        /// </summary>
        public static ReadOnlyDictionary<string, string> TypeMap => _lazyDict.Value;

        /// <param name="file">The raw file extensions (ex: "zip") or the file name or file path</param>
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
            string mimeType = LookupType(fileExtension);
            return mimeType ?? UnknownMimeType;
        }
    }
}
