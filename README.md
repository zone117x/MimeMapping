# MimeMapping

[![Nuget](https://img.shields.io/nuget/v/MimeMapping)](https://www.nuget.org/packages/MimeMapping/)
[![Nuget](https://img.shields.io/nuget/dt/MimeMapping)](https://www.nuget.org/packages/MimeMapping/)
[![build](https://github.com/zone117x/MimeMapping/actions/workflows/build.yml/badge.svg)](https://github.com/zone117x/MimeMapping/actions/workflows/build.yml)
[![codecov](https://codecov.io/github/zone117x/MimeMapping/branch/master/graph/badge.svg)](https://codecov.io/github/zone117x/MimeMapping)

Constants for (almost) all MIME types and method to determine MIME type from a file name.
Contains just over 1000 mime types.

The Dictionary is generated from the [`jshttp/mime-db`](https://github.com/jshttp/mime-db#mime-db) `db.json`.
Works similar to .NET's [System.Web.MimeMapping.GetMimeMapping](https://learn.microsoft.com/dotnet/api/system.web.mimemapping.getmimemapping).

It aggregates data from the following sources:

- <https://www.iana.org/assignments/media-types/media-types.xhtml>
- <https://svn.apache.org/repos/asf/httpd/httpd/trunk/docs/conf/mime.types>
- <https://hg.nginx.org/nginx/raw-file/default/conf/mime.types>

The library is just a literal C# `Dictionary<string, string>` with over 1000 entries, and a helper method that can be passed a file path.

## Example Usage

```C#
string myFile = "myimage.jpg";
string mimeType = MimeMapping.MimeUtility.GetMimeMapping(myFile);
Console.WriteLine(mimeType); // output: image/jpeg

string randomFile = "data.asdf";
string mimeType = MimeMapping.MimeUtility.GetMimeMapping(randomFile);
Console.WriteLine(mimeType); // output: application/octet-stream

string rawExtension = "json";
string mimeType = MimeMapping.MimeUtility.GetMimeMapping(rawExtension);
Console.WriteLine(mimeType); // output: application/json


// List all types..
foreach(var kp in MimeMapping.MimeTypes.TypeMap)
{
  Console.WriteLine($"File extension: {kp.Key}, mime string: {kp.Value}");
}
```
