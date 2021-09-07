using System;
using System.Collections.Generic;
using System.Text;

namespace lam_lai_vi_du_co_demo
{
    public class DaringTable
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
        public int Status { get; set; }
        public int Floor { get; set; }
        public DaringTable()
        {

        }
        public DaringTable(int tableId, string tableName,int status,int floor)
        {
            TableId = tableId;
            TableName = tableName;
            Status = 0;
            Floor = floor;
        }
    }
}
