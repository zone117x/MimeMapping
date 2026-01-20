using System;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace MimeMapping.SourceGenerator
{
    /// <summary>
    /// Source generator that produces KnownMimeTypes.cs from mime-db JSON data
    /// </summary>
    [Generator]
    public class KnownMimeTypesGenerator : IIncrementalGenerator
    {
        private const string MimeDbFileName = "mime-db.json";
        private const string MimeDbUrlPropertyName = "build_property.MimeDbUrl";
        private const string DefaultSourceUrl = "mime-db";

        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            // Find the mime-db.json from AdditionalFiles
            var mimeDbProvider = context.AdditionalTextsProvider
                .Where(file => file.Path.EndsWith(MimeDbFileName, StringComparison.OrdinalIgnoreCase))
                .Select((file, ct) => file.GetText(ct)?.ToString())
                .Where(content => !string.IsNullOrEmpty(content))
                .Collect()
                .Select((contents, ct) => contents.FirstOrDefault());

            // Get the MimeDbUrl from global options for documentation
            var optionsProvider = context.AnalyzerConfigOptionsProvider
                .Select((provider, ct) =>
                {
                    provider.GlobalOptions.TryGetValue(MimeDbUrlPropertyName, out var url);
                    return url ?? DefaultSourceUrl;
                });

            // Combine and generate
            var combined = mimeDbProvider.Combine(optionsProvider);

            context.RegisterSourceOutput(combined, (spc, tuple) =>
            {
                var (json, sourceUrl) = tuple;
                if (string.IsNullOrEmpty(json))
                {
                    // Report diagnostic if mime-db.json not found
                    spc.ReportDiagnostic(Diagnostic.Create(
                        new DiagnosticDescriptor(
                            "MIME001",
                            "mime-db.json not found",
                            "The mime-db.json file was not found in AdditionalFiles. Ensure the DownloadMimeDb MSBuild target runs before compilation.",
                            "MimeMapping.SourceGenerator",
                            DiagnosticSeverity.Error,
                            isEnabledByDefault: true),
                        Location.None));
                    return;
                }

                try
                {
                    var data = MimeDbParser.Parse(json!, sourceUrl);
                    var source = CodeGenerator.Generate(data);
                    spc.AddSource("KnownMimeTypes.g.cs", source);
                }
                catch (Exception ex)
                {
                    spc.ReportDiagnostic(Diagnostic.Create(
                        new DiagnosticDescriptor(
                            "MIME002",
                            "Failed to parse mime-db.json",
                            "Failed to parse mime-db.json: {0}",
                            "MimeMapping.SourceGenerator",
                            DiagnosticSeverity.Error,
                            isEnabledByDefault: true),
                        Location.None,
                        ex.Message));
                }
            });
        }
    }
}
