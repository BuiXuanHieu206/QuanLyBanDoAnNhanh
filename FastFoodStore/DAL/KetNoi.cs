using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DAL
{
    public class KetNoi
    {
        public string kn = "Data Source=DESKTOP-12J6D6C;Initial Catalog=FastFoodStore;User ID=sa;Password=123;TrustServerCertificate=True";
        protected SqlConnection sqlConn = null;
        public void MoKetNoi()
        {
            sqlConn = new SqlConnection(kn);
            if (sqlConn.State != ConnectionState.Open)
            {
                sqlConn.Open();
            }
        }

        public void DongKetNoi()
        {
            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }
    }
}
