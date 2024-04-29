using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AquaGoDesktop.connections
{
    class connection
    {
        public static OleDbConnection conn;
        private static string dbconnect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\PYTHON FILES\\Projects\\AquaGoDesktop\\AquaGoDB.mdb";

        public static void DB()
        {
            try
            {
                conn = new OleDbConnection(dbconnect);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
