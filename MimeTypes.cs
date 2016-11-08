using System;
using System.Collections.ObjectModel;
using System.IO;

namespace MimeMapping
{
	public static partial class MimeTypes
	{
		public const string UnknownMimeType = "application/octet-stream";

		static Lazy<ReadOnlyDictionary<string, string>> _lazyDict = new Lazy<ReadOnlyDictionary<string, string>>(() => new ReadOnlyDictionary<string, string>(_typeMap));
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
			string mimeType;
			if (_typeMap.TryGetValue(fileExtension, out mimeType))
			{
				return mimeType;
			}
			return UnknownMimeType;
		}

	}
}
