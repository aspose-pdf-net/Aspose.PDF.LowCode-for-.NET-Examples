using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.LowCode;

class Program
{
    static void Main()
    {
        // Prepare temporary file path
        string tempDir = Path.GetTempPath();
        string inputPath = Path.Combine(tempDir, "input.pdf");

        // Create a simple PDF document programmatically
        var pdfDoc = new Document();
        pdfDoc.Pages.Add();
        pdfDoc.Save(inputPath);

        // Validate input file exists
        if (!File.Exists(inputPath) || new FileInfo(inputPath).Length == 0)
        {
            throw new InvalidOperationException("Input PDF was not created correctly.");
        }

        // Set up TextExtractor options with input file
        var options = new TextExtractorOptions();
        options.AddInput(new FileDataSource(inputPath));

        // Process extraction
        var result = new TextExtractor().Process(options);

        // Check result and output extracted text
        if (result?.ResultCollection != null && result.ResultCollection.Count > 0)
        {
            var firstResult = result.ResultCollection[0];
            var textProperty = firstResult.GetType().GetProperty("Text");
            if (textProperty != null)
            {
                var extractedText = textProperty.GetValue(firstResult) as string;
                Console.WriteLine("Extracted: " + extractedText);
            }
            else
            {
                throw new InvalidOperationException("Result does not contain a Text property.");
            }
        }
        else
        {
            throw new InvalidOperationException("Text extraction failed – no results returned.");
        }
    }
}