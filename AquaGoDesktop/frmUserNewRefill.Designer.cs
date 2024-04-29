
namespace AquaGoDesktop
{
    partial class frmUserNewRefill
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
            this.lblNewRefillSelectStation = new System.Windows.Forms.Label();
            this.lstNewRefillStation = new System.Windows.Forms.ListBox();
            this.lblNewRefillQty = new System.Windows.Forms.Label();
            this.numNewRefillQty = new System.Windows.Forms.NumericUpDown();
            this.lblNewRefillAddress = new System.Windows.Forms.Label();
            this.txtNewRefillAddress = new System.Windows.Forms.TextBox();
            this.chkNewRefillUserAddress = new System.Windows.Forms.CheckBox();
            this.lblNewRefillPayment = new System.Windows.Forms.Label();
            this.cmbNewRefillPayment = new System.Windows.Forms.ComboBox();
            this.grpNewRefillAmount = new System.Windows.Forms.GroupBox();
            this.lblNewRefillTotalValue = new System.Windows.Forms.Label();
            this.lblNewRefillTotal = new System.Windows.Forms.Label();
            this.lblNewRefillPriceValue = new System.Windows.Forms.Label();
            this.lblNewRefillPrice = new System.Windows.Forms.Label();
            this.btnNewRefillSubmit = new System.Windows.Forms.Button();
            this.btnNewRefillCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNewRefillQty)).BeginInit();
            this.grpNewRefillAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNewRefillSelectStation
            // 
            this.lblNewRefillSelectStation.AutoSize = true;
            this.lblNewRefillSelectStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRefillSelectStation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewRefillSelectStation.Location = new System.Drawing.Point(26, 20);
            this.lblNewRefillSelectStation.Name = "lblNewRefillSelectStation";
            this.lblNewRefillSelectStation.Size = new System.Drawing.Size(139, 25);
            this.lblNewRefillSelectStation.TabIndex = 15;
            this.lblNewRefillSelectStation.Text = "Select Station:";
            // 
            // lstNewRefillStation
            // 
            this.lstNewRefillStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNewRefillStation.FormattingEnabled = true;
            this.lstNewRefillStation.ItemHeight = 20;
            this.lstNewRefillStation.Location = new System.Drawing.Point(31, 57);
            this.lstNewRefillStation.Name = "lstNewRefillStation";
            this.lstNewRefillStation.Size = new System.Drawing.Size(257, 184);
            this.lstNewRefillStation.TabIndex = 16;
            this.lstNewRefillStation.SelectedIndexChanged += new System.EventHandler(this.lstNewRefillStation_SelectedIndexChanged);
            // 
            // lblNewRefillQty
            // 
            this.lblNewRefillQty.AutoSize = true;
            this.lblNewRefillQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRefillQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewRefillQty.Location = new System.Drawing.Point(312, 20);
            this.lblNewRefillQty.Name = "lblNewRefillQty";
            this.lblNewRefillQty.Size = new System.Drawing.Size(290, 25);
            this.lblNewRefillQty.TabIndex = 17;
            this.lblNewRefillQty.Text = "No. of Gallons to Refill(max. 50):";
            // 
            // numNewRefillQty
            // 
            this.numNewRefillQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNewRefillQty.Location = new System.Drawing.Point(634, 18);
            this.numNewRefillQty.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numNewRefillQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNewRefillQty.Name = "numNewRefillQty";
            this.numNewRefillQty.ReadOnly = true;
            this.numNewRefillQty.Size = new System.Drawing.Size(83, 30);
            this.numNewRefillQty.TabIndex = 19;
            this.numNewRefillQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNewRefillQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNewRefillQty.ValueChanged += new System.EventHandler(this.numNewRefillQty_ValueChanged);
            // 
            // lblNewRefillAddress
            // 
            this.lblNewRefillAddress.AutoSize = true;
            this.lblNewRefillAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRefillAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewRefillAddress.Location = new System.Drawing.Point(312, 57);
            this.lblNewRefillAddress.Name = "lblNewRefillAddress";
            this.lblNewRefillAddress.Size = new System.Drawing.Size(166, 25);
            this.lblNewRefillAddress.TabIndex = 20;
            this.lblNewRefillAddress.Text = "Delivery Address:";
            // 
            // txtNewRefillAddress
            // 
            this.txtNewRefillAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewRefillAddress.Location = new System.Drawing.Point(317, 85);
            this.txtNewRefillAddress.Multiline = true;
            this.txtNewRefillAddress.Name = "txtNewRefillAddress";
            this.txtNewRefillAddress.Size = new System.Drawing.Size(400, 83);
            this.txtNewRefillAddress.TabIndex = 21;
            // 
            // chkNewRefillUserAddress
            // 
            this.chkNewRefillUserAddress.AutoSize = true;
            this.chkNewRefillUserAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewRefillUserAddress.Location = new System.Drawing.Point(317, 174);
            this.chkNewRefillUserAddress.Name = "chkNewRefillUserAddress";
            this.chkNewRefillUserAddress.Size = new System.Drawing.Size(199, 24);
            this.chkNewRefillUserAddress.TabIndex = 22;
            this.chkNewRefillUserAddress.Text = "Use my home address";
            this.chkNewRefillUserAddress.UseVisualStyleBackColor = true;
            this.chkNewRefillUserAddress.CheckedChanged += new System.EventHandler(this.chkNewRefillUserAddress_CheckedChanged);
            // 
            // lblNewRefillPayment
            // 
            this.lblNewRefillPayment.AutoSize = true;
            this.lblNewRefillPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRefillPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewRefillPayment.Location = new System.Drawing.Point(312, 216);
            this.lblNewRefillPayment.Name = "lblNewRefillPayment";
            this.lblNewRefillPayment.Size = new System.Drawing.Size(166, 25);
            this.lblNewRefillPayment.TabIndex = 23;
            this.lblNewRefillPayment.Text = "Payment Method:";
            // 
            // cmbNewRefillPayment
            // 
            this.cmbNewRefillPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewRefillPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNewRefillPayment.FormattingEnabled = true;
            this.cmbNewRefillPayment.Items.AddRange(new object[] {
            "Cash on Delivery"});
            this.cmbNewRefillPayment.Location = new System.Drawing.Point(496, 213);
            this.cmbNewRefillPayment.Name = "cmbNewRefillPayment";
            this.cmbNewRefillPayment.Size = new System.Drawing.Size(221, 33);
            this.cmbNewRefillPayment.TabIndex = 24;
            // 
            // grpNewRefillAmount
            // 
            this.grpNewRefillAmount.Controls.Add(this.lblNewRefillTotalValue);
            this.grpNewRefillAmount.Controls.Add(this.lblNewRefillTotal);
            this.grpNewRefillAmount.Controls.Add(this.lblNewRefillPriceValue);
            this.grpNewRefillAmount.Controls.Add(this.lblNewRefillPrice);
            this.grpNewRefillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewRefillAmount.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grpNewRefillAmount.Location = new System.Drawing.Point(31, 255);
            this.grpNewRefillAmount.Name = "grpNewRefillAmount";
            this.grpNewRefillAmount.Size = new System.Drawing.Size(686, 160);
            this.grpNewRefillAmount.TabIndex = 25;
            this.grpNewRefillAmount.TabStop = false;
            this.grpNewRefillAmount.Text = "Refill Amount Info";
            // 
            // lblNewRefillTotalValue
            // 
            this.lblNewRefillTotalValue.AutoSize = true;
            this.lblNewRefillTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRefillTotalValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewRefillTotalValue.Location = new System.Drawing.Point(281, 97);
            this.lblNewRefillTotalValue.Name = "lblNewRefillTotalValue";
            this.lblNewRefillTotalValue.Size = new System.Drawing.Size(51, 25);
            this.lblNewRefillTotalValue.TabIndex = 29;
            this.lblNewRefillTotalValue.Text = "Test";
            // 
            // lblNewRefillTotal
            // 
            this.lblNewRefillTotal.AutoSize = true;
            this.lblNewRefillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRefillTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewRefillTotal.Location = new System.Drawing.Point(35, 97);
            this.lblNewRefillTotal.Name = "lblNewRefillTotal";
            this.lblNewRefillTotal.Size = new System.Drawing.Size(135, 25);
            this.lblNewRefillTotal.TabIndex = 28;
            this.lblNewRefillTotal.Text = "Total Amount:";
            // 
            // lblNewRefillPriceValue
            // 
            this.lblNewRefillPriceValue.AutoSize = true;
            this.lblNewRefillPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRefillPriceValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewRefillPriceValue.Location = new System.Drawing.Point(281, 45);
            this.lblNewRefillPriceValue.Name = "lblNewRefillPriceValue";
            this.lblNewRefillPriceValue.Size = new System.Drawing.Size(51, 25);
            this.lblNewRefillPriceValue.TabIndex = 27;
            this.lblNewRefillPriceValue.Text = "Test";
            // 
            // lblNewRefillPrice
            // 
            this.lblNewRefillPrice.AutoSize = true;
            this.lblNewRefillPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRefillPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewRefillPrice.Location = new System.Drawing.Point(35, 45);
            this.lblNewRefillPrice.Name = "lblNewRefillPrice";
            this.lblNewRefillPrice.Size = new System.Drawing.Size(207, 25);
            this.lblNewRefillPrice.TabIndex = 26;
            this.lblNewRefillPrice.Text = "Refill Price(per gallon):";
            // 
            // btnNewRefillSubmit
            // 
            this.btnNewRefillSubmit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewRefillSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRefillSubmit.ForeColor = System.Drawing.Color.White;
            this.btnNewRefillSubmit.Location = new System.Drawing.Point(340, 441);
            this.btnNewRefillSubmit.Name = "btnNewRefillSubmit";
            this.btnNewRefillSubmit.Size = new System.Drawing.Size(203, 43);
            this.btnNewRefillSubmit.TabIndex = 26;
            this.btnNewRefillSubmit.Text = "Submit Request";
            this.btnNewRefillSubmit.UseVisualStyleBackColor = false;
            this.btnNewRefillSubmit.Click += new System.EventHandler(this.btnNewRefillSubmit_Click);
            // 
            // btnNewRefillCancel
            // 
            this.btnNewRefillCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewRefillCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRefillCancel.ForeColor = System.Drawing.Color.White;
            this.btnNewRefillCancel.Location = new System.Drawing.Point(564, 441);
            this.btnNewRefillCancel.Name = "btnNewRefillCancel";
            this.btnNewRefillCancel.Size = new System.Drawing.Size(152, 43);
            this.btnNewRefillCancel.TabIndex = 27;
            this.btnNewRefillCancel.Text = "Cancel";
            this.btnNewRefillCancel.UseVisualStyleBackColor = false;
            this.btnNewRefillCancel.Click += new System.EventHandler(this.btnNewRefillCancel_Click);
            // 
            // frmUserNewRefill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 509);
            this.Controls.Add(this.btnNewRefillCancel);
            this.Controls.Add(this.btnNewRefillSubmit);
            this.Controls.Add(this.grpNewRefillAmount);
            this.Controls.Add(this.cmbNewRefillPayment);
            this.Controls.Add(this.lblNewRefillPayment);
            this.Controls.Add(this.chkNewRefillUserAddress);
            this.Controls.Add(this.txtNewRefillAddress);
            this.Controls.Add(this.lblNewRefillAddress);
            this.Controls.Add(this.numNewRefillQty);
            this.Controls.Add(this.lblNewRefillQty);
            this.Controls.Add(this.lstNewRefillStation);
            this.Controls.Add(this.lblNewRefillSelectStation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserNewRefill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AquaGo Desktop - New Refill Request";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserNewRefill_FormClosed);
            this.Load += new System.EventHandler(this.frmUserNewRefill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNewRefillQty)).EndInit();
            this.grpNewRefillAmount.ResumeLayout(false);
            this.grpNewRefillAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewRefillSelectStation;
        private System.Windows.Forms.ListBox lstNewRefillStation;
        private System.Windows.Forms.Label lblNewRefillQty;
        private System.Windows.Forms.NumericUpDown numNewRefillQty;
        private System.Windows.Forms.Label lblNewRefillAddress;
        private System.Windows.Forms.TextBox txtNewRefillAddress;
        private System.Windows.Forms.CheckBox chkNewRefillUserAddress;
        private System.Windows.Forms.Label lblNewRefillPayment;
        private System.Windows.Forms.ComboBox cmbNewRefillPayment;
        private System.Windows.Forms.GroupBox grpNewRefillAmount;
        private System.Windows.Forms.Label lblNewRefillTotalValue;
        private System.Windows.Forms.Label lblNewRefillTotal;
        private System.Windows.Forms.Label lblNewRefillPriceValue;
        private System.Windows.Forms.Label lblNewRefillPrice;
        private System.Windows.Forms.Button btnNewRefillSubmit;
        private System.Windows.Forms.Button btnNewRefillCancel;
    }
}