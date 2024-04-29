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
    public partial class frmUserEditAccount : Form
    {
        public frmUserEditAccount()
        {
            InitializeComponent();
        }

        private void frmUserEditAccount_Load(object sender, EventArgs e)
        {
            loadAccountForEdit(functions.function.currentCustID);
        }

        public void loadAccountForEdit(int custID)
        {
            try
            {
                connections.connection.DB();
                string gen = "Select * from Accounts where [CustID] = " + custID;
                OleDbCommand command = new OleDbCommand(gen, connections.connection.conn);
                OleDbDataReader datareader = command.ExecuteReader();

                if (datareader.Read())
                {
                    txtEditUsername.Text = datareader.GetString(1);
                    txtEditPassword.Text = datareader.GetString(2);
                    txtEditPasswordConfirm.Text = datareader.GetString(2);
                    txtEditFirstName.Text = datareader.GetString(3);
                    txtEditMiddleName.Text = datareader.GetString(4);
                    txtEditLastName.Text = datareader.GetString(5);
                    txtEditHomeAddress.Text = datareader.GetString(6);
                    txtEditContactNum.Text = datareader.GetString(7);
                    txtEditEmail.Text = datareader.GetString(8);
                }

                connections.connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserEditAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            functions.function.frmUserMain.Enabled = true;
        }

        private void chkShowPasswordEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPasswordEdit.Checked == true)
            {
                txtEditPassword.UseSystemPasswordChar = false;
            }
            else if (chkShowPasswordEdit.Checked == false)
            {
                txtEditPassword.UseSystemPasswordChar = true;
            }
        }

        private void chkShowPasswordConfirmEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPasswordConfirmEdit.Checked == true)
            {
                txtEditPasswordConfirm.UseSystemPasswordChar = false;
            }
            else if (chkShowPasswordConfirmEdit.Checked == false)
            {
                txtEditPasswordConfirm.UseSystemPasswordChar = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(editAccountFieldCheck())
            {
                string newUsername = txtEditUsername.Text;

                try
                {
                    connections.connection.DB();
                    string gen = "";
                    OleDbCommand command;

                    if (newUsername != functions.function.currentUsername)
                    {
                        gen = "Select * from Accounts where [Username] = '" + newUsername + "'";
                        command = new OleDbCommand(gen, connections.connection.conn);
                        OleDbDataReader datareader = command.ExecuteReader();

                        if(datareader.Read())
                        {
                            MessageBox.Show("Username already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            datareader.Close();
                            connections.connection.conn.Close();

                            txtEditUsername.Text = "";
                            txtEditUsername.Focus();
                        }
                        else
                        {
                            datareader.Close();
                            gen = "Update Accounts set [Username] = '" + txtEditUsername.Text + "', [Password] = '" + txtEditPassword.Text + "', [CustFName] = '" + txtEditFirstName.Text + "', [CustMName] = '" + txtEditMiddleName.Text + "', [CustLName] = '" + txtEditLastName.Text + "', [CustAddress] = '" + txtEditHomeAddress.Text + "', [CustContactNum] = '" + txtEditContactNum.Text + "', [CustEmail] = '" + txtEditEmail.Text + "' where [CustID] = " + functions.function.currentCustID;
                            command = new OleDbCommand(gen, connections.connection.conn);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Successfully Updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connections.connection.conn.Close();
                            this.Close();
                        }
                    }
                    else if(newUsername == functions.function.currentUsername)
                    {
                        gen = "Update Accounts set [Username] = '" + txtEditUsername.Text + "', [Password] = '" + txtEditPassword.Text + "', [CustFName] = '" + txtEditFirstName.Text + "', [CustMName] = '" + txtEditMiddleName.Text + "', [CustLName] = '" + txtEditLastName.Text + "', [CustAddress] = '" + txtEditHomeAddress.Text + "', [CustContactNum] = '" + txtEditContactNum.Text + "', [CustEmail] = '" + txtEditEmail.Text + "' where [CustID] = " + functions.function.currentCustID;
                        command = new OleDbCommand(gen, connections.connection.conn);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Successfully Updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connections.connection.conn.Close();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            int custID = functions.function.currentCustID;

            DialogResult dr = MessageBox.Show("All of your refill requests and orders will also be deleted.\nDo you still want to delete your account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                    MessageBox.Show("Your account has been deleted.\nReturning to Log in Screen.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connections.connection.conn.Close();

                    this.Close();
                    functions.function.frmUserMain.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool editAccountFieldCheck()
        {
            bool valid = true;

            if (txtEditUsername.Text == "")
            {
                MessageBox.Show("Enter your username.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEditUsername.Focus();
                valid = false;
            }
            else if (txtEditPassword.Text == "")
            {
                MessageBox.Show("Enter your password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEditPassword.Focus();
                valid = false;
            }
            else if (txtEditPasswordConfirm.Text == "")
            {
                MessageBox.Show("Confirm your password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEditPasswordConfirm.Focus();
                valid = false;
            }
            else if (txtEditPasswordConfirm.Text != txtEditPassword.Text)
            {
                MessageBox.Show("Password does not match.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEditPasswordConfirm.Text = "";
                txtEditPasswordConfirm.Focus();
                valid = false;
            }
            else if (txtEditFirstName.Text == "")
            {
                MessageBox.Show("Enter your first name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEditFirstName.Focus();
                valid = false;
            }
            else if (txtEditMiddleName.Text == "")
            {
                MessageBox.Show("Enter your middle name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEditMiddleName.Focus();
                valid = false;
            }
            else if (txtEditLastName.Text == "")
            {
                MessageBox.Show("Enter your last name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEditLastName.Focus();
                valid = false;
            }
            else if (txtEditHomeAddress.Text == "")
            {
                MessageBox.Show("Enter your home address.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEditHomeAddress.Focus();
                valid = false;
            }
            else if (txtEditContactNum.Text == "")
            {
                MessageBox.Show("Enter your contact number.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEditContactNum.Focus();
                valid = false;
            }
            else if (txtEditEmail.Text == "")
            {
                MessageBox.Show("Enter your e-mail address.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEditEmail.Focus();
                valid = false;
            }

            return valid;
        }

        private void txtEditFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input");
            }
        }

        private void txtEditMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input");
            }
        }

        private void txtEditLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input");
            }
        }

        private void txtEditContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input");
            }
        }
    }
}
