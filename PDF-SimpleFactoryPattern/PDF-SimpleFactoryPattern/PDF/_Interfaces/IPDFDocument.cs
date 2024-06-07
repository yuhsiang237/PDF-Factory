namespace PDF_SimpleFactoryPattern.PDF
{
    /// <summary>
    /// IPDFDocument 該介面擔任抽象產品
    /// </summary>
    public interface IPDFDocument
    {
        /// <summary>
        /// PDF Generate
        /// </summary>
        /// <param name="PDFParameters">PDF params</param>
        /// <returns></returns>
        public PDFFile Generate(PDFParameters PDFParameters);
    }
}
