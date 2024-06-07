using PDF_SimpleFactoryPattern.PDF;
using Xunit;

namespace PDF_SimpleFactoryPatternTest.PDF
{
    public class PDFFactoryTest
    {
        [Theory]
        [InlineData(PDFDocumentType.DailyReportPDF)]
        [InlineData(PDFDocumentType.WeeklyReportPDF)]
        [InlineData(PDFDocumentType.MonthlyReportPDF)]
        public static void CreatePDF(PDFDocumentType type)
        {
           var factory = new PDFFactory();
           var pdf = factory.CreatePDF(type);
           Assert.NotNull(pdf);
        }
    }
}