using PDF_SimpleFactoryPattern.PDF;
using Xunit;

namespace PDF_SimpleFactoryPatternTest.PDF
{
    public class WeeklyReportPDFTest
    {
        [Fact]
        public static void Generate()
        {
            var factory = new PDFFactory();
            var pdf = factory.CreatePDF(PDFDocumentType.WeeklyReportPDF);
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