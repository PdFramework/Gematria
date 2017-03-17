namespace PeinearyDevelopment.Libraries.Hebrew.GematriaGematriaUnitTests
{
    using System.Linq;
    using System.Net;
    using HtmlAgilityPack;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PeinearyDevelopment.Libraries.Hebrew.Gematria;

    [TestClass]
    public class AlefBeisExchangerUnitTests
    {
        [TestMethod]
        public void GematriaTest_null()
        {
            var hg = new AlefBeisExchanger();
            var gematria = hg.CalculateGematria(null);

            Assert.AreEqual(gematria, 0);
        }

        [TestMethod]
        public void GematriaTest_Hebrew()
        {
            const string פסוק = "אין עוד מלבדו";
            var hg = new AlefBeisExchanger();
            var gematria = hg.CalculateGematria(פסוק);

            const int actual = 1 + 10 + 50 + 70 + 6 + 4 + 40 + 30 + 2 + 4 + 6;
            Assert.AreEqual(gematria, actual);
        }

        [TestMethod]
        public void GematriaTest_English()
        {
            const string words = "There is no other";
            var hg = new AlefBeisExchanger();
            var gematria = hg.CalculateGematria(words);

            Assert.AreEqual(gematria, 0);
        }

        [TestMethod]
        public void GematriaTest_HebrewWithNekudos()
        {
            const string פסוק = "אֶחָד";
            var hg = new AlefBeisExchanger();
            var gematria = hg.CalculateGematria(פסוק);

            const int actual = 1 + 8 + 4;
            Assert.AreEqual(gematria, actual);
        }

        [TestMethod]
        public void AtBashTest_null()
        {
            var hg = new AlefBeisExchanger();
            var atBash = hg.ConvertAtBash(null);

            Assert.AreEqual(atBash, string.Empty);
        }

        [TestMethod]
        public void AtBashTest_Hebrew()
        {
            const string פסוק = "אין עוד מלבדו";
            var hg = new AlefBeisExchanger();
            var atBash = hg.ConvertAtBash(hg.ConvertAtBash(פסוק));

            Assert.AreEqual(atBash, פסוק);
        }

        [TestMethod]
        public void AtBashTest_HebrewWithNekudos()
        {
            const string פסוק = "אֶחָד";
            var hg = new AlefBeisExchanger();
            var atBash = hg.ConvertAtBash(hg.ConvertAtBash(פסוק));

            Assert.AreEqual(atBash, פסוק);
        }

        [TestMethod]
        public void AtBashTest_English()
        {
            const string words = "There is no other";
            var hg = new AlefBeisExchanger();
            var atBash = hg.ConvertAtBash(words);

            Assert.AreEqual(atBash, words);
        }

        [TestMethod]
        public void TestOther()
        {
            var htmlDoc = new HtmlDocument();
            using (var myWebClient = new WebClient())
            {
                myWebClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:16.0) Gecko/20100101 Firefox/16.0");

                htmlDoc.Load(myWebClient.OpenRead("http://kodesh.snunit.k12.il/i/tm/t0101.htm"));
            }

            var node = htmlDoc.DocumentNode;
            var html = node.Element("html");
            var body = html.Element("body");
            var table = body.Element("table");
            var trs = table.Elements("tr").ToArray();
            var td = trs[1].Element("td");
        }
    }
}
