using System;
using System.Collections.Generic;
using System.Text;

namespace test.baibao
{
    public class Publisher
    {
        public string Name { get; set; }
        public List<Category> Categories { get; set; }

        public Publisher()
        {
            Categories = new List<Category>();
        }
       /* public bool AddCategory(string name,string link, bool updateIfExisted)
        {
            var category = Categories.Find(x => x.Name == name);
            if(category == null)
            {
                category = new Category()
                {
                    Name = name,
                    RssLink = link
                };
                Categoryies.Add(category);
       return truel;
            }
        }*/
        
    }
}
