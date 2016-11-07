# MimeMapping

Dictionary generated from the [Apache Server mime.types file](http://svn.apache.org/repos/asf/httpd/httpd/trunk/docs/conf/mime.types). 

# Example Usage
``` C#
string myFile = "myimage.jpg";
string mimeType = MimeMapping.MimeTypes.GetMimeMapping(myFile);
Console.WriteLine(mimeType); // output: image/jpeg

string randomFile = "data.asdf";
string mimeType = MimeMapping.MimeTypes.GetMimeMapping(randomFile);
Console.WriteLine(mimeType); // output: application/octet-stream
```

# TODO:
Add nginx definitions to dictionary generator template: https://github.com/h5bp/server-configs-nginx/blob/master/mime.types
