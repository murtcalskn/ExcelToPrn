using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace TestFrm
{
    class DataAccess
    {
        public static DataTable TumBorclulariGetir()
        {
            string sql = "Select * from Tablo1 ";
            DbManager dbManager = new DbManager();
            return dbManager.GetDataTable(sql);
        }
    }
}
