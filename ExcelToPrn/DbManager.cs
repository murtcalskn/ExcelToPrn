using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrm
{
    class DbManager
    {
        OleDbConnection conn;
        OleDbCommand cmd;

        public OleDbCommand DataCommand
        {
            get { return cmd; }
            set { cmd = value; }
        }
        OleDbDataAdapter adp;
        DataTable dt;

        static string connStr = Sessions.ConnStr;

        public DbManager()
        {
            conn = new OleDbConnection(connStr);
            conn.Open();
            cmd = new OleDbCommand();
            cmd.Connection = conn;
            adp = new OleDbDataAdapter();
            adp.SelectCommand = cmd;
        }

        public int KomutCalistir(string sql)
        {
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public DataTable GetDataTable(string sql)
        {
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
