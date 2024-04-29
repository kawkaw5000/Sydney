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
    public partial class frmUserNewOrder : Form
    {
        public frmUserNewOrder()
        {
            InitializeComponent();
        }

        private void btnNewOrderCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserNewOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            functions.function.frmUserMain.Enabled = true;
        }

        private void frmUserNewOrder_Load(object sender, EventArgs e)
        {
            clearAmount();
            loadProductList();
            
            if(lstNewOrderProduct.Items.Count == 0)
            {
                lblNewOrderSelectProduct.Text = "No Products Avaliable";
                btnNewOrderSubmit.Enabled = false;
            }
            else if(lstNewOrderProduct.Items.Count != 0)
            {
                numNewOrderQty.Value = 2;
                numNewOrderQty.Value = 1;
            }

            cmbNewOrderPayment.SelectedIndex = 0;
        }

        private void clearAmount()
        {
            lblNewOrderPriceValue.Text = "";
            lblNewOrderTotalValue.Text = "";
        }

        private void loadProductList()
        {
            try
            {
                connections.connection.DB();
                string s_order = "Select [ProductName] from Products where [ProductStock] > 0";
                OleDbCommand command = new OleDbCommand(s_order, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                while (datareader.Read())
                {
                    lstNewOrderProduct.Items.Add(datareader.GetString(0));
                }

                connections.connection.conn.Close();

                if(lstNewOrderProduct.Items.Count != 0)
                {
                    lstNewOrderProduct.Sorted = true;
                    lstNewOrderProduct.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstNewOrderProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = lstNewOrderProduct.SelectedItem.ToString();
            int productStock = getProductStock(selectedProduct);
            lblNewOrderQty.Text = "Purchase Quantity(max. " + productStock + "):";
            numNewOrderQty.Value = 1;
            numNewOrderQty.Maximum = productStock;
            lblNewOrderPriceValue.Text = "Php " + string.Format("{0:F2}", getProductPrice(selectedProduct));
        }

        private int getProductID(string product)
        {
            int productID = 0;

            try
            {
                connections.connection.DB();
                string s_order = "Select [ProductID] from Products where [ProductName] = '" + product + "'";
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

        private decimal getProductPrice(string product)
        {
            decimal productPrice = 0;

            try
            {
                connections.connection.DB();
                string s_order = "Select [ProductPrice] from Products where [ProductName] = '" + product + "'";
                OleDbCommand command = new OleDbCommand(s_order, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                if (datareader.Read())
                {
                    productPrice = datareader.GetDecimal(0);
                }

                connections.connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return productPrice;
        }

        private int getProductStock(string product)
        {
            int productStock = 0;

            try
            {
                connections.connection.DB();
                string s_order = "Select [ProductStock] from Products where [ProductName] = '" + product + "'";
                OleDbCommand command = new OleDbCommand(s_order, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                if (datareader.Read())
                {
                    productStock = datareader.GetInt32(0);
                }

                connections.connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return productStock;
        }

        private void numNewOrderQty_ValueChanged(object sender, EventArgs e)
        {
            string selectedProduct = lstNewOrderProduct.SelectedItem.ToString();
            int qty = Convert.ToInt32(numNewOrderQty.Value);
            lblNewOrderTotalValue.Text = "Php " + string.Format("{0:F2}", getTotal(getProductPrice(selectedProduct), qty));
        }

        private decimal getTotal(decimal price, int qty)
        {
            decimal total = price * qty;

            return total;
        }

        private void chkNewOrderUserAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNewOrderUserAddress.Checked == true)
            {
                txtNewOrderAddress.Text = functions.function.currentCustAddress;
            }
            else if (chkNewOrderUserAddress.Checked == false)
            {
                txtNewOrderAddress.Text = "";
            }
        }

        private void btnNewOrderSubmit_Click(object sender, EventArgs e)
        {
            if (newOrderAddressCheck())
            {
                string newOrderDate = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
                int newCustID = functions.function.currentCustID;
                int newProductID = getProductID(lstNewOrderProduct.SelectedItem.ToString());
                int newOrderQty = Convert.ToInt32(numNewOrderQty.Value);
                decimal newOrderPrice = getProductPrice(lstNewOrderProduct.SelectedItem.ToString());
                decimal newOrderTotal = getTotal(newOrderPrice, newOrderQty);
                string newOrderPayment = cmbNewOrderPayment.SelectedItem.ToString();
                string newOrderStatus = "Order Submitted";
                string newOrderAddress = txtNewOrderAddress.Text;

                try
                {
                    connections.connection.DB();

                    string s_product = "Select [ProductStock] from Products where [ProductID] = " + newProductID;
                    OleDbCommand command = new OleDbCommand(s_product, connections.connection.conn);
                    OleDbDataReader datareader = command.ExecuteReader();
                    int prevProductStock = datareader.GetInt32(0);
                    int newProductStock = prevProductStock - newOrderQty;

                    string s_product2 = "Update Products set [ProductStock] = " + newProductStock + " where [ProductID] = " + newProductID;
                    command = new OleDbCommand(s_product2, connections.connection.conn);
                    command.ExecuteNonQuery();

                    string s_order = "Insert into Orders([OrderDate], [CustID], [ProductID], [OrderQty], [OrderPrice], [OrderTotal], [OrderPayment], [OrderStatus], [OrderAddress]) values ('" + newOrderDate + "', " + newCustID + ", " + newProductID + ", " + newOrderQty + ", " + newOrderPrice + ", " + newOrderTotal + ", '" + newOrderPayment + "', '" + newOrderStatus + "', '" + newOrderAddress + "')";
                    command = new OleDbCommand(s_order, connections.connection.conn);
                    command.ExecuteNonQuery();
                    command.CommandText = "Select @@Identity";
                    int newOrderID = (int)command.ExecuteScalar();
                    connections.connection.conn.Close();

                    MessageBox.Show("Order submitted. Order ID: " + newOrderID.ToString(), "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    functions.function.frmUserMain.loadUserOrderDataGrid();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool newOrderAddressCheck()
        {
            bool valid = true;

            string address = txtNewOrderAddress.Text;

            if (address == "")
            {
                MessageBox.Show("Enter your delivery address.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNewOrderAddress.Focus();
                valid = false;
            }

            return valid;
        }
    }
}
