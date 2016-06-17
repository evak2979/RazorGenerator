using ASP;
using HtmlAgilityPack;
using NUnit.Framework;
using PreCompiledLibrary.Models;
using RazorGenerator.Testing;

namespace RazorGeneratorTests
{
    [TestFixture]
    public class UnitTest1
    {
        private _Views_Home_Index_cshtml index;

        [SetUp]
        public void Setup()
        {
            index = new _Views_Home_Index_cshtml();
        }

        [Test]
        public void TestMethod1()
        {
            //given
            HtmlDocument doc = index.RenderAsHtml(new TestModel() {IsTrue = true});
            HtmlNode node = doc.GetElementbyId("mainBody");

            //then
            Assert.IsNotNull(node);
        }

        [Test]
        public void TestMethod2()
        {
            //given
            HtmlDocument doc = index.RenderAsHtml(new TestModel() { IsTrue = false });
            HtmlNode node = doc.GetElementbyId("mainBody");

            //then
            Assert.IsNull(node);
        }
    }
}
