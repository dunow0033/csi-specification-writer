namespace DocumentGenerator.Tests.PdfBuilder
{
    [TestFixture]
    public class GenerateTests
    {
        Service.Implementations.PdfBuilder _pdfBuilder;

        [SetUp]
        public void Setup()
        {
            _pdfBuilder = new Service.Implementations.PdfBuilder();
        }

        [Test]
        public void Generate_Document()
        {
            _pdfBuilder.Generate();
        }
    }
}

