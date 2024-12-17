namespace AlzPdf;

public class PdfDocument : IDisposable
{
    private readonly IntPtr _pdfDocumentPtr;

    public int PageCount { get; private set; }

    public PdfDocument(string pdfPath)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(pdfPath);
        if (!File.Exists(pdfPath))
        {
            throw new FileNotFoundException("The pdf file not found", pdfPath);
        }

        PdfiumWrapper.FPDF_InitLibrary();
        var pdfDocumentPtr = PdfiumWrapper.FPDF_LoadDocument(pdfPath);
        if (pdfDocumentPtr == IntPtr.Zero)
        {
            throw new FileLoadException("Can not load pdf.", pdfPath);
        }

        _pdfDocumentPtr = pdfDocumentPtr;

        PageCount = PdfiumWrapper.FPDF_GetPageCount(pdfDocumentPtr);
    }

    public void Dispose()
    {
        PdfiumWrapper.FPDF_DestroyLibrary();
    }
}