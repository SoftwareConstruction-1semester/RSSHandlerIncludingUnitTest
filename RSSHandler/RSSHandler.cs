using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RSSHandler
{
    public class RssHandler
    {
        /// <summary>
        /// Load RSS feed into a xdocument
        /// </summary>
        /// <param name="rssFeed">a valid url to a rss feed</param>
        /// <returns></returns>
        public static XDocument LoadRSS(String rssFeed)
        {
            return XDocument.Load(rssFeed);
        }

        /// <summary>
        /// retrieves all titles from a valid rss feed
        /// </summary>
        /// <param name="RssFeed">a rssfeed in xdocument</param>
        /// <returns></returns>
        public static List<String> RetrieveTitles(XDocument RssFeed)
        {
            List<String> titles = new List<string>();
            IEnumerable <XElement> items = RssFeed.Descendants("item");
            foreach (XElement item in items)
            {
                titles.Add(item.Element("title").Value);
            }
            return titles;

        } 

        public static String LatestArticle()
        {
            return "";
        }
        //

    }
}
