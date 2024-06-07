namespace PDF_SimpleFactoryPattern.PDF
{
    public class PDFFactory : IPDFFactory
    {
        public IPDFDocument CreatePDF(
            PDFDocumentType pdfType)
        {
            switch (pdfType)
            {
                case PDFDocumentType.DailyReportPDF:
                    return new DailyReportPDF();
                case PDFDocumentType.WeeklyReportPDF:
                    return new WeeklyReportPDF();
                case PDFDocumentType.MonthlyReportPDF:
                    return new MonthlyReportPDF();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
