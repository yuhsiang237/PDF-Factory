using PDF_SimpleFactoryPattern.PDF;

namespace PDF_SimpleFactoryPattern.Models
{
    public class ReqGeneratePDF
    {
        public PDFDocumentType PdfType { get; set; }
        public string? FileName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
