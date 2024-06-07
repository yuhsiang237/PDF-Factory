namespace PDF_SimpleFactoryPattern.PDF
{
    /// <summary>
    /// IPDFFactory 該介面擔任抽象工廠
    /// </summary>
    public interface IPDFFactory
    {
        /// <summary>
        /// 建立具體PDF產品
        /// </summary>
        /// <param name="type">報表類型類型</param>
        /// <returns></returns>
        public IPDFDocument CreatePDF(
            PDFDocumentType pdfType);
    }
}
