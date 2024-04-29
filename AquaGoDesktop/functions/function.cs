using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AquaGoDesktop.functions
{
    class function
    {
        public static frmStart frmStart = null;
        public static frmUserMain frmUserMain = null;
        public static frmUserNewRefill frmUserNewRefill = null;
        public static frmUserNewOrder frmUserNewOrder = null;
        public static frmUserEditAccount frmUserEditAccount = null;
        public static frmAdminMain frmAdminMain = null;

        public static int currentCustID = 0;
        public static string currentUsername = "";
        public static string currentCustFName = "";
        public static string currentCustMName = "";
        public static string currentCustLName = "";
        public static string currentCustFullName = "";
        public static string currentCustAddress = "";
        public static string currentCustContactNum = "";
        public static string currentCustEmail = "";
        public static string currentAccRole = "";

        public static void dataGridFill(string s, DataGridView dgv)
        {
            try
            {
                connections.connection.DB();
                OleDbCommand command = new OleDbCommand(s, connections.connection.conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv.DataSource = table;
                connections.connection.conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
