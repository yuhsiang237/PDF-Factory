using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace PDF_SimpleFactoryPattern.PDF
{
    public class DailyReportPDF : IPDFDocument
    {
        public PDFFile Generate(PDFParameters parameters)
        {
            var memoryBytes = new byte[] { };
            using (var memoryStream = new MemoryStream())
            {
                var pdfWriter = new PdfWriter(memoryStream);
                var pdfDocument = new PdfDocument(pdfWriter);
                var document = new Document(pdfDocument);

                document.Add(new Paragraph("Daily Report PDF DEMO")
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(20));

                document.Add(new Paragraph($"This is a test report.The start date is {parameters.StartDate.ToString("yyyy-MM-dd")}, and end date is {parameters.EndDate.ToString("yyyy-MM-dd")}")
                 .SetTextAlignment(TextAlignment.LEFT)
                 .SetFontSize(10));

                pdfDocument.Close();
                pdfWriter.Close();
                document.Close();

                memoryBytes = memoryStream.ToArray();
            }

            return new PDFFile
            {
                pdfBytes = memoryBytes,
            };
        }
    }
}
