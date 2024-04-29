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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private bool loginFieldCheck()
        {
            bool valid = true;

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(username == "")
            {
                MessageBox.Show("Enter your username.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtUsername.Focus();
                valid = false;
            }
            else if(password == "")
            {
                MessageBox.Show("Enter your password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPassword.Focus();
                valid = false;
            }

            return valid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(loginFieldCheck())
            {
                try
                {
                    connections.connection.DB();
                    string gen = "Select * from Accounts where [Username] = '" + txtUsername.Text + "' and [Password] = '" + txtPassword.Text + "'";
                    OleDbCommand command = new OleDbCommand(gen, connections.connection.conn);
                    OleDbDataReader datareader = command.ExecuteReader();

                    if (datareader.Read())
                    {
                        functions.function.currentCustID = datareader.GetInt32(0);
                        functions.function.currentUsername = datareader.GetString(1);
                        functions.function.currentCustFName = datareader.GetString(3);
                        functions.function.currentCustMName = datareader.GetString(4);
                        functions.function.currentCustLName = datareader.GetString(5);
                        functions.function.currentCustFullName = functions.function.currentCustFName + " " + functions.function.currentCustMName + " " + functions.function.currentCustLName;
                        functions.function.currentCustAddress = datareader.GetString(6);
                        functions.function.currentCustContactNum = datareader.GetString(7);
                        functions.function.currentCustEmail = datareader.GetString(8);
                        functions.function.currentAccRole = datareader.GetString(9);

                        if(functions.function.currentAccRole == "Admin")
                        {
                            functions.function.frmAdminMain = new frmAdminMain();
                            functions.function.frmAdminMain.Show();
                        }
                        else if(functions.function.currentAccRole == "User")
                        {
                            functions.function.frmUserMain = new frmUserMain();
                            functions.function.frmUserMain.Show();
                        }

                        clear();
                        this.Hide();
                        datareader.Close();
                        connections.connection.conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password.", "Log in failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmRegister newRegister = new frmRegister();
            newRegister.Show();
            clear();
            this.Hide();
        }
    }
}
