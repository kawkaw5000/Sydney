
namespace AquaGoDesktop
{
    partial class frmUserNewOrder
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
            this.btnNewOrderCancel = new System.Windows.Forms.Button();
            this.btnNewOrderSubmit = new System.Windows.Forms.Button();
            this.grpNewOrderAmount = new System.Windows.Forms.GroupBox();
            this.lblNewOrderTotalValue = new System.Windows.Forms.Label();
            this.lblNewOrderTotal = new System.Windows.Forms.Label();
            this.lblNewOrderPriceValue = new System.Windows.Forms.Label();
            this.lblNewOrderPrice = new System.Windows.Forms.Label();
            this.cmbNewOrderPayment = new System.Windows.Forms.ComboBox();
            this.lblNewOrderPayment = new System.Windows.Forms.Label();
            this.chkNewOrderUserAddress = new System.Windows.Forms.CheckBox();
            this.txtNewOrderAddress = new System.Windows.Forms.TextBox();
            this.lblNewOrderAddress = new System.Windows.Forms.Label();
            this.numNewOrderQty = new System.Windows.Forms.NumericUpDown();
            this.lblNewOrderQty = new System.Windows.Forms.Label();
            this.lstNewOrderProduct = new System.Windows.Forms.ListBox();
            this.lblNewOrderSelectProduct = new System.Windows.Forms.Label();
            this.grpNewOrderAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNewOrderQty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewOrderCancel
            // 
            this.btnNewOrderCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewOrderCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrderCancel.ForeColor = System.Drawing.Color.White;
            this.btnNewOrderCancel.Location = new System.Drawing.Point(564, 441);
            this.btnNewOrderCancel.Name = "btnNewOrderCancel";
            this.btnNewOrderCancel.Size = new System.Drawing.Size(152, 43);
            this.btnNewOrderCancel.TabIndex = 39;
            this.btnNewOrderCancel.Text = "Cancel";
            this.btnNewOrderCancel.UseVisualStyleBackColor = false;
            this.btnNewOrderCancel.Click += new System.EventHandler(this.btnNewOrderCancel_Click);
            // 
            // btnNewOrderSubmit
            // 
            this.btnNewOrderSubmit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewOrderSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrderSubmit.ForeColor = System.Drawing.Color.White;
            this.btnNewOrderSubmit.Location = new System.Drawing.Point(340, 441);
            this.btnNewOrderSubmit.Name = "btnNewOrderSubmit";
            this.btnNewOrderSubmit.Size = new System.Drawing.Size(203, 43);
            this.btnNewOrderSubmit.TabIndex = 38;
            this.btnNewOrderSubmit.Text = "Submit Order";
            this.btnNewOrderSubmit.UseVisualStyleBackColor = false;
            this.btnNewOrderSubmit.Click += new System.EventHandler(this.btnNewOrderSubmit_Click);
            // 
            // grpNewOrderAmount
            // 
            this.grpNewOrderAmount.Controls.Add(this.lblNewOrderTotalValue);
            this.grpNewOrderAmount.Controls.Add(this.lblNewOrderTotal);
            this.grpNewOrderAmount.Controls.Add(this.lblNewOrderPriceValue);
            this.grpNewOrderAmount.Controls.Add(this.lblNewOrderPrice);
            this.grpNewOrderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewOrderAmount.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grpNewOrderAmount.Location = new System.Drawing.Point(31, 255);
            this.grpNewOrderAmount.Name = "grpNewOrderAmount";
            this.grpNewOrderAmount.Size = new System.Drawing.Size(686, 160);
            this.grpNewOrderAmount.TabIndex = 37;
            this.grpNewOrderAmount.TabStop = false;
            this.grpNewOrderAmount.Text = "Order Amount Info";
            // 
            // lblNewOrderTotalValue
            // 
            this.lblNewOrderTotalValue.AutoSize = true;
            this.lblNewOrderTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrderTotalValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewOrderTotalValue.Location = new System.Drawing.Point(281, 97);
            this.lblNewOrderTotalValue.Name = "lblNewOrderTotalValue";
            this.lblNewOrderTotalValue.Size = new System.Drawing.Size(51, 25);
            this.lblNewOrderTotalValue.TabIndex = 29;
            this.lblNewOrderTotalValue.Text = "Test";
            // 
            // lblNewOrderTotal
            // 
            this.lblNewOrderTotal.AutoSize = true;
            this.lblNewOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrderTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewOrderTotal.Location = new System.Drawing.Point(35, 97);
            this.lblNewOrderTotal.Name = "lblNewOrderTotal";
            this.lblNewOrderTotal.Size = new System.Drawing.Size(135, 25);
            this.lblNewOrderTotal.TabIndex = 28;
            this.lblNewOrderTotal.Text = "Total Amount:";
            // 
            // lblNewOrderPriceValue
            // 
            this.lblNewOrderPriceValue.AutoSize = true;
            this.lblNewOrderPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrderPriceValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewOrderPriceValue.Location = new System.Drawing.Point(281, 45);
            this.lblNewOrderPriceValue.Name = "lblNewOrderPriceValue";
            this.lblNewOrderPriceValue.Size = new System.Drawing.Size(51, 25);
            this.lblNewOrderPriceValue.TabIndex = 27;
            this.lblNewOrderPriceValue.Text = "Test";
            // 
            // lblNewOrderPrice
            // 
            this.lblNewOrderPrice.AutoSize = true;
            this.lblNewOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrderPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewOrderPrice.Location = new System.Drawing.Point(35, 45);
            this.lblNewOrderPrice.Name = "lblNewOrderPrice";
            this.lblNewOrderPrice.Size = new System.Drawing.Size(134, 25);
            this.lblNewOrderPrice.TabIndex = 26;
            this.lblNewOrderPrice.Text = "Product Price:";
            // 
            // cmbNewOrderPayment
            // 
            this.cmbNewOrderPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewOrderPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNewOrderPayment.FormattingEnabled = true;
            this.cmbNewOrderPayment.Items.AddRange(new object[] {
            "Cash on Delivery"});
            this.cmbNewOrderPayment.Location = new System.Drawing.Point(496, 213);
            this.cmbNewOrderPayment.Name = "cmbNewOrderPayment";
            this.cmbNewOrderPayment.Size = new System.Drawing.Size(221, 33);
            this.cmbNewOrderPayment.TabIndex = 36;
            // 
            // lblNewOrderPayment
            // 
            this.lblNewOrderPayment.AutoSize = true;
            this.lblNewOrderPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrderPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewOrderPayment.Location = new System.Drawing.Point(312, 216);
            this.lblNewOrderPayment.Name = "lblNewOrderPayment";
            this.lblNewOrderPayment.Size = new System.Drawing.Size(166, 25);
            this.lblNewOrderPayment.TabIndex = 35;
            this.lblNewOrderPayment.Text = "Payment Method:";
            // 
            // chkNewOrderUserAddress
            // 
            this.chkNewOrderUserAddress.AutoSize = true;
            this.chkNewOrderUserAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewOrderUserAddress.Location = new System.Drawing.Point(317, 174);
            this.chkNewOrderUserAddress.Name = "chkNewOrderUserAddress";
            this.chkNewOrderUserAddress.Size = new System.Drawing.Size(199, 24);
            this.chkNewOrderUserAddress.TabIndex = 34;
            this.chkNewOrderUserAddress.Text = "Use my home address";
            this.chkNewOrderUserAddress.UseVisualStyleBackColor = true;
            this.chkNewOrderUserAddress.CheckedChanged += new System.EventHandler(this.chkNewOrderUserAddress_CheckedChanged);
            // 
            // txtNewOrderAddress
            // 
            this.txtNewOrderAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewOrderAddress.Location = new System.Drawing.Point(317, 85);
            this.txtNewOrderAddress.Multiline = true;
            this.txtNewOrderAddress.Name = "txtNewOrderAddress";
            this.txtNewOrderAddress.Size = new System.Drawing.Size(400, 83);
            this.txtNewOrderAddress.TabIndex = 33;
            // 
            // lblNewOrderAddress
            // 
            this.lblNewOrderAddress.AutoSize = true;
            this.lblNewOrderAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrderAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewOrderAddress.Location = new System.Drawing.Point(312, 57);
            this.lblNewOrderAddress.Name = "lblNewOrderAddress";
            this.lblNewOrderAddress.Size = new System.Drawing.Size(166, 25);
            this.lblNewOrderAddress.TabIndex = 32;
            this.lblNewOrderAddress.Text = "Delivery Address:";
            // 
            // numNewOrderQty
            // 
            this.numNewOrderQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNewOrderQty.Location = new System.Drawing.Point(603, 18);
            this.numNewOrderQty.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numNewOrderQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNewOrderQty.Name = "numNewOrderQty";
            this.numNewOrderQty.ReadOnly = true;
            this.numNewOrderQty.Size = new System.Drawing.Size(83, 30);
            this.numNewOrderQty.TabIndex = 31;
            this.numNewOrderQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNewOrderQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNewOrderQty.ValueChanged += new System.EventHandler(this.numNewOrderQty_ValueChanged);
            // 
            // lblNewOrderQty
            // 
            this.lblNewOrderQty.AutoSize = true;
            this.lblNewOrderQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrderQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewOrderQty.Location = new System.Drawing.Point(312, 20);
            this.lblNewOrderQty.Name = "lblNewOrderQty";
            this.lblNewOrderQty.Size = new System.Drawing.Size(179, 25);
            this.lblNewOrderQty.TabIndex = 30;
            this.lblNewOrderQty.Text = "Purchase Quantity:";
            // 
            // lstNewOrderProduct
            // 
            this.lstNewOrderProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNewOrderProduct.FormattingEnabled = true;
            this.lstNewOrderProduct.ItemHeight = 20;
            this.lstNewOrderProduct.Location = new System.Drawing.Point(31, 57);
            this.lstNewOrderProduct.Name = "lstNewOrderProduct";
            this.lstNewOrderProduct.Size = new System.Drawing.Size(257, 184);
            this.lstNewOrderProduct.TabIndex = 29;
            this.lstNewOrderProduct.SelectedIndexChanged += new System.EventHandler(this.lstNewOrderProduct_SelectedIndexChanged);
            // 
            // lblNewOrderSelectProduct
            // 
            this.lblNewOrderSelectProduct.AutoSize = true;
            this.lblNewOrderSelectProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrderSelectProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewOrderSelectProduct.Location = new System.Drawing.Point(26, 20);
            this.lblNewOrderSelectProduct.Name = "lblNewOrderSelectProduct";
            this.lblNewOrderSelectProduct.Size = new System.Drawing.Size(145, 25);
            this.lblNewOrderSelectProduct.TabIndex = 28;
            this.lblNewOrderSelectProduct.Text = "Select Product:";
            // 
            // frmUserNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 509);
            this.Controls.Add(this.btnNewOrderCancel);
            this.Controls.Add(this.btnNewOrderSubmit);
            this.Controls.Add(this.grpNewOrderAmount);
            this.Controls.Add(this.cmbNewOrderPayment);
            this.Controls.Add(this.lblNewOrderPayment);
            this.Controls.Add(this.chkNewOrderUserAddress);
            this.Controls.Add(this.txtNewOrderAddress);
            this.Controls.Add(this.lblNewOrderAddress);
            this.Controls.Add(this.numNewOrderQty);
            this.Controls.Add(this.lblNewOrderQty);
            this.Controls.Add(this.lstNewOrderProduct);
            this.Controls.Add(this.lblNewOrderSelectProduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AquaGo Desktop - New Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserNewOrder_FormClosed);
            this.Load += new System.EventHandler(this.frmUserNewOrder_Load);
            this.grpNewOrderAmount.ResumeLayout(false);
            this.grpNewOrderAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNewOrderQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewOrderCancel;
        private System.Windows.Forms.Button btnNewOrderSubmit;
        private System.Windows.Forms.GroupBox grpNewOrderAmount;
        private System.Windows.Forms.Label lblNewOrderTotalValue;
        private System.Windows.Forms.Label lblNewOrderTotal;
        private System.Windows.Forms.Label lblNewOrderPriceValue;
        private System.Windows.Forms.Label lblNewOrderPrice;
        private System.Windows.Forms.ComboBox cmbNewOrderPayment;
        private System.Windows.Forms.Label lblNewOrderPayment;
        private System.Windows.Forms.CheckBox chkNewOrderUserAddress;
        private System.Windows.Forms.TextBox txtNewOrderAddress;
        private System.Windows.Forms.Label lblNewOrderAddress;
        private System.Windows.Forms.NumericUpDown numNewOrderQty;
        private System.Windows.Forms.Label lblNewOrderQty;
        private System.Windows.Forms.ListBox lstNewOrderProduct;
        private System.Windows.Forms.Label lblNewOrderSelectProduct;
    }
}