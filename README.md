# MimeMapping

Dictionary generated from the [Apache Server mime.types file](http://svn.apache.org/repos/asf/httpd/httpd/trunk/docs/conf/mime.types) and 
the [H5BP nginx mime.types file](https://github.com/h5bp/server-configs-nginx/blob/master/mime.types).



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
