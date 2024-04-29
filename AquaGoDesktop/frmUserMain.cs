using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AquaGoDesktop
{
    public partial class frmUserMain : Form
    {
        public frmUserMain()
        {
            InitializeComponent();
        }

        private void clearRefillDetails()
        {
            lblRefillIDValue.Text = "";
            lblRefillDateValue.Text = "";
            lblRefillStationValue.Text = "";
            lblRefillQuantityValue.Text = "";
            lblRefillPriceValue.Text = "";
            lblRefillTotalValue.Text = "";
            lblRefillPaymentValue.Text = "";
            lblRefillStatusValue.Text = "";
            lblRefillAddressValue.Text = "";

        }

        private void clearOrderDetails()
        {
            lblOrderIDValue.Text = "";
            lblOrderDateValue.Text = "";
            lblOrderProductValue.Text = "";
            lblOrderQuantityValue.Text = "";
            lblOrderPriceValue.Text = "";
            lblOrderTotalValue.Text = "";
            lblOrderPaymentValue.Text = "";
            lblOrderStatusValue.Text = "";
            lblOrderAddressValue.Text = "";
        }

        public void loadUserRefillDataGrid()
        {
            string s_refill = "Select [RefillID], [RefillDate], [StationID], [RefillQty], [RefillPrice], [RefillTotal], [RefillPayment], [RefillStatus], [RefillAddress] from Refills where [CustID] = " + functions.function.currentCustID + " and [RefillStatus] <> 'Canceled'";
            functions.function.dataGridFill(s_refill, dgvUserRefill);
            dgvUserRefill.Columns[4].DefaultCellStyle.Format = "c2";
            dgvUserRefill.Columns[5].DefaultCellStyle.Format = "c2";

            btnUserCancelRefill.Enabled = false;
            btnUserRefillContact.Enabled = false;
        }

        public void loadUserOrderDataGrid()
        {
            string s_order = "Select [OrderID], [OrderDate], [ProductID], [OrderQty], [OrderPrice], [OrderTotal], [OrderPayment], [OrderStatus], [OrderAddress] from Orders where [CustID] = " + functions.function.currentCustID + " and [OrderStatus] <> 'Canceled'";
            functions.function.dataGridFill(s_order, dgvUserOrders);
            dgvUserOrders.Columns[4].DefaultCellStyle.Format = "c2";
            dgvUserOrders.Columns[5].DefaultCellStyle.Format = "c2";

            btnUserCancelOrder.Enabled = false;
        }

        private void frmUserMain_Load(object sender, EventArgs e)
        {
            clearRefillDetails();
            clearOrderDetails();

            lblActiveUsername.Text = functions.function.currentCustFName;

            loadUserRefillDataGrid();
            loadUserOrderDataGrid();
        }

        private void dgvUserRefill_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvUserRefill.Rows[e.RowIndex];
                    
                    lblRefillIDValue.Text = row.Cells[0].Value.ToString();
                    lblRefillDateValue.Text = row.Cells[1].Value.ToString();
                    lblRefillStationValue.Text = getStationName(Int32.Parse(row.Cells[2].Value.ToString()));
                    lblRefillQuantityValue.Text = row.Cells[3].Value.ToString();
                    lblRefillPriceValue.Text = "Php " + string.Format("{0:F2}", row.Cells[4].Value);
                    lblRefillTotalValue.Text = "Php " + string.Format("{0:F2}", row.Cells[5].Value);
                    lblRefillPaymentValue.Text = row.Cells[6].Value.ToString();
                    lblRefillStatusValue.Text = row.Cells[7].Value.ToString();
                    lblRefillAddressValue.Text = row.Cells[8].Value.ToString();

                    if(lblRefillStatusValue.Text == "Request Submitted")
                    {
                        btnUserCancelRefill.Enabled = true;
                    }
                    else
                    {
                        btnUserCancelRefill.Enabled = false;
                    }

                    btnUserRefillContact.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUserOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvUserOrders.Rows[e.RowIndex];

                    lblOrderIDValue.Text = row.Cells[0].Value.ToString();
                    lblOrderDateValue.Text = row.Cells[1].Value.ToString();
                    lblOrderProductValue.Text = getProductName(Int32.Parse(row.Cells[2].Value.ToString()));
                    lblOrderQuantityValue.Text = row.Cells[3].Value.ToString();
                    lblOrderPriceValue.Text = "Php " + string.Format("{0:F2}", row.Cells[4].Value);
                    lblOrderTotalValue.Text = "Php " + string.Format("{0:F2}", row.Cells[5].Value);
                    lblOrderPaymentValue.Text = row.Cells[6].Value.ToString();
                    lblOrderStatusValue.Text = row.Cells[7].Value.ToString();
                    lblOrderAddressValue.Text = row.Cells[8].Value.ToString();

                    if (lblOrderStatusValue.Text == "Order Submitted")
                    {
                        btnUserCancelOrder.Enabled = true;
                    }
                    else
                    {
                        btnUserCancelOrder.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUserLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            functions.function.frmStart.Show();
        }

        private void txtUserRefillSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtUserRefillSearch.Text == "")
            {
                loadUserRefillDataGrid();
                clearRefillDetails();
            }
            else if(txtUserRefillSearch.Text != "")
            {
                int searchRefillID = 0;
                int searchStationID = 0;
                string searchStation = "";

                try
                {
                    searchRefillID = Int32.Parse(txtUserRefillSearch.Text);
                }
                catch (Exception ex)
                {
                    string exKeeper = ex.ToString();
                    searchStation = txtUserRefillSearch.Text;
                    searchStationID = getStationID(searchStation);
                }

                try
                {
                    connections.connection.DB();
                    string s_refill = "Select [RefillID], [RefillDate], [StationID], [RefillQty], [RefillPrice], [RefillTotal], [RefillPayment], [RefillStatus], [RefillAddress] from Refills where [CustID] = " + functions.function.currentCustID + " and ([RefillID] = " + searchRefillID + " or [StationID] = " + searchStationID + ") and [RefillStatus] <> 'Canceled'";
                    functions.function.dataGridFill(s_refill, dgvUserRefill);
                    dgvUserRefill.Columns[4].DefaultCellStyle.Format = "c2";
                    dgvUserRefill.Columns[5].DefaultCellStyle.Format = "c2";

                    btnUserCancelRefill.Enabled = false;
                    btnUserRefillContact.Enabled = false;
                    clearRefillDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int getStationID(string station)
        {
            int stationID = 0;

            try
            {
                connections.connection.DB();
                string s_refill = "Select [StationID] from Stations where [StationName] like '%" + station + "%'";
                OleDbCommand command = new OleDbCommand(s_refill, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                if(datareader.Read())
                {
                    stationID = datareader.GetInt32(0);
                }

                connections.connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return stationID;
        }

        private string getStationName(int stationID)
        {
            string stationName = "";

            try
            {
                connections.connection.DB();
                string s_refill = "Select [StationName] from Stations where [StationID] = " + stationID;
                OleDbCommand command = new OleDbCommand(s_refill, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                if (datareader.Read())
                {
                    stationName = datareader.GetString(0);
                }

                connections.connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return stationName;
        }

        private void txtUserOrderSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtUserOrderSearch.Text == "")
            {
                loadUserOrderDataGrid();
                clearOrderDetails();
            }
            else if(txtUserOrderSearch.Text != "")
            {
                int searchOrderID = 0;
                int searchProductID = 0;
                string searchProduct = "";

                try
                {
                    searchOrderID = Int32.Parse(txtUserOrderSearch.Text);
                }
                catch (Exception ex)
                {
                    string exKeeper = ex.ToString();
                    searchProduct = txtUserOrderSearch.Text;
                    searchProductID = getProductID(searchProduct);
                }

                try
                {
                    connections.connection.DB();
                    string s_order = "Select [OrderID], [OrderDate], [ProductID], [OrderQty], [OrderPrice], [OrderTotal], [OrderPayment], [OrderStatus], [OrderAddress] from Orders where [CustID] = " + functions.function.currentCustID + " and ([OrderID] = " + searchOrderID + " or [ProductID] = " + searchProductID + ") and [OrderStatus] <> 'Canceled'";
                    functions.function.dataGridFill(s_order, dgvUserOrders);
                    dgvUserOrders.Columns[4].DefaultCellStyle.Format = "c2";
                    dgvUserOrders.Columns[5].DefaultCellStyle.Format = "c2";

                    btnUserCancelOrder.Enabled = false;
                    clearOrderDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int getProductID(string product)
        {
            int productID = 0;

            try
            {
                connections.connection.DB();
                string s_order = "Select [ProductID] from Products where [ProductName] like '%" + product + "%'";
                OleDbCommand command = new OleDbCommand(s_order, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                if (datareader.Read())
                {
                    productID = datareader.GetInt32(0);
                }

                connections.connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return productID;
        }

        private string getProductName(int productID)
        {
            string productName = "";

            try
            {
                connections.connection.DB();
                string s_order = "Select [ProductName] from Products where [ProductID] = " + productID;
                OleDbCommand command = new OleDbCommand(s_order, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                if (datareader.Read())
                {
                    productName = datareader.GetString(0);
                }

                connections.connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return productName;
        }

        private void btnUserNewRefill_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            functions.function.frmUserNewRefill = new frmUserNewRefill();
            functions.function.frmUserNewRefill.Show();
        }

        private void btnUserCancelRefill_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel this refill request?", "Cancel Refill", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                try
                {
                    connections.connection.DB();
                    string s_refill = "Update Refills set [RefillStatus] = 'Canceled' where [RefillID] = " + lblRefillIDValue.Text;
                    OleDbCommand command = new OleDbCommand(s_refill, connections.connection.conn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Refill Request canceled.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connections.connection.conn.Close();

                    loadUserRefillDataGrid();
                    clearRefillDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUserRefillContact_Click(object sender, EventArgs e)
        {
            int stationID = Int32.Parse(dgvUserRefill.CurrentRow.Cells[2].Value.ToString());

            try
            {
                connections.connection.DB();
                string s_refill = "Select * from Stations where [StationID] = " + stationID;
                OleDbCommand command = new OleDbCommand(s_refill, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                if (datareader.Read())
                {
                    string stationName = datareader.GetString(1);
                    string stationAddress = datareader.GetString(2);
                    string stationContact = datareader.GetString(3);

                    MessageBox.Show("Name: " + stationName + "\nAddress: " + stationAddress + "\nContact No.: " + stationContact, "Station Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                connections.connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUserNewOrder_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            functions.function.frmUserNewOrder = new frmUserNewOrder();
            functions.function.frmUserNewOrder.Show();
        }

        private void btnUserCancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    connections.connection.DB();
                    string s_order = "Update Orders set [OrderStatus] = 'Canceled' where [OrderID] = " + lblOrderIDValue.Text;
                    OleDbCommand command = new OleDbCommand(s_order, connections.connection.conn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Order canceled.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connections.connection.conn.Close();

                    loadUserOrderDataGrid();
                    clearOrderDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUserEditAccount_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            functions.function.frmUserEditAccount = new frmUserEditAccount();
            functions.function.frmUserEditAccount.Show();
        }
    }
}
