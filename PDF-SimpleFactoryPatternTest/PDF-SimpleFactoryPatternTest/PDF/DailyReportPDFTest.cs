using PDF_SimpleFactoryPattern.PDF;
using Xunit;

namespace PDF_SimpleFactoryPatternTest.PDF
{
    public class DailyReportPDFTest
    {
        [Fact]
        public static void Generate()
        {
            var factory = new PDFFactory();
            var pdf = factory.CreatePDF(PDFDocumentType.DailyReportPDF);
            var file = pdf.Generate(new PDFParameters
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
            });

            Assert.NotNull(file);
            Assert.NotEqual(file.pdfBytes, new byte[] { });
        }
    }
}