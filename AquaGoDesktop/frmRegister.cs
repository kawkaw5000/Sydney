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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            functions.function.frmStart.Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                txtRegPassword.UseSystemPasswordChar = false;
            }
            else if (chkShowPassword.Checked == false)
            {
                txtRegPassword.UseSystemPasswordChar = true;
            }
        }

        private void chkShowPasswordConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPasswordConfirm.Checked == true)
            {
                txtRegPasswordConfirm.UseSystemPasswordChar = false;
            }
            else if (chkShowPasswordConfirm.Checked == false)
            {
                txtRegPasswordConfirm.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(registerFieldCheck())
            {
                try
                {
                    connections.connection.DB();
                    string existingUser = "Select Username from Accounts where Username = '" + txtRegUsername.Text + "'";
                    OleDbCommand command = new OleDbCommand(existingUser, connections.connection.conn);
                    OleDbDataReader datareader = command.ExecuteReader();

                    if (datareader.Read())
                    {
                        MessageBox.Show("Username already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datareader.Close();
                        connections.connection.conn.Close();

                        txtRegUsername.Text = "";
                        txtRegUsername.Focus();
                    }
                    else
                    {
                        datareader.Close();
                        string gen = "Insert into Accounts([Username], [Password], [CustFName], [CustMName], [CustLName], [CustAddress], [CustContactNum], [CustEmail], [AccRole]) values ('" + txtRegUsername.Text + "', '" + txtRegPassword.Text + "', '" + txtRegFirstName.Text + "', '" + txtRegMiddleName.Text + "', '" + txtRegLastName.Text + "', '" + txtRegHomeAddress.Text + "', '" + txtRegContactNum.Text + "', '" + txtRegEmail.Text + "', 'User')";
                        command = new OleDbCommand(gen, connections.connection.conn);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Successfully Registered!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool registerFieldCheck()
        {
            bool valid = true;

            if(txtRegUsername.Text == "")
            {
                MessageBox.Show("Enter your username.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRegUsername.Focus();
                valid = false;
            }
            else if(txtRegPassword.Text == "")
            {
                MessageBox.Show("Enter your password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRegPassword.Focus();
                valid = false;
            }
            else if (txtRegPasswordConfirm.Text == "")
            {
                MessageBox.Show("Confirm your password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRegPasswordConfirm.Focus();
                valid = false;
            }
            else if (txtRegPasswordConfirm.Text != txtRegPassword.Text)
            {
                MessageBox.Show("Password does not match.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRegPasswordConfirm.Text = "";
                txtRegPasswordConfirm.Focus();
                valid = false;
            }
            else if(txtRegFirstName.Text == "")
            {
                MessageBox.Show("Enter your first name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRegFirstName.Focus();
                valid = false;
            }
            else if (txtRegMiddleName.Text == "")
            {
                MessageBox.Show("Enter your middle name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRegMiddleName.Focus();
                valid = false;
            }
            else if (txtRegLastName.Text == "")
            {
                MessageBox.Show("Enter your last name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRegLastName.Focus();
                valid = false;
            }
            else if (txtRegHomeAddress.Text == "")
            {
                MessageBox.Show("Enter your home address.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRegHomeAddress.Focus();
                valid = false;
            }
            else if (txtRegContactNum.Text == "")
            {
                MessageBox.Show("Enter your contact number.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRegContactNum.Focus();
                valid = false;
            }
            else if (txtRegEmail.Text == "")
            {
                MessageBox.Show("Enter your e-mail address.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRegEmail.Focus();
                valid = false;
            }

            return valid;
        }

        private void txtRegFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input");
            }
        }

        private void txtRegMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input");
            }

        }

        private void txtRegLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input");
            }
        }

        private void txtRegContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input");
            }
        }

        private void txtRegContactNum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input");
            }
        }
    }
}
