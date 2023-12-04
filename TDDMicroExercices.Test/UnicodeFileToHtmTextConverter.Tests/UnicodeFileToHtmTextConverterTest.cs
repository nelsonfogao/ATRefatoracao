namespace TDDMicroExercises.UnicodeFileToHtmTextConverter
{
    using System;
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnicodeFileToHtmTextConverterTest
    {

        [TestMethod]
        public void WhenInitializedThenInstanceSetedUp()
        {
            var converter = new UnicodeFileToHtmTextConverter("../../Data/UnicodeToHtml.txt");

            Assert.IsNotNull(converter);
        }

        [TestMethod]
        public void WhenFileConvertedThenHtmlIsOk()
        {
            var converter = new UnicodeFileToHtmTextConverter("../../Data/UnicodeToHtml.txt");

            var html = converter.ConvertToHtml();
            
            Assert.AreEqual("This is a sample<br />unicode file<br />With &#233; &#224; &amp;<br />", html);
        }

        [TestMethod]
        public void WhenInvalidFileThenThrowException()
        {
            var converter = new UnicodeFileToHtmTextConverter("../../Data/UnexistingFile.txt");
            var exceptionRaised = false;
            try
            {
                var html = converter.ConvertToHtml();
            }
            catch (FileNotFoundException ex)
            {
                exceptionRaised = true;
            }

            Assert.IsTrue(exceptionRaised);
        }
    }
}
