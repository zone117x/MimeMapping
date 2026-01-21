using System.Text.RegularExpressions;

namespace MimeMapping.SourceGenerator
{
    /// <summary>
    /// Utilities for generating valid C# field names from extensions and MIME types
    /// </summary>
    internal static class NameUtilities
    {
        private static readonly Regex NonAlphanumeric = new Regex("[^a-zA-Z0-9]");

        /// <summary>
        /// Generates a C# field name for a MIME type constant based on the extension.
        /// Examples:
        /// - "png" -> "Png"
        /// - "3dml" -> "_3dml"
        /// - "vbox-extpack" -> "Vboxextpack"
        /// </summary>
        public static string GetMimeFieldName(string extension)
        {
            // Uppercase first char, remove non-alphanumeric characters
            var result = NonAlphanumeric.Replace(
                char.ToUpperInvariant(extension[0]) + extension.Substring(1),
                "");

            // Prefix with underscore if starts with digit
            return char.IsDigit(result[0]) ? ("_" + result) : result;
        }

        /// <summary>
        /// Generates a C# field name for a file extension constant.
        /// Examples:
        /// - "png" -> "Png"
        /// - "3dml" -> "_3dml"
        /// - "vbox-extpack" -> "Vbox_extpack"
        /// </summary>
        public static string GetExtensionFieldName(string extension)
        {
            // Prefix with underscore if doesn't start with letter
            var prefix = !char.IsLetter(extension[0]) ? "_" : string.Empty;

            // Uppercase first char, replace hyphens with underscores
            var name = char.ToUpper(extension[0]) + extension.Substring(1).Replace('-', '_');

            return prefix + name;
        }
    }
}
