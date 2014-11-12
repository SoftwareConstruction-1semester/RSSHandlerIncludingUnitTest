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
            // test if the returning xdocument has a channel tag?

            bool hasChannelTag = false;

            string fakeRSS =
                @"c:\users\ebva.rhs\documents\visual studio 2013\Projects\RSSHandler\UnitTestProject1\fakeRSSfeed.xml";
            XDocument xdoc = RssHandler.LoadRSS(fakeRSS);

            IEnumerable<XElement> items = xdoc.Descendants("item");

            Assert.IsTrue(items.FirstOrDefault() != null);

        }
    }
}
