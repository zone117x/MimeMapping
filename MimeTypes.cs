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
        public static ReadOnlyDictionary<string, string> TypeMap => _lazyDict.Value;

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
