using System;
using System.Collections.Generic;
using System.Text;

namespace login
{
    public class danhsach
    {
        List<taikhoan> listtaikhoan;

        public List<taikhoan> Listtaikhoan 
        { get => listtaikhoan;
            set => listtaikhoan = value; 
        }
        danhsach()
        {
        }
    }
}
