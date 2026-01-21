using System.Text;

namespace MimeMapping.SourceGenerator
{
    /// <summary>
    /// Generates the KnownMimeTypes.cs source code from parsed MIME data
    /// </summary>
    internal static class CodeGenerator
    {
        public static string Generate(MimeDbData data)
        {
            var sb = new StringBuilder();

            // Header
            sb.AppendLine("using System;");
            sb.AppendLine();
            sb.AppendLine("#nullable enable");
            sb.AppendLine();
            sb.AppendLine("namespace MimeMapping");
            sb.AppendLine("{");

            // Class documentation
            sb.AppendLine("    ///<summary>");
            sb.AppendLine($"    /// MIME type constants. Last updated on {data.GeneratedAt:s}Z. ");
            sb.AppendLine($"    /// Generated from the <a href=\"{data.SourceUrl}\">mime-db</a> source");
            sb.AppendLine("    ///</summary>");
            sb.AppendLine("    public static class KnownMimeTypes");
            sb.AppendLine("    {");
            sb.AppendLine();

            // Conflict resolution comments
            foreach (var comment in data.ConflictComments)
            {
                sb.AppendLine($"        {comment}");
            }

            // Summary comments
            sb.AppendLine();
            sb.AppendLine($"        // Generated {data.MimeTypeToExtensions.Count} unique mime type values");
            sb.AppendLine($"        // Generated {data.ExtensionToMimeType.Count} type key pairs");
            sb.AppendLine();

            // Source URL constant
            sb.AppendLine("        ///<summary>The source URL of the mime-db data used to generate this file</summary>");
            sb.AppendLine($"        internal const string MimeDbSourceUrl = \"{data.SourceUrl}\";");
            sb.AppendLine();

            // MIME type constants
            foreach (var kv in data.ExtensionToMimeType)
            {
                var fieldName = NameUtilities.GetMimeFieldName(kv.Key);
                sb.AppendLine($"        ///<summary>{kv.Key}</summary>");
                sb.AppendLine($"        public const string {fieldName} = \"{kv.Value}\";");
            }

            // ALL_MIMETYPES lazy array
            sb.AppendLine("        // List of all available mimetypes, used to build the dictionary");
            sb.AppendLine("        internal static readonly Lazy<string[]> ALL_MIMETYPES = new Lazy<string[]>(() => new [] {");
            foreach (var kv in data.ExtensionToMimeType)
            {
                var fieldName = NameUtilities.GetMimeFieldName(kv.Key);
                sb.AppendLine($"            {fieldName},");
            }
            sb.AppendLine("        });");
            sb.AppendLine();
            sb.AppendLine();

            // FileExtensions nested class
            sb.AppendLine("        ///<summary>File extensions</summary>");
            sb.AppendLine("        public static class FileExtensions");
            sb.AppendLine("        {");
            foreach (var kv in data.ExtensionToMimeType)
            {
                var fieldName = NameUtilities.GetExtensionFieldName(kv.Key);
                sb.AppendLine($"            ///<summary>{kv.Key}</summary>");
                sb.AppendLine($"            public const string {fieldName} = \"{kv.Key}\";");
            }
            sb.AppendLine("        }");
            sb.AppendLine();

            // ALL_EXTS lazy array
            sb.AppendLine("        // List of all available extensions, used to build the dictionary");
            sb.AppendLine("        internal static readonly Lazy<string[]> ALL_EXTS = new Lazy<string[]>(() => new [] {");
            foreach (var kv in data.ExtensionToMimeType)
            {
                var fieldName = NameUtilities.GetExtensionFieldName(kv.Key);
                sb.AppendLine($"            FileExtensions.{fieldName},");
            }
            sb.AppendLine("        });");
            sb.AppendLine();
            sb.AppendLine();

            // LookupType switch statement
            GenerateLookupTypeMethod(sb, data);

            // LookupMimeType switch statement
            GenerateLookupMimeTypeMethod(sb, data);

            // Close class and namespace
            sb.AppendLine("    }");
            sb.AppendLine("}");

            return sb.ToString();
        }

        private static void GenerateLookupTypeMethod(StringBuilder sb, MimeDbData data)
        {
            sb.AppendLine("        // Switch-case instead of dictionary since it does the hashing at compile time rather than run time");
            sb.AppendLine("        internal static string? LookupType(string type)");
            sb.AppendLine("        {");
            sb.AppendLine("            switch (type)");
            sb.AppendLine("            {");

            foreach (var kv in data.MimeTypeToExtensions)
            {
                var mimeType = kv.Key;
                var extensions = kv.Value;

                // Generate case statements for all extensions that map to this MIME type
                foreach (var ext in extensions)
                {
                    var fieldName = NameUtilities.GetExtensionFieldName(ext);
                    sb.AppendLine($"                case FileExtensions.{fieldName}:");
                }

                // Return the MIME type constant (use first extension's field name)
                var firstFieldName = NameUtilities.GetMimeFieldName(extensions[0]);
                sb.AppendLine($"                    return {firstFieldName};");
                sb.AppendLine();
            }

            sb.AppendLine("                default: ");
            sb.AppendLine("                    return null;");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        private static void GenerateLookupMimeTypeMethod(StringBuilder sb, MimeDbData data)
        {
            sb.AppendLine("        // Switch-case instead of dictionary since it does the hashing at compile time rather than run time");
            sb.AppendLine("        internal static string[]? LookupMimeType(string mimeType)");
            sb.AppendLine("        {");
            sb.AppendLine("            switch (mimeType)");
            sb.AppendLine("            {");

            foreach (var kv in data.MimeTypeToExtensions)
            {
                var extensions = kv.Value;
                var first = true;

                // Generate case statements for each extension's MIME type constant
                foreach (var ext in extensions)
                {
                    var fieldName = NameUtilities.GetMimeFieldName(ext);
                    if (first)
                    {
                        sb.AppendLine($"                case {fieldName}:");
                        first = false;
                    }
                    else
                    {
                        // Comment out additional cases (they're duplicates pointing to same MIME type)
                        sb.AppendLine($"                //case {fieldName}:");
                    }
                }

                // Return array of extension constants
                var extFieldNames = new StringBuilder();
                for (int i = 0; i < extensions.Count; i++)
                {
                    if (i > 0) extFieldNames.Append(", ");
                    extFieldNames.Append($"FileExtensions.{NameUtilities.GetExtensionFieldName(extensions[i])}");
                }
                sb.AppendLine($"                    return new[] {{{extFieldNames}}};");
            }

            sb.AppendLine("                default: ");
            sb.AppendLine("                    return null;");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
        }
    }
}
