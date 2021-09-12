using System;
using System.Collections.Generic;
using System.Text;

namespace test.ID
{
    interface NewRepository :INewsRepository        
    {
        List<> GetNews();

        void Save(List<Publisher> publishers)
        {

        }
    }
}
