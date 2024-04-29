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
    public partial class frmUserNewRefill : Form
    {
        public frmUserNewRefill()
        {
            InitializeComponent();
        }

        private void btnNewRefillCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserNewRefill_FormClosed(object sender, FormClosedEventArgs e)
        {
            functions.function.frmUserMain.Enabled = true;
        }

        private void frmUserNewRefill_Load(object sender, EventArgs e)
        {
            clearAmount();
            loadStationList();
            numNewRefillQty.Value = 2;
            numNewRefillQty.Value = 1;
            cmbNewRefillPayment.SelectedIndex = 0;
        }

        private void clearAmount()
        {
            lblNewRefillPriceValue.Text = "";
            lblNewRefillTotalValue.Text = "";
        }

        private void loadStationList()
        {
            try
            {
                connections.connection.DB();
                string s_refill = "Select [StationName] from Stations";
                OleDbCommand command = new OleDbCommand(s_refill, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                while(datareader.Read())
                {
                    lstNewRefillStation.Items.Add(datareader.GetString(0));
                }

                lstNewRefillStation.Sorted = true;

                connections.connection.conn.Close();

                try
                {
                    lstNewRefillStation.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    string exKeeper = ex.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstNewRefillStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStation = lstNewRefillStation.SelectedItem.ToString();
            lblNewRefillPriceValue.Text = "Php " + string.Format("{0:F2}", getStationPrice(selectedStation));
        }

        private int getStationID(string station)
        {
            int stationID = 0;

            try
            {
                connections.connection.DB();
                string s_refill = "Select [StationID] from Stations where [StationName] = '" + station + "'";
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

        private decimal getStationPrice(string station)
        {
            decimal refillPrice = 0;

            try
            {
                connections.connection.DB();
                string s_refill = "Select [StationRefillPrice] from Stations where [StationName] = '" + station + "'";
                OleDbCommand command = new OleDbCommand(s_refill, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                if(datareader.Read())
                {
                    refillPrice = datareader.GetDecimal(0);
                }

                connections.connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return refillPrice;
        }

        private void numNewRefillQty_ValueChanged(object sender, EventArgs e)
        {
            string selectedStation = lstNewRefillStation.SelectedItem.ToString();
            int qty = Convert.ToInt32(numNewRefillQty.Value);
            lblNewRefillTotalValue.Text = "Php " + string.Format("{0:F2}", getTotal(getStationPrice(selectedStation), qty));
        }

        private decimal getTotal(decimal price, int qty)
        {
            decimal total = price * qty;

            return total;
        }

        private void chkNewRefillUserAddress_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNewRefillUserAddress.Checked == true)
            {
                txtNewRefillAddress.Text = functions.function.currentCustAddress;
            }
            else if(chkNewRefillUserAddress.Checked == false)
            {
                txtNewRefillAddress.Text = "";
            }
        }

        private void btnNewRefillSubmit_Click(object sender, EventArgs e)
        {
            if(newRefillAddressCheck())
            {
                string newRefillDate = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
                int newCustID = functions.function.currentCustID;
                int newStationID = getStationID(lstNewRefillStation.SelectedItem.ToString());
                int newRefillQty = Convert.ToInt32(numNewRefillQty.Value);
                decimal newRefillPrice = getStationPrice(lstNewRefillStation.SelectedItem.ToString());
                decimal newRefillTotal = getTotal(newRefillPrice, newRefillQty);
                string newRefillPayment = cmbNewRefillPayment.SelectedItem.ToString();
                string newRefillStatus = "Request Submitted";
                string newRefillAddress = txtNewRefillAddress.Text;

                try
                {
                    connections.connection.DB();
                    string s_refill = "Insert into Refills([RefillDate], [CustID], [StationID], [RefillQty], [RefillPrice], [RefillTotal], [RefillPayment], [RefillStatus], [RefillAddress]) values ('" + newRefillDate + "', " + newCustID + ", " + newStationID + ", " + newRefillQty + ", " + newRefillPrice + ", " + newRefillTotal + ", '" + newRefillPayment + "', '" + newRefillStatus + "', '" + newRefillAddress + "')";
                    OleDbCommand command = new OleDbCommand(s_refill, connections.connection.conn);
                    command.ExecuteNonQuery();
                    command.CommandText = "Select @@Identity";
                    int newRefillID = (int)command.ExecuteScalar();
                    connections.connection.conn.Close();

                    MessageBox.Show("Request submitted. Refill ID: " + newRefillID.ToString(), "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    functions.function.frmUserMain.loadUserRefillDataGrid();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool newRefillAddressCheck()
        {
            bool valid = true;

            string address = txtNewRefillAddress.Text;

            if(address == "")
            {
                MessageBox.Show("Enter your delivery address.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNewRefillAddress.Focus();
                valid = false;
            }

            return valid;
        }
    }
}
