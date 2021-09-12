using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911147_Baitapcodemo_buoi3.MoDels
{
    public class Category
    {
        public string Name { get; set; }

        public string RssLink { get; set; }

        public List<Article> Articles { get; set; }
       
        public Category()
        {
            Articles = new List<Article>();
        }
    }
}
