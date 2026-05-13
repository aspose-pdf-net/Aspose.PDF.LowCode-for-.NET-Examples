using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.LowCode;
using Aspose.Pdf.Text;

class Program
{
    static void Main()
    {
        // 1. Create input PDF
        string inputPath = Path.Combine(Path.GetTempPath(), "input.pdf");
        var doc = new Document();
        var page = doc.Pages.Add();
        page.Paragraphs.Add(new TextFragment("Hello LowCode PdfAConverter!"));
        doc.Save(inputPath);

        // Validate input file exists
        if (!File.Exists(inputPath))
        {
            Console.WriteLine("Input PDF not found.");
            return;
        }

        // 2. Set up conversion options
        string outputPath = Path.Combine(Path.GetTempPath(), "output.pdf");
        var options = new PdfAConvertOptions();
        options.AddInput(new FileDataSource(inputPath));
        options.AddOutput(new FileDataSource(outputPath));

        // 3. Execute conversion using PdfAConverter
        var converter = new PdfAConverter();
        var result = converter.Process(options);

        // 4. Validate output
        if (result != null && result.ResultCollection != null && result.ResultCollection.Count > 0 && File.Exists(outputPath))
        {
            Console.WriteLine($"Success: output file size = {new FileInfo(outputPath).Length} bytes");
        }
        else
        {
            Console.WriteLine("Conversion failed or output file not found.");
        }
    }
}