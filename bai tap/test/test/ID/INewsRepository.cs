using System;
using System.Collections.Generic;
using System.Text;

namespace test.ID
{
    public interface INewsRepository
    {
        List<Publisher> GetNews();

        void Save (List<Publisher> publishers)
        {

        }
    }
}
