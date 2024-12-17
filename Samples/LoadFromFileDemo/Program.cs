// See https://aka.ms/new-console-template for more information

using AlzPdf;

Console.WriteLine("AlzPdf load pdf file from path");

var pdfPath="Assets/pdf_reference_1.7.pdf";

var pdfDocument = new PdfDocument(pdfPath);

Console.WriteLine($"Load pdf page count: {pdfDocument.PageCount}");