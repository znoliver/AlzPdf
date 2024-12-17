using System.Runtime.InteropServices;

namespace AlzPdf;

internal static partial class PdfiumWrapper
{
    [LibraryImport("pdfium")]
    internal static partial void FPDF_InitLibrary();

    [LibraryImport("pdfium")]
    internal static partial void FPDF_DestroyLibrary();

    [LibraryImport("pdfium", StringMarshalling = StringMarshalling.Utf8)]
    internal static partial IntPtr FPDF_LoadDocument(string pdfPath, string password = "");

    [LibraryImport("pdfium")]
    internal static partial int FPDF_GetPageCount(IntPtr documentPtr);

    [LibraryImport("pdfium")]
    internal static partial IntPtr FPDF_LoadPage(IntPtr documentPtr, int pageIndex);
}