using System;
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
            return new List<string>();
        }

        public static String LatestArticle()
        {
            return "";
        }


    }
}
