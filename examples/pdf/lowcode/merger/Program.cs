using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.LowCode;

namespace MergerExample
{
    class Program
    {
        static void Main()
        {
            // Prepare file paths
            string inputPath = Path.Combine(Directory.GetCurrentDirectory(), "input.pdf");
            string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "output.pdf");

            // Create a simple PDF document as input
            var doc = new Document();
            doc.Pages.Add();
            doc.Save(inputPath);

            // Validate input file exists and is non‑empty
            if (!File.Exists(inputPath) || new FileInfo(inputPath).Length == 0)
            {
                Console.WriteLine("Input file validation failed.");
                return;
            }

            // Set up merge options
            var options = new MergeOptions();
            options.AddInput(new FileDataSource(inputPath));
            options.AddOutput(new FileDataSource(outputPath));

            // Execute the merge process
            var result = new Merger().Process(options);

            // Check for successful result and validate output file
            if (result?.ResultCollection?.Count > 0 && File.Exists(outputPath))
            {
                Console.WriteLine($"Merge succeeded: {outputPath}");
            }
            else
            {
                Console.WriteLine("Merge failed.");
            }
        }
    }
}