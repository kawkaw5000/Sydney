
namespace AquaGoDesktop
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpRegAccountCred = new System.Windows.Forms.GroupBox();
            this.chkShowPasswordConfirm = new System.Windows.Forms.CheckBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblRegPasswordConfirm = new System.Windows.Forms.Label();
            this.txtRegPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.lblRegUsername = new System.Windows.Forms.Label();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpRegPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.txtRegContactNum = new System.Windows.Forms.TextBox();
            this.lblRegContactNum = new System.Windows.Forms.Label();
            this.txtRegHomeAddress = new System.Windows.Forms.TextBox();
            this.lblRegHomeAddress = new System.Windows.Forms.Label();
            this.txtRegLastName = new System.Windows.Forms.TextBox();
            this.lblRegLastName = new System.Windows.Forms.Label();
            this.txtRegMiddleName = new System.Windows.Forms.TextBox();
            this.lblRegMiddleName = new System.Windows.Forms.Label();
            this.txtRegFirstName = new System.Windows.Forms.TextBox();
            this.lblRegFirstName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegBack = new System.Windows.Forms.Button();
            this.grpRegAccountCred.SuspendLayout();
            this.grpRegPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegAccountCred
            // 
            this.grpRegAccountCred.Controls.Add(this.chkShowPasswordConfirm);
            this.grpRegAccountCred.Controls.Add(this.chkShowPassword);
            this.grpRegAccountCred.Controls.Add(this.lblRegPasswordConfirm);
            this.grpRegAccountCred.Controls.Add(this.txtRegPasswordConfirm);
            this.grpRegAccountCred.Controls.Add(this.lblRegPassword);
            this.grpRegAccountCred.Controls.Add(this.txtRegPassword);
            this.grpRegAccountCred.Controls.Add(this.lblRegUsername);
            this.grpRegAccountCred.Controls.Add(this.txtRegUsername);
            this.grpRegAccountCred.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegAccountCred.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grpRegAccountCred.Location = new System.Drawing.Point(9, 10);
            this.grpRegAccountCred.Margin = new System.Windows.Forms.Padding(2);
            this.grpRegAccountCred.Name = "grpRegAccountCred";
            this.grpRegAccountCred.Padding = new System.Windows.Forms.Padding(2);
            this.grpRegAccountCred.Size = new System.Drawing.Size(256, 493);
            this.grpRegAccountCred.TabIndex = 0;
            this.grpRegAccountCred.TabStop = false;
            this.grpRegAccountCred.Text = "Account Credentials";
            // 
            // chkShowPasswordConfirm
            // 
            this.chkShowPasswordConfirm.AutoSize = true;
            this.chkShowPasswordConfirm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPasswordConfirm.Location = new System.Drawing.Point(31, 245);
            this.chkShowPasswordConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowPasswordConfirm.Name = "chkShowPasswordConfirm";
            this.chkShowPasswordConfirm.Size = new System.Drawing.Size(131, 21);
            this.chkShowPasswordConfirm.TabIndex = 25;
            this.chkShowPasswordConfirm.Text = "Show Characters";
            this.chkShowPasswordConfirm.UseVisualStyleBackColor = true;
            this.chkShowPasswordConfirm.CheckedChanged += new System.EventHandler(this.chkShowPasswordConfirm_CheckedChanged);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(31, 158);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(131, 21);
            this.chkShowPassword.TabIndex = 24;
            this.chkShowPassword.Text = "Show Characters";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblRegPasswordConfirm
            // 
            this.lblRegPasswordConfirm.AutoSize = true;
            this.lblRegPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPasswordConfirm.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRegPasswordConfirm.Location = new System.Drawing.Point(27, 193);
            this.lblRegPasswordConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegPasswordConfirm.Name = "lblRegPasswordConfirm";
            this.lblRegPasswordConfirm.Size = new System.Drawing.Size(141, 20);
            this.lblRegPasswordConfirm.TabIndex = 11;
            this.lblRegPasswordConfirm.Text = "Confirm Password:";
            // 
            // txtRegPasswordConfirm
            // 
            this.txtRegPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPasswordConfirm.Location = new System.Drawing.Point(31, 215);
            this.txtRegPasswordConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegPasswordConfirm.Name = "txtRegPasswordConfirm";
            this.txtRegPasswordConfirm.Size = new System.Drawing.Size(167, 26);
            this.txtRegPasswordConfirm.TabIndex = 10;
            this.txtRegPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPassword.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRegPassword.Location = new System.Drawing.Point(27, 106);
            this.lblRegPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(82, 20);
            this.lblRegPassword.TabIndex = 9;
            this.lblRegPassword.Text = "Password:";
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPassword.Location = new System.Drawing.Point(31, 128);
            this.txtRegPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(167, 26);
            this.txtRegPassword.TabIndex = 8;
            this.txtRegPassword.UseSystemPasswordChar = true;
            // 
            // lblRegUsername
            // 
            this.lblRegUsername.AutoSize = true;
            this.lblRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegUsername.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRegUsername.Location = new System.Drawing.Point(27, 37);
            this.lblRegUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegUsername.Name = "lblRegUsername";
            this.lblRegUsername.Size = new System.Drawing.Size(87, 20);
            this.lblRegUsername.TabIndex = 7;
            this.lblRegUsername.Text = "Username:";
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegUsername.Location = new System.Drawing.Point(31, 60);
            this.txtRegUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(167, 26);
            this.txtRegUsername.TabIndex = 6;
            // 
            // grpRegPersonalInfo
            // 
            this.grpRegPersonalInfo.Controls.Add(this.txtRegEmail);
            this.grpRegPersonalInfo.Controls.Add(this.lblRegEmail);
            this.grpRegPersonalInfo.Controls.Add(this.txtRegContactNum);
            this.grpRegPersonalInfo.Controls.Add(this.lblRegContactNum);
            this.grpRegPersonalInfo.Controls.Add(this.txtRegHomeAddress);
            this.grpRegPersonalInfo.Controls.Add(this.lblRegHomeAddress);
            this.grpRegPersonalInfo.Controls.Add(this.txtRegLastName);
            this.grpRegPersonalInfo.Controls.Add(this.lblRegLastName);
            this.grpRegPersonalInfo.Controls.Add(this.txtRegMiddleName);
            this.grpRegPersonalInfo.Controls.Add(this.lblRegMiddleName);
            this.grpRegPersonalInfo.Controls.Add(this.txtRegFirstName);
            this.grpRegPersonalInfo.Controls.Add(this.lblRegFirstName);
            this.grpRegPersonalInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegPersonalInfo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grpRegPersonalInfo.Location = new System.Drawing.Point(284, 10);
            this.grpRegPersonalInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpRegPersonalInfo.Name = "grpRegPersonalInfo";
            this.grpRegPersonalInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpRegPersonalInfo.Size = new System.Drawing.Size(388, 493);
            this.grpRegPersonalInfo.TabIndex = 1;
            this.grpRegPersonalInfo.TabStop = false;
            this.grpRegPersonalInfo.Text = "User Information";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegEmail.Location = new System.Drawing.Point(32, 447);
            this.txtRegEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(301, 26);
            this.txtRegEmail.TabIndex = 23;
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRegEmail.Location = new System.Drawing.Point(28, 424);
            this.lblRegEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(120, 20);
            this.lblRegEmail.TabIndex = 22;
            this.lblRegEmail.Text = "E-mail Address:";
            // 
            // txtRegContactNum
            // 
            this.txtRegContactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegContactNum.Location = new System.Drawing.Point(32, 383);
            this.txtRegContactNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegContactNum.Name = "txtRegContactNum";
            this.txtRegContactNum.Size = new System.Drawing.Size(188, 26);
            this.txtRegContactNum.TabIndex = 21;
            this.txtRegContactNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegContactNum_KeyPress_1);
            // 
            // lblRegContactNum
            // 
            this.lblRegContactNum.AutoSize = true;
            this.lblRegContactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegContactNum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRegContactNum.Location = new System.Drawing.Point(28, 360);
            this.lblRegContactNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegContactNum.Name = "lblRegContactNum";
            this.lblRegContactNum.Size = new System.Drawing.Size(97, 20);
            this.lblRegContactNum.TabIndex = 20;
            this.lblRegContactNum.Text = "Contact No.:";
            // 
            // txtRegHomeAddress
            // 
            this.txtRegHomeAddress.Location = new System.Drawing.Point(32, 268);
            this.txtRegHomeAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegHomeAddress.Multiline = true;
            this.txtRegHomeAddress.Name = "txtRegHomeAddress";
            this.txtRegHomeAddress.Size = new System.Drawing.Size(301, 68);
            this.txtRegHomeAddress.TabIndex = 19;
            // 
            // lblRegHomeAddress
            // 
            this.lblRegHomeAddress.AutoSize = true;
            this.lblRegHomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegHomeAddress.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRegHomeAddress.Location = new System.Drawing.Point(28, 245);
            this.lblRegHomeAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegHomeAddress.Name = "lblRegHomeAddress";
            this.lblRegHomeAddress.Size = new System.Drawing.Size(119, 20);
            this.lblRegHomeAddress.TabIndex = 17;
            this.lblRegHomeAddress.Text = "Home Address:";
            // 
            // txtRegLastName
            // 
            this.txtRegLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegLastName.Location = new System.Drawing.Point(32, 200);
            this.txtRegLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegLastName.Name = "txtRegLastName";
            this.txtRegLastName.Size = new System.Drawing.Size(188, 26);
            this.txtRegLastName.TabIndex = 15;
            this.txtRegLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegLastName_KeyPress);
            // 
            // lblRegLastName
            // 
            this.lblRegLastName.AutoSize = true;
            this.lblRegLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegLastName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRegLastName.Location = new System.Drawing.Point(28, 177);
            this.lblRegLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegLastName.Name = "lblRegLastName";
            this.lblRegLastName.Size = new System.Drawing.Size(90, 20);
            this.lblRegLastName.TabIndex = 16;
            this.lblRegLastName.Text = "Last Name:";
            // 
            // txtRegMiddleName
            // 
            this.txtRegMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegMiddleName.Location = new System.Drawing.Point(32, 128);
            this.txtRegMiddleName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegMiddleName.Name = "txtRegMiddleName";
            this.txtRegMiddleName.Size = new System.Drawing.Size(188, 26);
            this.txtRegMiddleName.TabIndex = 13;
            this.txtRegMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegMiddleName_KeyPress);
            // 
            // lblRegMiddleName
            // 
            this.lblRegMiddleName.AutoSize = true;
            this.lblRegMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegMiddleName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRegMiddleName.Location = new System.Drawing.Point(28, 106);
            this.lblRegMiddleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegMiddleName.Name = "lblRegMiddleName";
            this.lblRegMiddleName.Size = new System.Drawing.Size(105, 20);
            this.lblRegMiddleName.TabIndex = 14;
            this.lblRegMiddleName.Text = "Middle Name:";
            // 
            // txtRegFirstName
            // 
            this.txtRegFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegFirstName.Location = new System.Drawing.Point(32, 60);
            this.txtRegFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegFirstName.Name = "txtRegFirstName";
            this.txtRegFirstName.Size = new System.Drawing.Size(188, 26);
            this.txtRegFirstName.TabIndex = 12;
            this.txtRegFirstName.TextChanged += new System.EventHandler(this.txtRegFirstName_TextChanged);
            this.txtRegFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegFirstName_KeyPress);
            // 
            // lblRegFirstName
            // 
            this.lblRegFirstName.AutoSize = true;
            this.lblRegFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegFirstName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRegFirstName.Location = new System.Drawing.Point(28, 37);
            this.lblRegFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegFirstName.Name = "lblRegFirstName";
            this.lblRegFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblRegFirstName.TabIndex = 12;
            this.lblRegFirstName.Text = "First Name:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(484, 518);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(88, 35);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRegBack
            // 
            this.btnRegBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegBack.ForeColor = System.Drawing.Color.White;
            this.btnRegBack.Location = new System.Drawing.Point(584, 518);
            this.btnRegBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegBack.Name = "btnRegBack";
            this.btnRegBack.Size = new System.Drawing.Size(88, 35);
            this.btnRegBack.TabIndex = 8;
            this.btnRegBack.Text = "Back";
            this.btnRegBack.UseVisualStyleBackColor = false;
            this.btnRegBack.Click += new System.EventHandler(this.btnRegBack_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 570);
            this.Controls.Add(this.btnRegBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpRegPersonalInfo);
            this.Controls.Add(this.grpRegAccountCred);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AquaGo Desktop - Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegister_FormClosed);
            this.grpRegAccountCred.ResumeLayout(false);
            this.grpRegAccountCred.PerformLayout();
            this.grpRegPersonalInfo.ResumeLayout(false);
            this.grpRegPersonalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegAccountCred;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblRegPasswordConfirm;
        private System.Windows.Forms.TextBox txtRegPasswordConfirm;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Label lblRegUsername;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.GroupBox grpRegPersonalInfo;
        private System.Windows.Forms.Label lblRegHomeAddress;
        private System.Windows.Forms.TextBox txtRegLastName;
        private System.Windows.Forms.Label lblRegLastName;
        private System.Windows.Forms.TextBox txtRegMiddleName;
        private System.Windows.Forms.Label lblRegMiddleName;
        private System.Windows.Forms.TextBox txtRegFirstName;
        private System.Windows.Forms.Label lblRegFirstName;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.TextBox txtRegContactNum;
        private System.Windows.Forms.Label lblRegContactNum;
        private System.Windows.Forms.TextBox txtRegHomeAddress;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRegBack;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.CheckBox chkShowPasswordConfirm;
    }
}