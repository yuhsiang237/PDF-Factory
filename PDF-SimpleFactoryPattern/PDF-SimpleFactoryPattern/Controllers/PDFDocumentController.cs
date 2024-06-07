using Microsoft.AspNetCore.Mvc;
using PDF_SimpleFactoryPattern.Models;
using PDF_SimpleFactoryPattern.PDF;

namespace PDF_SimpleFactoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PDFDocumentController : ControllerBase
    {
        private readonly IPDFFactory _pdfFactory;
        public PDFDocumentController(
            IPDFFactory pdfFactory)
        {
            _pdfFactory = pdfFactory;
        }

        [HttpPost("GeneratePDF")]
        public IActionResult GeneratePDF([FromBody] ReqGeneratePDF req)
        {
            var pdfFile = _pdfFactory.CreatePDF(req.PdfType);
            var pdfDoc = default(PDFFile);

            switch (req.PdfType)
            {
                case PDFDocumentType.DailyReportPDF:
                    pdfDoc = pdfFile.Generate(new PDFParameters
                    {
                        StartDate = req.StartDate,
                        EndDate = req.EndDate,
                    });
                    break;
                case PDFDocumentType.WeeklyReportPDF:
                    pdfDoc = pdfFile.Generate(new PDFParameters
                    {
                        StartDate = req.StartDate,
                        EndDate = req.EndDate,
                    });
                    break;
                case PDFDocumentType.MonthlyReportPDF:
                    pdfDoc = pdfFile.Generate(new PDFParameters
                    {
                        StartDate = req.StartDate,
                        EndDate = req.EndDate,
                    });
                    break;
            }

            return File(pdfDoc?.pdfBytes ?? new byte[] {}, 
                "application/pdf", 
                req.FileName);
        }
    }
}