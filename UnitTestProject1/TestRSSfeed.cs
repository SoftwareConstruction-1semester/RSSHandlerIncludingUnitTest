using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RSSHandler;

namespace UnitTestProject1
{
    [TestClass]
    public class TestRSSfeed
    {
        [TestMethod]
        public void TestLoadXML()
        {
            // test if the returning xdocument has a item tags?
            bool hasChannelTag = false;
            string fakeRSS = @"fakeRSSfeed.xml";
            XDocument xdoc = RssHandler.LoadRSS(fakeRSS);
            IEnumerable<XElement> items = xdoc.Descendants("item");
            Assert.IsTrue(items.FirstOrDefault() != null);

            // test if it has a channel tag
            IEnumerable<XElement> items = xdoc.Descendants("channel");
            Assert.IsTrue(items.FirstOrDefault() != null);

        }
    }
}
