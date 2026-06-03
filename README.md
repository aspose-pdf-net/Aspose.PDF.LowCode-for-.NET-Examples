# Aspose.PDF for .NET LowCode Examples

[![NuGet Version](https://img.shields.io/nuget/v/Aspose.PDF.svg?style=flat&label=NuGet%3A%20Aspose.PDF)](https://www.nuget.org/packages/Aspose.PDF)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Aspose.PDF.svg?style=flat)](https://www.nuget.org/packages/Aspose.PDF)
[![GitHub license](https://img.shields.io/github/license/aspose-pdf-net/Aspose.PDF.LowCode-for-.NET-Examples)](https://github.com/aspose-pdf-net/Aspose.PDF.LowCode-for-.NET-Examples/blob/main/LICENSE)

## Overview

This repository contains verified C# examples for the **Aspose.PDF for .NET LowCode API** — a set of
high-level classes in the `Aspose.Pdf.LowCode` namespace that perform common
document-processing operations in a single method call.

Each example is a self-contained .NET project validated through `dotnet build` + runtime execution + output verification.

---

## Included Examples

| # | Example | API Class | Description |
|---|---------|-----------|-------------|
| 1 | `doc-converter` | `DocConverter` | Convert PDF to DOCX |
| 2 | `form-editor` | `FormEditor` | Edit PDF form fields |
| 3 | `form-exporter` | `FormExporter` | Export PDF form data |
| 4 | `form-flattener` | `FormFlattener` | Flatten PDF form fields |
| 5 | `html` | `Html` | Convert HTML to PDF |
| 6 | `image-extractor` | `ImageExtractor` | Extract images from PDF |
| 7 | `jpeg` | `Jpeg` | Convert PDF pages to JPEG |
| 8 | `merger` | `Merger` | Merge multiple PDFs |
| 9 | `optimizer` | `Optimizer` | Optimize PDF file size |
| 10 | `pdfa-converter` | `PdfAConverter` | Convert PDF to PDF/A |
| 11 | `png` | `Png` | Convert PDF pages to PNG |
| 12 | `security` | `Security` | Encrypt/protect PDF |
| 13 | `signature` | `Signature` | Digitally sign PDF (runtime test cert) |
| 14 | `splitter` | `Splitter` | Split PDF into pages |
| 15 | `table-generator` | `TableGenerator` | Generate tables in PDF |
| 16 | `text-extractor` | `TextExtractor` | Extract text from PDF |
| 17 | `tiff` | `Tiff` | Convert PDF pages to TIFF |
| 18 | `timestamp` | `Timestamp` | Add timestamp to PDF (TSA server) |
| 19 | `toc-generator` | `TocGenerator` | Generate table of contents |
| 20 | `xls-converter` | `XlsConverter` | Convert PDF to XLSX |

---

## How to Run

Clone the repository and run any example:

```bash
git clone https://github.com/aspose-pdf-net/Aspose.PDF.LowCode-for-.NET-Examples.git
cd Aspose.PDF.LowCode-for-.NET-Examples

# Run a specific example
cd examples/pdf/lowcode/<example-name>
dotnet restore
dotnet run
```

Each example is a self-contained .NET project that creates its own input fixtures at runtime
and produces output files in the working directory.

---

## Requirements

- .NET 8+ (target framework: `net8.0`)
- NuGet package: [`Aspose.PDF`](https://www.nuget.org/packages/Aspose.PDF)

---

## Environment-Dependent Examples

- **timestamp**: Requires a TSA (Time Stamping Authority) server. The example handles unavailability gracefully.
- **signature**: Generates a self-signed test certificate at runtime. No static PFX is committed.

---

## Repository Layout

```
Aspose.PDF.LowCode-for-.NET-Examples/
├── examples/
│   └── pdf/
│       └── lowcode/
│           ├── doc-converter/
│           ├── form-editor/
│           ├── form-exporter/
│           ├── form-flattener/
│           ├── html/
│           ├── image-extractor/
│           ├── jpeg/
│           ├── merger/
│           ├── optimizer/
│           ├── pdfa-converter/
│           ├── png/
│           ├── security/
│           ├── signature/
│           ├── splitter/
│           ├── table-generator/
│           ├── text-extractor/
│           ├── tiff/
│           ├── timestamp/
│           ├── toc-generator/
│           └── xls-converter/
├── Directory.Build.props
├── Directory.Packages.props
└── global.json
```

---

## Validation Status

All 20 examples are validated before publishing:

| Stage | Status |
|-------|--------|
| dotnet restore | PASS |
| dotnet build | PASS |
| dotnet run (exit 0) | PASS |

---

## Useful Links

- **NuGet Package:** [Aspose.PDF](https://www.nuget.org/packages/Aspose.PDF)
- **Product Page:** [Aspose.PDF for .NET](https://products.aspose.com/pdf/net/)
- **Documentation:** [Aspose.PDF for .NET Docs](https://docs.aspose.com/pdf/net/)
- **API Reference:** [Aspose.PDF for .NET API Reference](https://reference.aspose.com/pdf/net/)
- **Support Forum:** [Aspose.PDF Forum](https://forum.aspose.com/c/pdf/)
- **Temporary License:** [Get a Free Temporary License](https://purchase.aspose.com/temporary-license)

---

## License

This repository is licensed under the [MIT License](LICENSE).

The `Aspose.PDF` NuGet package requires a valid Aspose license or a
[free temporary license](https://purchase.aspose.com/temporary-license) for development use.
