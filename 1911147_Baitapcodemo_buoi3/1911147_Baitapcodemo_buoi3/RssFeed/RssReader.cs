using _1911147_Baitapcodemo_buoi3.MoDels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _1911147_Baitapcodemo_buoi3.RssFeed
{
    public class RssReader
    {
        private readonly NewsParser _parser;

        public RssReader(NewsParser parser)
        {
            _parser = parser;
        }
        public List<Article> GetNews(string rssLink)
        {
            var feedData = DownLoadFeed(rssLink);
            return _parser.ParseXml(feedData);
        }
        private string DownLoadFeed(string rssLink)
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8
            };
            return client.DownloadString(rssLink);
        }
    }
}
