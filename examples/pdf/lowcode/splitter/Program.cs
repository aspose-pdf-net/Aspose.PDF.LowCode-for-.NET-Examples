using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.LowCode;
using Aspose.Pdf.Text;

class Program
{
    static void Main()
    {
        // Create input PDF
        const string inputPath = "input.pdf";
        var doc = new Document();
        var page = doc.Pages.Add();
        var tf = new TextFragment("Sample text");
        page.Paragraphs.Add(tf);
        doc.Save(inputPath);

        // Validate input exists
        if (!File.Exists(inputPath))
            throw new FileNotFoundException("Input PDF not found.", inputPath);

        // Prepare split options
        const string outputPath = "output.pdf";
        var options = new SplitOptions();
        options.AddInput(new FileDataSource(inputPath));
        options.AddOutput(new FileDataSource(outputPath));

        // Execute split plugin
        var splitter = new Splitter();
        var result = splitter.Process(options);

        // Verify result
        if (result?.ResultCollection == null || result.ResultCollection.Count == 0)
            throw new InvalidOperationException("Splitter did not produce any results.");

        // Validate output
        if (!File.Exists(outputPath))
            throw new FileNotFoundException("Output PDF was not created.", outputPath);

        long outputSize = new FileInfo(outputPath).Length;
        Console.WriteLine($"Success: output file size = {outputSize} bytes.");
    }
}