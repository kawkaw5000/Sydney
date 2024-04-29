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
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }

        private void clearRefillDetails()
        {
            lblRefillIDValue.Text = "";
            lblRefillDateValue.Text = "";
            lblRefillStationValue.Text = "";
            lblRefillPriceValue.Text = "";
            lblRefillTotalValue.Text = "";
            lblRefillPaymentValue.Text = "";
            cmbRefillStatusValue.SelectedIndex = 0;
            txtRefillAddressValue.Text = "";
        }

        private void clearOrderDetails()
        {
            lblOrderIDValue.Text = "";
            lblOrderDateValue.Text = "";
            lblOrderProductValue.Text = "";
            lblOrderPriceValue.Text = "";
            lblOrderTotalValue.Text = "";
            lblOrderPaymentValue.Text = "";
            cmbOrderStatusValue.SelectedIndex = 0;
            txtOrderAddressValue.Text = "";
        }

        private void clearStationInfo()
        {
            txtStationNameValue.Text = "";
            txtStationAddressValue.Text = "";
            txtStationContactNumValue.Text = "";
            numStationRefillPriceValue.Value = 0;
        }

        private void clearProductInfo()
        {
            txtProductNameValue.Text = "";
            txtProductDescValue.Text = "";
            numProductPriceValue.Value = 0;
            numProductStockValue.Value = 0;
        }

        private void clearAccountInfo()
        {
            txtUsernameValue.Text = "";
            txtPasswordValue.Text = "";
            cmbAccountRoleValue.SelectedIndex = 0;
            txtFirstNameValue.Text = "";
            txtMiddleNameValue.Text = "";
            txtLastNameValue.Text = "";
            txtHomeAddressValue.Text = "";
            txtContactNumValue.Text = "";
            txtEmailValue.Text = "";
        }

        public void loadAdminRefillDataGrid()
        {
            string s_refill = "Select * from Refills";
            functions.function.dataGridFill(s_refill, dgvAdminRefill);
            dgvAdminRefill.Columns[5].DefaultCellStyle.Format = "c2";
            dgvAdminRefill.Columns[6].DefaultCellStyle.Format = "c2";

            disableRefillControls();
        }

        public void loadAdminOrderDataGrid()
        {
            string s_order = "Select * from Orders";
            functions.function.dataGridFill(s_order, dgvAdminOrders);
            dgvAdminOrders.Columns[5].DefaultCellStyle.Format = "c2";
            dgvAdminOrders.Columns[6].DefaultCellStyle.Format = "c2";

            disableOrderControls();
        }

        public void loadAdminStationDataGrid()
        {
            string s_station = "Select * from Stations order by [StationID] asc";
            functions.function.dataGridFill(s_station, dgvAdminStations);
            dgvAdminStations.Columns[4].DefaultCellStyle.Format = "c2";

            disableStationControls();
        }

        public void loadAdminProductDataGrid()
        {
            string s_product = "Select * from Products order by [ProductID] asc";
            functions.function.dataGridFill(s_product, dgvAdminProducts);
            dgvAdminProducts.Columns[3].DefaultCellStyle.Format = "c2";

            disableProductControls();
        }

        public void loadAdminAccountDataGrid()
        {
            string s_account = "Select * from Accounts where [Username] <> 'admin' order by [CustID] asc";
            functions.function.dataGridFill(s_account, dgvAdminAccounts);

            disableAccountControls();
        }

        private void enableRefillControls()
        {
            numRefillQtyValue.Enabled = true;
            cmbRefillStatusValue.Enabled = true;
            txtRefillAddressValue.Enabled = true;
            btnAdminRefillUpdate.Enabled = true;
            btnAdminRefillDelete.Enabled = true;
        }

        private void enableOrderControls()
        {
            numOrderQtyValue.Enabled = true;
            cmbOrderStatusValue.Enabled = true;
            txtOrderAddressValue.Enabled = true;
            btnAdminOrderUpdate.Enabled = true;
            btnAdminOrderDelete.Enabled = true;
        }

        private void enableStationControls()
        {
            btnAdminStationUpdate.Enabled = true;
            btnAdminStationDelete.Enabled = true;
        }

        private void enableProductControls()
        {
            btnAdminProductUpdate.Enabled = true;
            btnAdminProductDelete.Enabled = true;
        }

        private void enableAccountControls()
        {
            btnAdminAccountUpdate.Enabled = true;
            btnAdminAccountDelete.Enabled = true;
        }

        private void disableRefillControls()
        {
            numRefillQtyValue.Enabled = false;
            cmbRefillStatusValue.SelectedIndex = 0;
            cmbRefillStatusValue.Enabled = false;
            txtRefillAddressValue.Enabled = false;
            btnAdminRefillUpdate.Enabled = false;
            btnAdminRefillDelete.Enabled = false;
        }

        private void disableOrderControls()
        {
            numOrderQtyValue.Enabled = false;
            cmbOrderStatusValue.SelectedIndex = 0;
            cmbOrderStatusValue.Enabled = false;
            txtOrderAddressValue.Enabled = false;
            btnAdminOrderUpdate.Enabled = false;
            btnAdminOrderDelete.Enabled = false;
        }

        private void disableStationControls()
        {
            btnAdminStationUpdate.Enabled = false;
            btnAdminStationDelete.Enabled = false;
        }

        private void disableProductControls()
        {
            btnAdminProductUpdate.Enabled = false;
            btnAdminProductDelete.Enabled = false;
        }

        private void disableAccountControls()
        {
            btnAdminAccountUpdate.Enabled = false;
            btnAdminAccountDelete.Enabled = false;
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            clearRefillDetails();
            clearOrderDetails();

            lblActiveUsername.Text = functions.function.currentCustFName + " (Administrator)";

            loadAdminRefillDataGrid();
            loadAdminOrderDataGrid();
            loadAdminStationDataGrid();
            loadAdminProductDataGrid();
            loadAdminAccountDataGrid();
        }

        private void dgvAdminRefill_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvAdminRefill.Rows[e.RowIndex];

                    lblRefillIDValue.Text = row.Cells[0].Value.ToString();
                    lblRefillDateValue.Text = row.Cells[1].Value.ToString();
                    lblRefillCustomerNameValue.Text = getCustomerFullName(Int32.Parse(row.Cells[2].Value.ToString()));
                    lblRefillStationValue.Text = getStationName(Int32.Parse(row.Cells[3].Value.ToString()));
                    numRefillQtyValue.Value = Convert.ToDecimal(row.Cells[4].Value);
                    lblRefillPriceValue.Text = "Php " + string.Format("{0:F2}", row.Cells[5].Value);
                    lblRefillTotalValue.Text = "Php " + string.Format("{0:F2}", row.Cells[6].Value);
                    lblRefillPaymentValue.Text = row.Cells[7].Value.ToString();
                    cmbRefillStatusValue.SelectedItem = row.Cells[8].Value.ToString();
                    txtRefillAddressValue.Text = row.Cells[9].Value.ToString();

                    enableRefillControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAdminOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvAdminOrders.Rows[e.RowIndex];

                    lblOrderIDValue.Text = row.Cells[0].Value.ToString();
                    lblOrderDateValue.Text = row.Cells[1].Value.ToString();
                    lblOrderCustomerNameValue.Text = getCustomerFullName(Int32.Parse(row.Cells[2].Value.ToString()));
                    lblOrderProductValue.Text = getProductName(Int32.Parse(row.Cells[3].Value.ToString()));
                    numOrderQtyValue.Value = Convert.ToDecimal(row.Cells[4].Value);
                    lblOrderPriceValue.Text = "Php " + string.Format("{0:F2}", row.Cells[5].Value);
                    lblOrderTotalValue.Text = "Php " + string.Format("{0:F2}", row.Cells[6].Value);
                    lblOrderPaymentValue.Text = row.Cells[7].Value.ToString();
                    cmbOrderStatusValue.SelectedItem = row.Cells[8].Value.ToString();
                    txtOrderAddressValue.Text = row.Cells[9].Value.ToString();

                    enableOrderControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAdminStations_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvAdminStations.Rows[e.RowIndex];

                    txtStationNameValue.Text = row.Cells[1].Value.ToString();
                    txtStationAddressValue.Text = row.Cells[2].Value.ToString();
                    txtStationContactNumValue.Text = row.Cells[3].Value.ToString();
                    numStationRefillPriceValue.Value = Convert.ToDecimal(row.Cells[4].Value);

                    enableStationControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAdminProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvAdminProducts.Rows[e.RowIndex];

                    txtProductNameValue.Text = row.Cells[1].Value.ToString();
                    txtProductDescValue.Text = row.Cells[2].Value.ToString();
                    numProductPriceValue.Value = Convert.ToDecimal(row.Cells[3].Value);
                    numProductStockValue.Value = Convert.ToDecimal(row.Cells[4].Value);

                    enableProductControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAdminAccounts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvAdminAccounts.Rows[e.RowIndex];

                    txtUsernameValue.Text = row.Cells[1].Value.ToString();
                    txtPasswordValue.Text = row.Cells[2].Value.ToString();
                    txtFirstNameValue.Text = row.Cells[3].Value.ToString();
                    txtMiddleNameValue.Text = row.Cells[4].Value.ToString();
                    txtLastNameValue.Text = row.Cells[5].Value.ToString();
                    txtHomeAddressValue.Text = row.Cells[6].Value.ToString();
                    txtContactNumValue.Text = row.Cells[7].Value.ToString();
                    txtEmailValue.Text = row.Cells[8].Value.ToString();
                    cmbAccountRoleValue.SelectedItem = row.Cells[9].Value.ToString();

                    enableAccountControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string getCustomerFullName(int custID)
        {
            string custFullName = "";

            try
            {
                connections.connection.DB();
                string s_refill = "Select [CustFName], [CustMName], [CustLName] from Accounts where [CustID] = " + custID;
                OleDbCommand command = new OleDbCommand(s_refill, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                if (datareader.Read())
                {
                    string custMI = datareader.GetString(1);
                    custFullName = datareader.GetString(0) + " " + custMI[0] + ". " + datareader.GetString(2);
                }

                connections.connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return custFullName;
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

                if (datareader.Read())
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

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            functions.function.frmStart.Show();
        }

        private void txtAdminRefillSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtAdminRefillSearch.Text == "")
            {
                loadAdminRefillDataGrid();
                clearRefillDetails();
            }
            else if(txtAdminRefillSearch.Text != "")
            {
                int searchRefillID = 0;
                int searchStationID = 0;
                string searchStation = "";

                try
                {
                    searchRefillID = Int32.Parse(txtAdminRefillSearch.Text);
                }
                catch (Exception ex)
                {
                    string exKeeper = ex.ToString();
                    searchStation = txtAdminRefillSearch.Text;
                    searchStationID = getStationID(searchStation);
                }

                try
                {
                    connections.connection.DB();
                    string s_refill = "Select * from Refills where ([RefillID] = " + searchRefillID + " or [StationID] = " + searchStationID + ")";
                    functions.function.dataGridFill(s_refill, dgvAdminRefill);
                    dgvAdminRefill.Columns[5].DefaultCellStyle.Format = "c2";
                    dgvAdminRefill.Columns[6].DefaultCellStyle.Format = "c2";

                    disableRefillControls();
                    clearRefillDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtAdminOrderSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtAdminOrderSearch.Text == "")
            {
                loadAdminOrderDataGrid();
                clearOrderDetails();
            }
            else if (txtAdminOrderSearch.Text != "")
            {
                int searchOrderID = 0;
                int searchProductID = 0;
                string searchProduct = "";

                try
                {
                    searchOrderID = Int32.Parse(txtAdminOrderSearch.Text);
                }
                catch (Exception ex)
                {
                    string exKeeper = ex.ToString();
                    searchProduct = txtAdminOrderSearch.Text;
                    searchProductID = getProductID(searchProduct);
                }

                try
                {
                    connections.connection.DB();
                    string s_order = "Select * from Orders where ([OrderID] = " + searchOrderID + " or [ProductID] = " + searchProductID + ")";
                    functions.function.dataGridFill(s_order, dgvAdminOrders);
                    dgvAdminOrders.Columns[5].DefaultCellStyle.Format = "c2";
                    dgvAdminOrders.Columns[6].DefaultCellStyle.Format = "c2";

                    disableOrderControls();
                    clearOrderDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtAdminStationSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtAdminStationSearch.Text == "")
            {
                loadAdminStationDataGrid();
                clearStationInfo();
            }
            else if(txtAdminStationSearch.Text != "")
            {
                string searchStationName = txtAdminStationSearch.Text;

                try
                {
                    connections.connection.DB();
                    string s_station = "Select * from Stations where [StationName] like '%" + searchStationName + "%' order by [StationID] asc";
                    functions.function.dataGridFill(s_station, dgvAdminStations);
                    dgvAdminStations.Columns[4].DefaultCellStyle.Format = "c2";

                    disableStationControls();
                    clearStationInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtAdminProductSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtAdminProductSearch.Text == "")
            {
                loadAdminProductDataGrid();
                clearProductInfo();
            }
            else if (txtAdminProductSearch.Text != "")
            {
                string searchProductName = txtAdminProductSearch.Text;

                try
                {
                    connections.connection.DB();
                    string s_product = "Select * from Products where [ProductName] like '%" + searchProductName + "%' order by [ProductID] asc";
                    functions.function.dataGridFill(s_product, dgvAdminProducts);
                    dgvAdminProducts.Columns[3].DefaultCellStyle.Format = "c2";

                    disableProductControls();
                    clearProductInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtAdminAccountSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtAdminAccountSearch.Text == "")
            {
                loadAdminAccountDataGrid();
                clearAccountInfo();
            }
            else if(txtAdminAccountSearch.Text != "")
            {
                string searchUsername = txtAdminAccountSearch.Text;

                try
                {
                    connections.connection.DB();
                    string s_account = "Select * from Accounts where [Username] like '%" + searchUsername + "%' and [Username] <> 'admin' order by [CustID] asc";
                    functions.function.dataGridFill(s_account, dgvAdminAccounts);

                    disableAccountControls();
                    clearAccountInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void numRefillQtyValue_ValueChanged(object sender, EventArgs e)
        {
            decimal refillPrice = Convert.ToDecimal(dgvAdminRefill.CurrentRow.Cells[5].Value);
            int qty = Convert.ToInt32(numRefillQtyValue.Value);
            lblRefillTotalValue.Text = "Php " + string.Format("{0:F2}", getTotal(refillPrice, qty));
        }

        private void numOrderQtyValue_ValueChanged(object sender, EventArgs e)
        {
            decimal orderPrice = Convert.ToDecimal(dgvAdminOrders.CurrentRow.Cells[5].Value);
            int qty = Convert.ToInt32(numOrderQtyValue.Value);
            lblOrderTotalValue.Text = "Php " + string.Format("{0:F2}", getTotal(orderPrice, qty));
        }

        private decimal getTotal(decimal price, int qty)
        {
            decimal total = price * qty;

            return total;
        }

        private void btnAdminRefillUpdate_Click(object sender, EventArgs e)
        {
            if(refillAddressFieldCheck())
            {
                int refillID = Int32.Parse(lblRefillIDValue.Text);
                int newRefillQty = Convert.ToInt32(numRefillQtyValue.Value);
                decimal refillPrice = Convert.ToDecimal(dgvAdminRefill.CurrentRow.Cells[5].Value);
                decimal newRefillTotal = getTotal(refillPrice, newRefillQty);
                string newRefillStatus = cmbRefillStatusValue.SelectedItem.ToString();
                string newRefillAddress = txtRefillAddressValue.Text;

                try
                {
                    connections.connection.DB();
                    string s_refill = "Update Refills set [RefillQty] = " + newRefillQty + ", [RefillTotal] = " + newRefillTotal + ", [RefillStatus] = '" + newRefillStatus + "', [RefillAddress] = '" + newRefillAddress + "' where [RefillID] = " + refillID;
                    OleDbCommand command = new OleDbCommand(s_refill, connections.connection.conn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Refill Request updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connections.connection.conn.Close();

                    loadAdminRefillDataGrid();
                    clearRefillDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdminOrderUpdate_Click(object sender, EventArgs e)
        {
            if(orderAddressFieldCheck())
            {
                int orderID = Int32.Parse(lblOrderIDValue.Text);
                int newOrderQty = Convert.ToInt32(numOrderQtyValue.Value);
                decimal orderPrice = Convert.ToDecimal(dgvAdminOrders.CurrentRow.Cells[5].Value);
                decimal newOrderTotal = getTotal(orderPrice, newOrderQty);
                string newOrderStatus = cmbOrderStatusValue.SelectedItem.ToString();
                string newOrderAddress = txtOrderAddressValue.Text;

                try
                {
                    connections.connection.DB();
                    string s_order = "Update Orders set [OrderQty] = " + newOrderQty + ", [OrderTotal] = " + newOrderTotal + ", [OrderStatus] = '" + newOrderStatus + "', [OrderAddress] = '" + newOrderAddress + "' where [OrderID] = " + orderID;
                    OleDbCommand command = new OleDbCommand(s_order, connections.connection.conn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Order updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connections.connection.conn.Close();

                    loadAdminOrderDataGrid();
                    clearOrderDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool refillAddressFieldCheck()
        {
            bool valid = true;

            string address = txtRefillAddressValue.Text;

            if (address == "")
            {
                MessageBox.Show("Enter delivery address.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRefillAddressValue.Focus();
                valid = false;
            }

            return valid;
        }

        private bool orderAddressFieldCheck()
        {
            bool valid = true;

            string address = txtOrderAddressValue.Text;

            if (address == "")
            {
                MessageBox.Show("Enter delivery address.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtOrderAddressValue.Focus();
                valid = false;
            }

            return valid;
        }

        private void btnAdminRefillDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this refill request?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int refillID = Int32.Parse(lblRefillIDValue.Text);

                try
                {
                    connections.connection.DB();
                    string s_refill = "Delete from Refills where [RefillID] = " + refillID;
                    OleDbCommand command = new OleDbCommand(s_refill, connections.connection.conn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Refill request deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connections.connection.conn.Close();

                    loadAdminRefillDataGrid();
                    clearRefillDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdminOrderDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int orderID = Int32.Parse(lblRefillIDValue.Text);

                try
                {
                    connections.connection.DB();
                    string s_order = "Delete from Orders where [OrderID] = " + orderID;
                    OleDbCommand command = new OleDbCommand(s_order, connections.connection.conn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Order deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connections.connection.conn.Close();

                    loadAdminOrderDataGrid();
                    clearOrderDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdminStationClear_Click(object sender, EventArgs e)
        {
            clearStationInfo();
        }

        private void btnAdminStationAdd_Click(object sender, EventArgs e)
        {
            if(stationInfoFieldCheck())
            {
                string newStationName = txtStationNameValue.Text;
                string newStationAddress = txtStationAddressValue.Text;
                string newStationContactNum = txtStationContactNumValue.Text;
                decimal newStationRefillPrice = Convert.ToDecimal(numStationRefillPriceValue.Value);

                try
                {
                    connections.connection.DB();
                    string existingStation = "Select [StationName] from Stations where [StationName] = '" + newStationName + "'";
                    OleDbCommand command = new OleDbCommand(existingStation, connections.connection.conn);
                    OleDbDataReader datareader = command.ExecuteReader();

                    if(datareader.Read())
                    {
                        MessageBox.Show("Station name already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datareader.Close();
                        connections.connection.conn.Close();

                        txtStationNameValue.Text = "";
                        txtStationNameValue.Focus();
                    }
                    else
                    {
                        datareader.Close();
                        string s_station = "Insert into Stations([StationName], [StationAddress], [StationContactNum], [StationRefillPrice]) values ('" + newStationName + "', '" + newStationAddress + "', '" + newStationContactNum + "', " + newStationRefillPrice + ")";
                        command = new OleDbCommand(s_station, connections.connection.conn);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Station successfully added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connections.connection.conn.Close();

                        loadAdminStationDataGrid();
                        clearStationInfo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdminStationUpdate_Click(object sender, EventArgs e)
        {
            if(stationInfoFieldCheck())
            {
                int stationID = Convert.ToInt32(dgvAdminStations.CurrentRow.Cells[0].Value);
                string prevStationName = dgvAdminStations.CurrentRow.Cells[1].Value.ToString();
                string newStationName = txtStationNameValue.Text;
                string newStationAddress = txtStationAddressValue.Text;
                string newStationContactNum = txtStationContactNumValue.Text;
                decimal newStationRefillPrice = Convert.ToDecimal(numStationRefillPriceValue.Value);

                try
                {
                    connections.connection.DB();
                    string s_station = "";
                    OleDbCommand command;

                    if(newStationName != prevStationName)
                    {
                        s_station = "Select [StationName] from Stations where [StationName] = '" + newStationName + "'";
                        command = new OleDbCommand(s_station, connections.connection.conn);
                        OleDbDataReader datareader = command.ExecuteReader();

                        if (datareader.Read())
                        {
                            MessageBox.Show("Station name already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            datareader.Close();
                            connections.connection.conn.Close();

                            txtStationNameValue.Text = "";
                            txtStationNameValue.Focus();
                        }
                        else
                        {
                            datareader.Close();
                            s_station = "Update Stations set [StationName] = '" + newStationName + "', [StationAddress] = '" + newStationAddress + "', [StationContactNum] = '" + newStationContactNum + "', [StationRefillPrice] = " + newStationRefillPrice + " where [StationID] = " + stationID;
                            command = new OleDbCommand(s_station, connections.connection.conn);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Station successfully updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connections.connection.conn.Close();

                            loadAdminStationDataGrid();
                            clearStationInfo();
                        }
                    }
                    else if(newStationName == prevStationName)
                    {
                        s_station = "Update Stations set [StationName] = '" + newStationName + "', [StationAddress] = '" + newStationAddress + "', [StationContactNum] = '" + newStationContactNum + "', [StationRefillPrice] = " + newStationRefillPrice + " where [StationID] = " + stationID;
                        command = new OleDbCommand(s_station, connections.connection.conn);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Station successfully updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connections.connection.conn.Close();

                        loadAdminStationDataGrid();
                        clearStationInfo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdminStationDelete_Click(object sender, EventArgs e)
        {
            int stationID = Convert.ToInt32(dgvAdminStations.CurrentRow.Cells[0].Value);

            DialogResult dr = MessageBox.Show("All refill requests assigned to this station will also be deleted.\nDo you still want to delete this station?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    connections.connection.DB();
                    string s_refill = "Delete from Refills where [StationID] = " + stationID;
                    OleDbCommand command = new OleDbCommand(s_refill, connections.connection.conn);
                    command.ExecuteNonQuery();

                    string s_station = "Delete from Stations where [StationID] = " + stationID;
                    command = new OleDbCommand(s_station, connections.connection.conn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Station successfully deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connections.connection.conn.Close();

                    loadAdminRefillDataGrid();
                    clearRefillDetails();
                    loadAdminStationDataGrid();
                    clearStationInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool stationInfoFieldCheck()
        {
            bool valid = true;

            string stationName = txtStationNameValue.Text;
            string stationAddress = txtStationAddressValue.Text;
            string stationContactNum = txtStationContactNumValue.Text;
            decimal stationRefillPrice;

            try
            {
                stationRefillPrice = Convert.ToDecimal(numStationRefillPriceValue.Value);
            }
            catch (Exception ex)
            {
                string exKeeper = ex.ToString();
                stationRefillPrice = 0;
            }

            if (stationName == "")
            {
                MessageBox.Show("Enter station name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtStationNameValue.Focus();
                valid = false;
            }
            else if (stationAddress == "")
            {
                MessageBox.Show("Enter station address.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtStationAddressValue.Focus();
                valid = false;
            }
            else if (stationContactNum == "")
            {
                MessageBox.Show("Enter contact number.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtStationContactNumValue.Focus();
                valid = false;
            }
            else if (stationRefillPrice == 0)
            {
                MessageBox.Show("Enter refill price.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                numStationRefillPriceValue.Focus();
                valid = false;
            }

            return valid;
        }

        private void btnAdminProductClear_Click(object sender, EventArgs e)
        {
            clearProductInfo();
        }

        private void btnAdminProductAdd_Click(object sender, EventArgs e)
        {
            if(productInfoFieldCheck())
            {
                string newProductName = txtProductNameValue.Text;
                string newProductDesc = txtProductDescValue.Text;
                decimal newProductPrice = Convert.ToDecimal(numProductPriceValue.Value);
                int newProductStock = Convert.ToInt32(numProductStockValue.Value);

                try
                {
                    connections.connection.DB();
                    string existingProduct = "Select [ProductName] from Products where [ProductName] = '" + newProductName + "'";
                    OleDbCommand command = new OleDbCommand(existingProduct, connections.connection.conn);
                    OleDbDataReader datareader = command.ExecuteReader();

                    if (datareader.Read())
                    {
                        MessageBox.Show("Product name already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datareader.Close();
                        connections.connection.conn.Close();

                        txtProductNameValue.Text = "";
                        txtProductNameValue.Focus();
                    }
                    else
                    {
                        datareader.Close();
                        string s_product = "Insert into Products([ProductName], [ProductDesc], [ProductPrice], [ProductStock]) values ('" + newProductName + "', '" + newProductDesc + "', " + newProductPrice + ", " + newProductStock + ")";
                        command = new OleDbCommand(s_product, connections.connection.conn);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Product successfully added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connections.connection.conn.Close();

                        loadAdminProductDataGrid();
                        clearProductInfo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdminProductUpdate_Click(object sender, EventArgs e)
        {
            if (productInfoFieldCheck())
            {
                int productID = Convert.ToInt32(dgvAdminProducts.CurrentRow.Cells[0].Value);
                string prevProductName = dgvAdminProducts.CurrentRow.Cells[1].Value.ToString();
                string newProductName = txtProductNameValue.Text;
                string newProductDesc = txtProductDescValue.Text;
                decimal newProductPrice = Convert.ToDecimal(numProductPriceValue.Value);
                int newProductStock = Convert.ToInt32(numProductStockValue.Value);

                try
                {
                    connections.connection.DB();
                    string s_product = "";
                    OleDbCommand command;

                    if (newProductName != prevProductName)
                    {
                        s_product = "Select [ProductName] from Products where [ProductName] = '" + newProductName + "'";
                        command = new OleDbCommand(s_product, connections.connection.conn);
                        OleDbDataReader datareader = command.ExecuteReader();

                        if (datareader.Read())
                        {
                            MessageBox.Show("Product name already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            datareader.Close();
                            connections.connection.conn.Close();

                            txtProductNameValue.Text = "";
                            txtProductNameValue.Focus();
                        }
                        else
                        {
                            datareader.Close();
                            s_product = "Update Products set [ProductName] = '" + newProductName + "', [ProductDesc] = '" + newProductDesc + "', [ProductPrice] = " + newProductPrice + ", [ProductStock] = " + newProductStock + " where [ProductID] = " + productID;
                            command = new OleDbCommand(s_product, connections.connection.conn);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Product successfully updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connections.connection.conn.Close();

                            loadAdminProductDataGrid();
                            clearProductInfo();
                        }
                    }
                    else if (newProductName == prevProductName)
                    {
                        s_product = "Update Products set [ProductName] = '" + newProductName + "', [ProductDesc] = '" + newProductDesc + "', [ProductPrice] = " + newProductPrice + ", [ProductStock] = " + newProductStock + " where [ProductID] = " + productID;
                        command = new OleDbCommand(s_product, connections.connection.conn);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Product successfully updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connections.connection.conn.Close();

                        loadAdminProductDataGrid();
                        clearProductInfo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdminProductDelete_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(dgvAdminProducts.CurrentRow.Cells[0].Value);

            DialogResult dr = MessageBox.Show("All orders of this product will also be deleted.\nDo you still want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    connections.connection.DB();
                    string s_order = "Delete from Orders where [ProductID] = " + productID;
                    OleDbCommand command = new OleDbCommand(s_order, connections.connection.conn);
                    command.ExecuteNonQuery();

                    string s_product = "Delete from Products where [ProductID] = " + productID;
                    command = new OleDbCommand(s_product, connections.connection.conn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Product successfully deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connections.connection.conn.Close();

                    loadAdminOrderDataGrid();
                    clearOrderDetails();
                    loadAdminProductDataGrid();
                    clearProductInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool productInfoFieldCheck()
        {
            bool valid = true;

            string productName = txtProductNameValue.Text;
            string productDesc = txtProductDescValue.Text;
            decimal productPrice;

            try
            {
                productPrice = Convert.ToDecimal(numProductPriceValue.Value);
            }
            catch (Exception ex)
            {
                string exKeeper = ex.ToString();
                productPrice = 0;
            }

            if(productName == "")
            {
                MessageBox.Show("Enter product name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtProductNameValue.Focus();
                valid = false;
            }
            else if(productDesc == "")
            {
                MessageBox.Show("Enter product description.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtProductDescValue.Focus();
                valid = false;
            }
            else if(productPrice == 0)
            {
                MessageBox.Show("Enter product price.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                numProductPriceValue.Focus();
                valid = false;
            }

            return valid;
        }

        private void chkShowPasswordAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPasswordAdmin.Checked == true)
            {
                txtPasswordValue.UseSystemPasswordChar = false;
            }
            else if (chkShowPasswordAdmin.Checked == false)
            {
                txtPasswordValue.UseSystemPasswordChar = true;
            }
        }

        private void btnAdminAccountClear_Click(object sender, EventArgs e)
        {
            clearAccountInfo();
        }

        private void btnAdminAccountAdd_Click(object sender, EventArgs e)
        {
            if(accountInfoFieldCheck())
            {
                string newUsername = txtUsernameValue.Text;
                string newPassword = txtPasswordValue.Text;
                string newFirstName = txtFirstNameValue.Text;
                string newMiddleName = txtMiddleNameValue.Text;
                string newLastName = txtLastNameValue.Text;
                string newHomeAddress = txtHomeAddressValue.Text;
                string newContactNum = txtContactNumValue.Text;
                string newEmail = txtEmailValue.Text;
                string newAccountRole = cmbAccountRoleValue.SelectedItem.ToString();

                try
                {
                    connections.connection.DB();
                    string existingUsername = "Select [Username] from Accounts where [Username] = '" + newUsername + "'";
                    OleDbCommand command = new OleDbCommand(existingUsername, connections.connection.conn);
                    OleDbDataReader datareader = command.ExecuteReader();

                    if (datareader.Read())
                    {
                        MessageBox.Show("Username already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datareader.Close();
                        connections.connection.conn.Close();

                        txtUsernameValue.Text = "";
                        txtUsernameValue.Focus();
                    }
                    else
                    {
                        datareader.Close();
                        string s_account = "Insert into Accounts([Username], [Password], [CustFName], [CustMName], [CustLName], [CustAddress], [CustContactNum], [CustEmail], [AccRole]) values ('" + newUsername + "', '" + newPassword + "', '" + newFirstName + "', '" + newMiddleName + "', '" + newLastName + "', '" + newHomeAddress + "', '" + newContactNum + "', '" + newEmail + "', '" + newAccountRole + "')";
                        command = new OleDbCommand(s_account, connections.connection.conn);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Account successfully added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connections.connection.conn.Close();

                        loadAdminAccountDataGrid();
                        clearAccountInfo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdminAccountUpdate_Click(object sender, EventArgs e)
        {
            if (accountInfoFieldCheck())
            {
                int custID = Convert.ToInt32(dgvAdminAccounts.CurrentRow.Cells[0].Value);
                string prevUsername = dgvAdminAccounts.CurrentRow.Cells[1].Value.ToString();
                string newUsername = txtUsernameValue.Text;
                string newPassword = txtPasswordValue.Text;
                string newFirstName = txtFirstNameValue.Text;
                string newMiddleName = txtMiddleNameValue.Text;
                string newLastName = txtLastNameValue.Text;
                string newHomeAddress = txtHomeAddressValue.Text;
                string newContactNum = txtContactNumValue.Text;
                string newEmail = txtEmailValue.Text;
                string newAccountRole = cmbAccountRoleValue.SelectedItem.ToString();

                try
                {
                    connections.connection.DB();
                    string s_account = "";
                    OleDbCommand command;

                    if (newUsername != prevUsername)
                    {
                        s_account = "Select [Username] from Accounts where [Username] = '" + newUsername + "'";
                        command = new OleDbCommand(s_account, connections.connection.conn);
                        OleDbDataReader datareader = command.ExecuteReader();

                        if (datareader.Read())
                        {
                            MessageBox.Show("Username already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            datareader.Close();
                            connections.connection.conn.Close();

                            txtUsernameValue.Text = "";
                            txtUsernameValue.Focus();
                        }
                        else
                        {
                            datareader.Close();
                            s_account = "Update Accounts set [Username] = '" + newUsername + "', [Password] = '" + newPassword + "', [CustFName] = '" + newFirstName + "', [CustMName] = '" + newMiddleName + "', [CustLName] = '" + newLastName + "', [CustAddress] = '" + newHomeAddress + "', [CustContactNum] = '" + newContactNum + "', [CustEmail] = '" + newEmail + "', [AccRole] = '" + newAccountRole + "' where [CustID] = " + custID;
                            command = new OleDbCommand(s_account, connections.connection.conn);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Account successfully updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connections.connection.conn.Close();

                            loadAdminAccountDataGrid();
                            clearAccountInfo();
                        }
                    }
                    else if (newUsername == prevUsername)
                    {
                        s_account = "Update Accounts set [Username] = '" + newUsername + "', [Password] = '" + newPassword + "', [CustFName] = '" + newFirstName + "', [CustMName] = '" + newMiddleName + "', [CustLName] = '" + newLastName + "', [CustAddress] = '" + newHomeAddress + "', [CustContactNum] = '" + newContactNum + "', [CustEmail] = '" + newEmail + "', [AccRole] = '" + newAccountRole + "' where [CustID] = " + custID;
                        command = new OleDbCommand(s_account, connections.connection.conn);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Account successfully updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connections.connection.conn.Close();

                        loadAdminAccountDataGrid();
                        clearAccountInfo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdminAccountDelete_Click(object sender, EventArgs e)
        {
            int custID = Convert.ToInt32(dgvAdminAccounts.CurrentRow.Cells[0].Value);

            DialogResult dr = MessageBox.Show("All records of this account will also be deleted.\nDo you still want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    connections.connection.DB();
                    string s_order = "Delete from Orders where [CustID] = " + custID;
                    OleDbCommand command = new OleDbCommand(s_order, connections.connection.conn);
                    command.ExecuteNonQuery();

                    string s_refill = "Delete from Refills where [CustID] = " + custID;
                    command = new OleDbCommand(s_refill, connections.connection.conn);
                    command.ExecuteNonQuery();

                    string s_account = "Delete from Accounts where [CustID] = " + custID;
                    command = new OleDbCommand(s_account, connections.connection.conn);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Account successfully deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connections.connection.conn.Close();

                    loadAdminRefillDataGrid();
                    clearRefillDetails();
                    loadAdminOrderDataGrid();
                    clearOrderDetails();
                    loadAdminAccountDataGrid();
                    clearAccountInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool accountInfoFieldCheck()
        {
            bool valid = true;

            if (txtUsernameValue.Text == "")
            {
                MessageBox.Show("Enter username.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtUsernameValue.Focus();
                valid = false;
            }
            else if (txtPasswordValue.Text == "")
            {
                MessageBox.Show("Enter password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPasswordValue.Focus();
                valid = false;
            }
            else if (txtFirstNameValue.Text == "")
            {
                MessageBox.Show("Enter first name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtFirstNameValue.Focus();
                valid = false;
            }
            else if (txtMiddleNameValue.Text == "")
            {
                MessageBox.Show("Enter middle name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtMiddleNameValue.Focus();
                valid = false;
            }
            else if (txtLastNameValue.Text == "")
            {
                MessageBox.Show("Enter last name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtLastNameValue.Focus();
                valid = false;
            }
            else if (txtHomeAddressValue.Text == "")
            {
                MessageBox.Show("Enter home address.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtHomeAddressValue.Focus();
                valid = false;
            }
            else if (txtContactNumValue.Text == "")
            {
                MessageBox.Show("Enter contact number.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtContactNumValue.Focus();
                valid = false;
            }
            else if (txtEmailValue.Text == "")
            {
                MessageBox.Show("Enter e-mail address.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEmailValue.Focus();
                valid = false;
            }

            return valid;
        }
    }
}
