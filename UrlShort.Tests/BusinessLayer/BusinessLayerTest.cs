using BusinessLayer;
using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UrlShort.Tests.BusinessLayer
{
    [TestClass]
    public class BusinessLayerTest
    {
        [TestMethod]
        public void UrlShorten()
        {
            // arrange
            var handler = new UrlHandler();
            var referrer = "https://www.google.com/";

            // act
            var url = handler.GetShortUrl(new ShortContext(), referrer);

            // arrange
            Assert.IsNotNull(url.Segment);
        }

        [TestMethod]
        public void NewSegment()
        {
            var context = new ShortContext();
            var generator = new Generator(context);

            var segment = generator.NewSegment();

            Assert.IsNotNull(segment);
        }
    }
}