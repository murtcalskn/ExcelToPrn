using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrm
{
    class DbManager2
    {
        SqlConnection conn2;
        SqlCommand cmd2;

        public SqlCommand DataCommand2
        {
            get { return cmd2; }
            set { cmd2 = value; }
        }

        SqlDataAdapter adp2;
        DataTable dt2 = new DataTable();

        static string connStr2 = Sessions2.ConnStr2;

        public DbManager2()
        {
            conn2 = new SqlConnection(connStr2);
            conn2.Open();
            cmd2 = new SqlCommand();
            cmd2.Connection = conn2;
            adp2 = new SqlDataAdapter();
            adp2.SelectCommand = cmd2;
        }

        public int KomutCalistir(string sql)
        {
            cmd2.CommandText = sql;
            return cmd2.ExecuteNonQuery();
        }

        public DataTable GetDataTable2(string sql)
        {
            cmd2.CommandText = sql;
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);
            return dt2;
        }

    }
}
