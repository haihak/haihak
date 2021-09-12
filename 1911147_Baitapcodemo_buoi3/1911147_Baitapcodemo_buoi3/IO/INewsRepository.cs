using _1911147_Baitapcodemo_buoi3.MoDels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911147_Baitapcodemo_buoi3.IO
{
    public interface INewsRepository
    {
        List<Publisher> GetNew();
        void Save(List<Publisher> publishers);
    }
}
