# MimeMapping

[![Nuget](https://img.shields.io/nuget/v/MimeMapping)](https://www.nuget.org/packages/MimeMapping/) [![Nuget](https://img.shields.io/nuget/dt/MimeMapping)](https://www.nuget.org/packages/MimeMapping/)

Dictionary generated from the [Apache Server mime.types file](http://svn.apache.org/repos/asf/httpd/httpd/trunk/docs/conf/mime.types) and 
the [H5BP nginx mime.types file](https://github.com/h5bp/server-configs-nginx/blob/master/mime.types).

The Apache entries are used over others when collisions are found since they are from the official [IANA registery](http://www.iana.org/assignments/media-types). The others tend to use what works best for browsers or de facto standards (maybe we should use those ones instead, idk).

The lib is just a literal C# Dictionary<string, string> with over 1000 entries, and a helper method that can be passed a file path. 


# Example Usage
``` C#
string myFile = "myimage.jpg";
string mimeType = MimeMapping.MimeTypes.GetMimeMapping(myFile);
Console.WriteLine(mimeType); // output: image/jpeg

string randomFile = "data.asdf";
string mimeType = MimeMapping.MimeTypes.GetMimeMapping(randomFile);
Console.WriteLine(mimeType); // output: application/octet-stream

string rawExtension = "json";
string mimeType = MimeMapping.MimeTypes.GetMimeMapping(rawExtension);
Console.WriteLine(mimeType); // output: application/json


// List all types..
foreach(var kp in MimeMapping.MimeTypes.TypeMap)
{
	Console.WriteLine($"File extension: {kp.Key}, mime string: {kp.Value}");
}
```
