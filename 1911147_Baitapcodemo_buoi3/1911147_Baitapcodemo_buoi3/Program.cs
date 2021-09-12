using _1911147_Baitapcodemo_buoi3.IO;
using _1911147_Baitapcodemo_buoi3.RssFeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911147_Baitapcodemo_buoi3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            INewsRepository repository = new NewsRepository();
            NewsParser parser = new NewsParser();
            RssReader reader = new RssReader(parser);
            var manager = new NewsFeedManager(repository,reader);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(manager));
        }

        private static void RssReader(NewsParser parser)
        {
            throw new NotImplementedException();
        }
    }
}
