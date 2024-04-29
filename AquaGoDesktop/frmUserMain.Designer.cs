
namespace AquaGoDesktop
{
    partial class frmUserMain
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblHello = new System.Windows.Forms.Label();
            this.lblActiveUsername = new System.Windows.Forms.Label();
            this.btnUserLogout = new System.Windows.Forms.Button();
            this.btnUserEditAccount = new System.Windows.Forms.Button();
            this.tabUser = new System.Windows.Forms.TabControl();
            this.tbpUserRefill = new System.Windows.Forms.TabPage();
            this.grpUserRefillActions = new System.Windows.Forms.GroupBox();
            this.btnUserRefillContact = new System.Windows.Forms.Button();
            this.btnUserCancelRefill = new System.Windows.Forms.Button();
            this.btnUserNewRefill = new System.Windows.Forms.Button();
            this.grpRequestDetails = new System.Windows.Forms.GroupBox();
            this.lblRefillDateValue = new System.Windows.Forms.Label();
            this.lblRefillDate = new System.Windows.Forms.Label();
            this.lblRefillIDValue = new System.Windows.Forms.Label();
            this.lblRefillID = new System.Windows.Forms.Label();
            this.lblRefillPaymentValue = new System.Windows.Forms.Label();
            this.lblRefillPayment = new System.Windows.Forms.Label();
            this.lblRefillAddressValue = new System.Windows.Forms.Label();
            this.lblRefillAddress = new System.Windows.Forms.Label();
            this.lblRefillStationValue = new System.Windows.Forms.Label();
            this.lblRefillStation = new System.Windows.Forms.Label();
            this.lblRefillStatusValue = new System.Windows.Forms.Label();
            this.lblRefillStatus = new System.Windows.Forms.Label();
            this.lblRefillTotalValue = new System.Windows.Forms.Label();
            this.lblRefillTotal = new System.Windows.Forms.Label();
            this.lblRefillPriceValue = new System.Windows.Forms.Label();
            this.lblRefillPrice = new System.Windows.Forms.Label();
            this.lblRefillQuantityValue = new System.Windows.Forms.Label();
            this.lblRefillQuantity = new System.Windows.Forms.Label();
            this.grpRequestList = new System.Windows.Forms.GroupBox();
            this.txtUserRefillSearch = new System.Windows.Forms.TextBox();
            this.lblUserRefillSearch = new System.Windows.Forms.Label();
            this.dgvUserRefill = new System.Windows.Forms.DataGridView();
            this.tbpUserOrder = new System.Windows.Forms.TabPage();
            this.grpUserOrderActions = new System.Windows.Forms.GroupBox();
            this.btnUserCancelOrder = new System.Windows.Forms.Button();
            this.btnUserNewOrder = new System.Windows.Forms.Button();
            this.grpOrderDetails = new System.Windows.Forms.GroupBox();
            this.lblOrderDateValue = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderIDValue = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblOrderPaymentValue = new System.Windows.Forms.Label();
            this.lblOrderPayment = new System.Windows.Forms.Label();
            this.lblOrderAddressValue = new System.Windows.Forms.Label();
            this.lblOrderAddress = new System.Windows.Forms.Label();
            this.lblOrderProductValue = new System.Windows.Forms.Label();
            this.lblOrderProduct = new System.Windows.Forms.Label();
            this.lblOrderStatusValue = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblOrderTotalValue = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblOrderPriceValue = new System.Windows.Forms.Label();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.lblOrderQuantityValue = new System.Windows.Forms.Label();
            this.lblOrderQuantity = new System.Windows.Forms.Label();
            this.grpOrderList = new System.Windows.Forms.GroupBox();
            this.txtUserOrderSearch = new System.Windows.Forms.TextBox();
            this.lblUserOrderSearch = new System.Windows.Forms.Label();
            this.dgvUserOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabUser.SuspendLayout();
            this.tbpUserRefill.SuspendLayout();
            this.grpUserRefillActions.SuspendLayout();
            this.grpRequestDetails.SuspendLayout();
            this.grpRequestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRefill)).BeginInit();
            this.tbpUserOrder.SuspendLayout();
            this.grpUserOrderActions.SuspendLayout();
            this.grpOrderDetails.SuspendLayout();
            this.grpOrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHello.Location = new System.Drawing.Point(12, 9);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(120, 48);
            this.lblHello.TabIndex = 2;
            this.lblHello.Text = "Hello,";
            // 
            // lblActiveUsername
            // 
            this.lblActiveUsername.AutoSize = true;
            this.lblActiveUsername.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUsername.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblActiveUsername.Location = new System.Drawing.Point(138, 9);
            this.lblActiveUsername.Name = "lblActiveUsername";
            this.lblActiveUsername.Size = new System.Drawing.Size(95, 48);
            this.lblActiveUsername.TabIndex = 3;
            this.lblActiveUsername.Text = "Test";
            // 
            // btnUserLogout
            // 
            this.btnUserLogout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUserLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLogout.ForeColor = System.Drawing.Color.White;
            this.btnUserLogout.Location = new System.Drawing.Point(848, 14);
            this.btnUserLogout.Name = "btnUserLogout";
            this.btnUserLogout.Size = new System.Drawing.Size(152, 43);
            this.btnUserLogout.TabIndex = 13;
            this.btnUserLogout.Text = "Log out";
            this.btnUserLogout.UseVisualStyleBackColor = false;
            this.btnUserLogout.Click += new System.EventHandler(this.btnUserLogout_Click);
            // 
            // btnUserEditAccount
            // 
            this.btnUserEditAccount.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUserEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserEditAccount.ForeColor = System.Drawing.Color.White;
            this.btnUserEditAccount.Location = new System.Drawing.Point(667, 14);
            this.btnUserEditAccount.Name = "btnUserEditAccount";
            this.btnUserEditAccount.Size = new System.Drawing.Size(170, 43);
            this.btnUserEditAccount.TabIndex = 12;
            this.btnUserEditAccount.Text = "Edit Account";
            this.btnUserEditAccount.UseVisualStyleBackColor = false;
            this.btnUserEditAccount.Click += new System.EventHandler(this.btnUserEditAccount_Click);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.tbpUserRefill);
            this.tabUser.Controls.Add(this.tbpUserOrder);
            this.tabUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUser.Location = new System.Drawing.Point(20, 70);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(984, 713);
            this.tabUser.TabIndex = 14;
            // 
            // tbpUserRefill
            // 
            this.tbpUserRefill.Controls.Add(this.grpUserRefillActions);
            this.tbpUserRefill.Controls.Add(this.grpRequestDetails);
            this.tbpUserRefill.Controls.Add(this.grpRequestList);
            this.tbpUserRefill.Location = new System.Drawing.Point(4, 34);
            this.tbpUserRefill.Name = "tbpUserRefill";
            this.tbpUserRefill.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUserRefill.Size = new System.Drawing.Size(976, 675);
            this.tbpUserRefill.TabIndex = 0;
            this.tbpUserRefill.Text = "Refill Requests";
            this.tbpUserRefill.UseVisualStyleBackColor = true;
            // 
            // grpUserRefillActions
            // 
            this.grpUserRefillActions.Controls.Add(this.btnUserRefillContact);
            this.grpUserRefillActions.Controls.Add(this.btnUserCancelRefill);
            this.grpUserRefillActions.Controls.Add(this.btnUserNewRefill);
            this.grpUserRefillActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserRefillActions.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grpUserRefillActions.Location = new System.Drawing.Point(15, 559);
            this.grpUserRefillActions.Name = "grpUserRefillActions";
            this.grpUserRefillActions.Size = new System.Drawing.Size(955, 100);
            this.grpUserRefillActions.TabIndex = 9;
            this.grpUserRefillActions.TabStop = false;
            this.grpUserRefillActions.Text = "Actions";
            // 
            // btnUserRefillContact
            // 
            this.btnUserRefillContact.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUserRefillContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRefillContact.ForeColor = System.Drawing.Color.White;
            this.btnUserRefillContact.Location = new System.Drawing.Point(413, 38);
            this.btnUserRefillContact.Name = "btnUserRefillContact";
            this.btnUserRefillContact.Size = new System.Drawing.Size(185, 43);
            this.btnUserRefillContact.TabIndex = 11;
            this.btnUserRefillContact.Text = "Station Info";
            this.btnUserRefillContact.UseVisualStyleBackColor = false;
            this.btnUserRefillContact.Click += new System.EventHandler(this.btnUserRefillContact_Click);
            // 
            // btnUserCancelRefill
            // 
            this.btnUserCancelRefill.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUserCancelRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCancelRefill.ForeColor = System.Drawing.Color.White;
            this.btnUserCancelRefill.Location = new System.Drawing.Point(205, 38);
            this.btnUserCancelRefill.Name = "btnUserCancelRefill";
            this.btnUserCancelRefill.Size = new System.Drawing.Size(185, 43);
            this.btnUserCancelRefill.TabIndex = 10;
            this.btnUserCancelRefill.Text = "Cancel Refill";
            this.btnUserCancelRefill.UseVisualStyleBackColor = false;
            this.btnUserCancelRefill.Click += new System.EventHandler(this.btnUserCancelRefill_Click);
            // 
            // btnUserNewRefill
            // 
            this.btnUserNewRefill.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUserNewRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserNewRefill.ForeColor = System.Drawing.Color.White;
            this.btnUserNewRefill.Location = new System.Drawing.Point(31, 38);
            this.btnUserNewRefill.Name = "btnUserNewRefill";
            this.btnUserNewRefill.Size = new System.Drawing.Size(152, 43);
            this.btnUserNewRefill.TabIndex = 7;
            this.btnUserNewRefill.Text = "New Refill";
            this.btnUserNewRefill.UseVisualStyleBackColor = false;
            this.btnUserNewRefill.Click += new System.EventHandler(this.btnUserNewRefill_Click);
            // 
            // grpRequestDetails
            // 
            this.grpRequestDetails.Controls.Add(this.lblRefillDateValue);
            this.grpRequestDetails.Controls.Add(this.lblRefillDate);
            this.grpRequestDetails.Controls.Add(this.lblRefillIDValue);
            this.grpRequestDetails.Controls.Add(this.lblRefillID);
            this.grpRequestDetails.Controls.Add(this.lblRefillPaymentValue);
            this.grpRequestDetails.Controls.Add(this.lblRefillPayment);
            this.grpRequestDetails.Controls.Add(this.lblRefillAddressValue);
            this.grpRequestDetails.Controls.Add(this.lblRefillAddress);
            this.grpRequestDetails.Controls.Add(this.lblRefillStationValue);
            this.grpRequestDetails.Controls.Add(this.lblRefillStation);
            this.grpRequestDetails.Controls.Add(this.lblRefillStatusValue);
            this.grpRequestDetails.Controls.Add(this.lblRefillStatus);
            this.grpRequestDetails.Controls.Add(this.lblRefillTotalValue);
            this.grpRequestDetails.Controls.Add(this.lblRefillTotal);
            this.grpRequestDetails.Controls.Add(this.lblRefillPriceValue);
            this.grpRequestDetails.Controls.Add(this.lblRefillPrice);
            this.grpRequestDetails.Controls.Add(this.lblRefillQuantityValue);
            this.grpRequestDetails.Controls.Add(this.lblRefillQuantity);
            this.grpRequestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRequestDetails.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grpRequestDetails.Location = new System.Drawing.Point(509, 15);
            this.grpRequestDetails.Name = "grpRequestDetails";
            this.grpRequestDetails.Size = new System.Drawing.Size(461, 538);
            this.grpRequestDetails.TabIndex = 8;
            this.grpRequestDetails.TabStop = false;
            this.grpRequestDetails.Text = "Request Details";
            // 
            // lblRefillDateValue
            // 
            this.lblRefillDateValue.AutoSize = true;
            this.lblRefillDateValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillDateValue.Location = new System.Drawing.Point(98, 91);
            this.lblRefillDateValue.Name = "lblRefillDateValue";
            this.lblRefillDateValue.Size = new System.Drawing.Size(51, 25);
            this.lblRefillDateValue.TabIndex = 19;
            this.lblRefillDateValue.Text = "Test";
            // 
            // lblRefillDate
            // 
            this.lblRefillDate.AutoSize = true;
            this.lblRefillDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillDate.Location = new System.Drawing.Point(33, 91);
            this.lblRefillDate.Name = "lblRefillDate";
            this.lblRefillDate.Size = new System.Drawing.Size(59, 25);
            this.lblRefillDate.TabIndex = 18;
            this.lblRefillDate.Text = "Date:";
            // 
            // lblRefillIDValue
            // 
            this.lblRefillIDValue.AutoSize = true;
            this.lblRefillIDValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillIDValue.Location = new System.Drawing.Point(122, 51);
            this.lblRefillIDValue.Name = "lblRefillIDValue";
            this.lblRefillIDValue.Size = new System.Drawing.Size(51, 25);
            this.lblRefillIDValue.TabIndex = 17;
            this.lblRefillIDValue.Text = "Test";
            // 
            // lblRefillID
            // 
            this.lblRefillID.AutoSize = true;
            this.lblRefillID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillID.Location = new System.Drawing.Point(33, 51);
            this.lblRefillID.Name = "lblRefillID";
            this.lblRefillID.Size = new System.Drawing.Size(83, 25);
            this.lblRefillID.TabIndex = 16;
            this.lblRefillID.Text = "Refill ID:";
            // 
            // lblRefillPaymentValue
            // 
            this.lblRefillPaymentValue.AutoSize = true;
            this.lblRefillPaymentValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillPaymentValue.Location = new System.Drawing.Point(134, 308);
            this.lblRefillPaymentValue.Name = "lblRefillPaymentValue";
            this.lblRefillPaymentValue.Size = new System.Drawing.Size(51, 25);
            this.lblRefillPaymentValue.TabIndex = 15;
            this.lblRefillPaymentValue.Text = "Test";
            // 
            // lblRefillPayment
            // 
            this.lblRefillPayment.AutoSize = true;
            this.lblRefillPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillPayment.Location = new System.Drawing.Point(33, 308);
            this.lblRefillPayment.Name = "lblRefillPayment";
            this.lblRefillPayment.Size = new System.Drawing.Size(95, 25);
            this.lblRefillPayment.TabIndex = 14;
            this.lblRefillPayment.Text = "Payment:";
            // 
            // lblRefillAddressValue
            // 
            this.lblRefillAddressValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillAddressValue.Location = new System.Drawing.Point(33, 441);
            this.lblRefillAddressValue.Name = "lblRefillAddressValue";
            this.lblRefillAddressValue.Size = new System.Drawing.Size(366, 67);
            this.lblRefillAddressValue.TabIndex = 13;
            this.lblRefillAddressValue.Text = "Test Delivery Address, Town, City 1234";
            // 
            // lblRefillAddress
            // 
            this.lblRefillAddress.AutoSize = true;
            this.lblRefillAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillAddress.Location = new System.Drawing.Point(33, 398);
            this.lblRefillAddress.Name = "lblRefillAddress";
            this.lblRefillAddress.Size = new System.Drawing.Size(166, 25);
            this.lblRefillAddress.TabIndex = 12;
            this.lblRefillAddress.Text = "Delivery Address:";
            // 
            // lblRefillStationValue
            // 
            this.lblRefillStationValue.AutoSize = true;
            this.lblRefillStationValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillStationValue.Location = new System.Drawing.Point(118, 132);
            this.lblRefillStationValue.Name = "lblRefillStationValue";
            this.lblRefillStationValue.Size = new System.Drawing.Size(51, 25);
            this.lblRefillStationValue.TabIndex = 11;
            this.lblRefillStationValue.Text = "Test";
            // 
            // lblRefillStation
            // 
            this.lblRefillStation.AutoSize = true;
            this.lblRefillStation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillStation.Location = new System.Drawing.Point(33, 132);
            this.lblRefillStation.Name = "lblRefillStation";
            this.lblRefillStation.Size = new System.Drawing.Size(79, 25);
            this.lblRefillStation.TabIndex = 10;
            this.lblRefillStation.Text = "Station:";
            // 
            // lblRefillStatusValue
            // 
            this.lblRefillStatusValue.AutoSize = true;
            this.lblRefillStatusValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillStatusValue.Location = new System.Drawing.Point(112, 353);
            this.lblRefillStatusValue.Name = "lblRefillStatusValue";
            this.lblRefillStatusValue.Size = new System.Drawing.Size(51, 25);
            this.lblRefillStatusValue.TabIndex = 9;
            this.lblRefillStatusValue.Text = "Test";
            // 
            // lblRefillStatus
            // 
            this.lblRefillStatus.AutoSize = true;
            this.lblRefillStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillStatus.Location = new System.Drawing.Point(32, 353);
            this.lblRefillStatus.Name = "lblRefillStatus";
            this.lblRefillStatus.Size = new System.Drawing.Size(74, 25);
            this.lblRefillStatus.TabIndex = 8;
            this.lblRefillStatus.Text = "Status:";
            // 
            // lblRefillTotalValue
            // 
            this.lblRefillTotalValue.AutoSize = true;
            this.lblRefillTotalValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillTotalValue.Location = new System.Drawing.Point(101, 264);
            this.lblRefillTotalValue.Name = "lblRefillTotalValue";
            this.lblRefillTotalValue.Size = new System.Drawing.Size(51, 25);
            this.lblRefillTotalValue.TabIndex = 7;
            this.lblRefillTotalValue.Text = "Test";
            // 
            // lblRefillTotal
            // 
            this.lblRefillTotal.AutoSize = true;
            this.lblRefillTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillTotal.Location = new System.Drawing.Point(33, 264);
            this.lblRefillTotal.Name = "lblRefillTotal";
            this.lblRefillTotal.Size = new System.Drawing.Size(62, 25);
            this.lblRefillTotal.TabIndex = 6;
            this.lblRefillTotal.Text = "Total:";
            // 
            // lblRefillPriceValue
            // 
            this.lblRefillPriceValue.AutoSize = true;
            this.lblRefillPriceValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillPriceValue.Location = new System.Drawing.Point(100, 219);
            this.lblRefillPriceValue.Name = "lblRefillPriceValue";
            this.lblRefillPriceValue.Size = new System.Drawing.Size(51, 25);
            this.lblRefillPriceValue.TabIndex = 5;
            this.lblRefillPriceValue.Text = "Test";
            // 
            // lblRefillPrice
            // 
            this.lblRefillPrice.AutoSize = true;
            this.lblRefillPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillPrice.Location = new System.Drawing.Point(32, 219);
            this.lblRefillPrice.Name = "lblRefillPrice";
            this.lblRefillPrice.Size = new System.Drawing.Size(62, 25);
            this.lblRefillPrice.TabIndex = 4;
            this.lblRefillPrice.Text = "Price:";
            // 
            // lblRefillQuantityValue
            // 
            this.lblRefillQuantityValue.AutoSize = true;
            this.lblRefillQuantityValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillQuantityValue.Location = new System.Drawing.Point(129, 175);
            this.lblRefillQuantityValue.Name = "lblRefillQuantityValue";
            this.lblRefillQuantityValue.Size = new System.Drawing.Size(51, 25);
            this.lblRefillQuantityValue.TabIndex = 3;
            this.lblRefillQuantityValue.Text = "Test";
            // 
            // lblRefillQuantity
            // 
            this.lblRefillQuantity.AutoSize = true;
            this.lblRefillQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefillQuantity.Location = new System.Drawing.Point(32, 175);
            this.lblRefillQuantity.Name = "lblRefillQuantity";
            this.lblRefillQuantity.Size = new System.Drawing.Size(91, 25);
            this.lblRefillQuantity.TabIndex = 2;
            this.lblRefillQuantity.Text = "Quantity:";
            // 
            // grpRequestList
            // 
            this.grpRequestList.Controls.Add(this.txtUserRefillSearch);
            this.grpRequestList.Controls.Add(this.lblUserRefillSearch);
            this.grpRequestList.Controls.Add(this.dgvUserRefill);
            this.grpRequestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRequestList.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grpRequestList.Location = new System.Drawing.Point(15, 15);
            this.grpRequestList.Name = "grpRequestList";
            this.grpRequestList.Size = new System.Drawing.Size(488, 538);
            this.grpRequestList.TabIndex = 7;
            this.grpRequestList.TabStop = false;
            this.grpRequestList.Text = "Request List";
            // 
            // txtUserRefillSearch
            // 
            this.txtUserRefillSearch.Location = new System.Drawing.Point(261, 36);
            this.txtUserRefillSearch.Name = "txtUserRefillSearch";
            this.txtUserRefillSearch.Size = new System.Drawing.Size(210, 30);
            this.txtUserRefillSearch.TabIndex = 16;
            this.txtUserRefillSearch.TextChanged += new System.EventHandler(this.txtUserRefillSearch_TextChanged);
            // 
            // lblUserRefillSearch
            // 
            this.lblUserRefillSearch.AutoSize = true;
            this.lblUserRefillSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserRefillSearch.Location = new System.Drawing.Point(16, 39);
            this.lblUserRefillSearch.Name = "lblUserRefillSearch";
            this.lblUserRefillSearch.Size = new System.Drawing.Size(219, 25);
            this.lblUserRefillSearch.TabIndex = 14;
            this.lblUserRefillSearch.Text = "Search by ID or Station:";
            // 
            // dgvUserRefill
            // 
            this.dgvUserRefill.AllowUserToAddRows = false;
            this.dgvUserRefill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRefill.Location = new System.Drawing.Point(21, 77);
            this.dgvUserRefill.Name = "dgvUserRefill";
            this.dgvUserRefill.RowHeadersWidth = 51;
            this.dgvUserRefill.RowTemplate.Height = 24;
            this.dgvUserRefill.Size = new System.Drawing.Size(450, 445);
            this.dgvUserRefill.TabIndex = 0;
            this.dgvUserRefill.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserRefill_CellMouseClick);
            // 
            // tbpUserOrder
            // 
            this.tbpUserOrder.Controls.Add(this.grpUserOrderActions);
            this.tbpUserOrder.Controls.Add(this.grpOrderDetails);
            this.tbpUserOrder.Controls.Add(this.grpOrderList);
            this.tbpUserOrder.Location = new System.Drawing.Point(4, 34);
            this.tbpUserOrder.Name = "tbpUserOrder";
            this.tbpUserOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUserOrder.Size = new System.Drawing.Size(976, 675);
            this.tbpUserOrder.TabIndex = 1;
            this.tbpUserOrder.Text = "Product Orders";
            this.tbpUserOrder.UseVisualStyleBackColor = true;
            // 
            // grpUserOrderActions
            // 
            this.grpUserOrderActions.Controls.Add(this.btnUserCancelOrder);
            this.grpUserOrderActions.Controls.Add(this.btnUserNewOrder);
            this.grpUserOrderActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserOrderActions.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grpUserOrderActions.Location = new System.Drawing.Point(15, 559);
            this.grpUserOrderActions.Name = "grpUserOrderActions";
            this.grpUserOrderActions.Size = new System.Drawing.Size(908, 100);
            this.grpUserOrderActions.TabIndex = 12;
            this.grpUserOrderActions.TabStop = false;
            this.grpUserOrderActions.Text = "Actions";
            // 
            // btnUserCancelOrder
            // 
            this.btnUserCancelOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUserCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnUserCancelOrder.Location = new System.Drawing.Point(205, 38);
            this.btnUserCancelOrder.Name = "btnUserCancelOrder";
            this.btnUserCancelOrder.Size = new System.Drawing.Size(185, 43);
            this.btnUserCancelOrder.TabIndex = 10;
            this.btnUserCancelOrder.Text = "Cancel Order";
            this.btnUserCancelOrder.UseVisualStyleBackColor = false;
            this.btnUserCancelOrder.Click += new System.EventHandler(this.btnUserCancelOrder_Click);
            // 
            // btnUserNewOrder
            // 
            this.btnUserNewOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUserNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnUserNewOrder.Location = new System.Drawing.Point(31, 38);
            this.btnUserNewOrder.Name = "btnUserNewOrder";
            this.btnUserNewOrder.Size = new System.Drawing.Size(152, 43);
            this.btnUserNewOrder.TabIndex = 7;
            this.btnUserNewOrder.Text = "New Order";
            this.btnUserNewOrder.UseVisualStyleBackColor = false;
            this.btnUserNewOrder.Click += new System.EventHandler(this.btnUserNewOrder_Click);
            // 
            // grpOrderDetails
            // 
            this.grpOrderDetails.Controls.Add(this.lblOrderDateValue);
            this.grpOrderDetails.Controls.Add(this.lblOrderDate);
            this.grpOrderDetails.Controls.Add(this.lblOrderIDValue);
            this.grpOrderDetails.Controls.Add(this.lblOrderID);
            this.grpOrderDetails.Controls.Add(this.lblOrderPaymentValue);
            this.grpOrderDetails.Controls.Add(this.lblOrderPayment);
            this.grpOrderDetails.Controls.Add(this.lblOrderAddressValue);
            this.grpOrderDetails.Controls.Add(this.lblOrderAddress);
            this.grpOrderDetails.Controls.Add(this.lblOrderProductValue);
            this.grpOrderDetails.Controls.Add(this.lblOrderProduct);
            this.grpOrderDetails.Controls.Add(this.lblOrderStatusValue);
            this.grpOrderDetails.Controls.Add(this.lblOrderStatus);
            this.grpOrderDetails.Controls.Add(this.lblOrderTotalValue);
            this.grpOrderDetails.Controls.Add(this.lblOrderTotal);
            this.grpOrderDetails.Controls.Add(this.lblOrderPriceValue);
            this.grpOrderDetails.Controls.Add(this.lblOrderPrice);
            this.grpOrderDetails.Controls.Add(this.lblOrderQuantityValue);
            this.grpOrderDetails.Controls.Add(this.lblOrderQuantity);
            this.grpOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderDetails.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grpOrderDetails.Location = new System.Drawing.Point(509, 15);
            this.grpOrderDetails.Name = "grpOrderDetails";
            this.grpOrderDetails.Size = new System.Drawing.Size(461, 538);
            this.grpOrderDetails.TabIndex = 11;
            this.grpOrderDetails.TabStop = false;
            this.grpOrderDetails.Text = "Order Details";
            // 
            // lblOrderDateValue
            // 
            this.lblOrderDateValue.AutoSize = true;
            this.lblOrderDateValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderDateValue.Location = new System.Drawing.Point(98, 91);
            this.lblOrderDateValue.Name = "lblOrderDateValue";
            this.lblOrderDateValue.Size = new System.Drawing.Size(51, 25);
            this.lblOrderDateValue.TabIndex = 23;
            this.lblOrderDateValue.Text = "Test";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderDate.Location = new System.Drawing.Point(33, 91);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 25);
            this.lblOrderDate.TabIndex = 22;
            this.lblOrderDate.Text = "Date:";
            // 
            // lblOrderIDValue
            // 
            this.lblOrderIDValue.AutoSize = true;
            this.lblOrderIDValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderIDValue.Location = new System.Drawing.Point(131, 51);
            this.lblOrderIDValue.Name = "lblOrderIDValue";
            this.lblOrderIDValue.Size = new System.Drawing.Size(51, 25);
            this.lblOrderIDValue.TabIndex = 21;
            this.lblOrderIDValue.Text = "Test";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderID.Location = new System.Drawing.Point(33, 51);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(92, 25);
            this.lblOrderID.TabIndex = 20;
            this.lblOrderID.Text = "Order ID:";
            // 
            // lblOrderPaymentValue
            // 
            this.lblOrderPaymentValue.AutoSize = true;
            this.lblOrderPaymentValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderPaymentValue.Location = new System.Drawing.Point(134, 308);
            this.lblOrderPaymentValue.Name = "lblOrderPaymentValue";
            this.lblOrderPaymentValue.Size = new System.Drawing.Size(51, 25);
            this.lblOrderPaymentValue.TabIndex = 17;
            this.lblOrderPaymentValue.Text = "Test";
            // 
            // lblOrderPayment
            // 
            this.lblOrderPayment.AutoSize = true;
            this.lblOrderPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderPayment.Location = new System.Drawing.Point(33, 308);
            this.lblOrderPayment.Name = "lblOrderPayment";
            this.lblOrderPayment.Size = new System.Drawing.Size(95, 25);
            this.lblOrderPayment.TabIndex = 16;
            this.lblOrderPayment.Text = "Payment:";
            // 
            // lblOrderAddressValue
            // 
            this.lblOrderAddressValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderAddressValue.Location = new System.Drawing.Point(33, 441);
            this.lblOrderAddressValue.Name = "lblOrderAddressValue";
            this.lblOrderAddressValue.Size = new System.Drawing.Size(366, 67);
            this.lblOrderAddressValue.TabIndex = 13;
            this.lblOrderAddressValue.Text = "Test Delivery Address, Town, City 1234";
            // 
            // lblOrderAddress
            // 
            this.lblOrderAddress.AutoSize = true;
            this.lblOrderAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderAddress.Location = new System.Drawing.Point(33, 398);
            this.lblOrderAddress.Name = "lblOrderAddress";
            this.lblOrderAddress.Size = new System.Drawing.Size(166, 25);
            this.lblOrderAddress.TabIndex = 12;
            this.lblOrderAddress.Text = "Delivery Address:";
            // 
            // lblOrderProductValue
            // 
            this.lblOrderProductValue.AutoSize = true;
            this.lblOrderProductValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderProductValue.Location = new System.Drawing.Point(124, 132);
            this.lblOrderProductValue.Name = "lblOrderProductValue";
            this.lblOrderProductValue.Size = new System.Drawing.Size(51, 25);
            this.lblOrderProductValue.TabIndex = 11;
            this.lblOrderProductValue.Text = "Test";
            // 
            // lblOrderProduct
            // 
            this.lblOrderProduct.AutoSize = true;
            this.lblOrderProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderProduct.Location = new System.Drawing.Point(33, 132);
            this.lblOrderProduct.Name = "lblOrderProduct";
            this.lblOrderProduct.Size = new System.Drawing.Size(85, 25);
            this.lblOrderProduct.TabIndex = 10;
            this.lblOrderProduct.Text = "Product:";
            // 
            // lblOrderStatusValue
            // 
            this.lblOrderStatusValue.AutoSize = true;
            this.lblOrderStatusValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderStatusValue.Location = new System.Drawing.Point(112, 353);
            this.lblOrderStatusValue.Name = "lblOrderStatusValue";
            this.lblOrderStatusValue.Size = new System.Drawing.Size(51, 25);
            this.lblOrderStatusValue.TabIndex = 9;
            this.lblOrderStatusValue.Text = "Test";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderStatus.Location = new System.Drawing.Point(32, 353);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(74, 25);
            this.lblOrderStatus.TabIndex = 8;
            this.lblOrderStatus.Text = "Status:";
            // 
            // lblOrderTotalValue
            // 
            this.lblOrderTotalValue.AutoSize = true;
            this.lblOrderTotalValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderTotalValue.Location = new System.Drawing.Point(101, 264);
            this.lblOrderTotalValue.Name = "lblOrderTotalValue";
            this.lblOrderTotalValue.Size = new System.Drawing.Size(51, 25);
            this.lblOrderTotalValue.TabIndex = 7;
            this.lblOrderTotalValue.Text = "Test";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderTotal.Location = new System.Drawing.Point(33, 264);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(62, 25);
            this.lblOrderTotal.TabIndex = 6;
            this.lblOrderTotal.Text = "Total:";
            // 
            // lblOrderPriceValue
            // 
            this.lblOrderPriceValue.AutoSize = true;
            this.lblOrderPriceValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderPriceValue.Location = new System.Drawing.Point(100, 219);
            this.lblOrderPriceValue.Name = "lblOrderPriceValue";
            this.lblOrderPriceValue.Size = new System.Drawing.Size(51, 25);
            this.lblOrderPriceValue.TabIndex = 5;
            this.lblOrderPriceValue.Text = "Test";
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderPrice.Location = new System.Drawing.Point(32, 219);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(62, 25);
            this.lblOrderPrice.TabIndex = 4;
            this.lblOrderPrice.Text = "Price:";
            // 
            // lblOrderQuantityValue
            // 
            this.lblOrderQuantityValue.AutoSize = true;
            this.lblOrderQuantityValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderQuantityValue.Location = new System.Drawing.Point(129, 175);
            this.lblOrderQuantityValue.Name = "lblOrderQuantityValue";
            this.lblOrderQuantityValue.Size = new System.Drawing.Size(51, 25);
            this.lblOrderQuantityValue.TabIndex = 3;
            this.lblOrderQuantityValue.Text = "Test";
            // 
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.AutoSize = true;
            this.lblOrderQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderQuantity.Location = new System.Drawing.Point(32, 175);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.Size = new System.Drawing.Size(91, 25);
            this.lblOrderQuantity.TabIndex = 2;
            this.lblOrderQuantity.Text = "Quantity:";
            // 
            // grpOrderList
            // 
            this.grpOrderList.Controls.Add(this.txtUserOrderSearch);
            this.grpOrderList.Controls.Add(this.lblUserOrderSearch);
            this.grpOrderList.Controls.Add(this.dgvUserOrders);
            this.grpOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderList.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grpOrderList.Location = new System.Drawing.Point(15, 15);
            this.grpOrderList.Name = "grpOrderList";
            this.grpOrderList.Size = new System.Drawing.Size(488, 538);
            this.grpOrderList.TabIndex = 10;
            this.grpOrderList.TabStop = false;
            this.grpOrderList.Text = "Order List";
            // 
            // txtUserOrderSearch
            // 
            this.txtUserOrderSearch.Location = new System.Drawing.Point(261, 36);
            this.txtUserOrderSearch.Name = "txtUserOrderSearch";
            this.txtUserOrderSearch.Size = new System.Drawing.Size(210, 30);
            this.txtUserOrderSearch.TabIndex = 15;
            this.txtUserOrderSearch.TextChanged += new System.EventHandler(this.txtUserOrderSearch_TextChanged);
            // 
            // lblUserOrderSearch
            // 
            this.lblUserOrderSearch.AutoSize = true;
            this.lblUserOrderSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserOrderSearch.Location = new System.Drawing.Point(16, 39);
            this.lblUserOrderSearch.Name = "lblUserOrderSearch";
            this.lblUserOrderSearch.Size = new System.Drawing.Size(225, 25);
            this.lblUserOrderSearch.TabIndex = 14;
            this.lblUserOrderSearch.Text = "Search by ID or Product:";
            // 
            // dgvUserOrders
            // 
            this.dgvUserOrders.AllowUserToAddRows = false;
            this.dgvUserOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserOrders.Location = new System.Drawing.Point(21, 77);
            this.dgvUserOrders.Name = "dgvUserOrders";
            this.dgvUserOrders.RowHeadersWidth = 51;
            this.dgvUserOrders.RowTemplate.Height = 24;
            this.dgvUserOrders.Size = new System.Drawing.Size(450, 445);
            this.dgvUserOrders.TabIndex = 0;
            this.dgvUserOrders.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserOrders_CellMouseClick);
            // 
            // frmUserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 796);
            this.Controls.Add(this.tabUser);
            this.Controls.Add(this.btnUserLogout);
            this.Controls.Add(this.btnUserEditAccount);
            this.Controls.Add(this.lblActiveUsername);
            this.Controls.Add(this.lblHello);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AquaGo Desktop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserMain_FormClosed);
            this.Load += new System.EventHandler(this.frmUserMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabUser.ResumeLayout(false);
            this.tbpUserRefill.ResumeLayout(false);
            this.grpUserRefillActions.ResumeLayout(false);
            this.grpRequestDetails.ResumeLayout(false);
            this.grpRequestDetails.PerformLayout();
            this.grpRequestList.ResumeLayout(false);
            this.grpRequestList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRefill)).EndInit();
            this.tbpUserOrder.ResumeLayout(false);
            this.grpUserOrderActions.ResumeLayout(false);
            this.grpOrderDetails.ResumeLayout(false);
            this.grpOrderDetails.PerformLayout();
            this.grpOrderList.ResumeLayout(false);
            this.grpOrderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblActiveUsername;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnUserLogout;
        private System.Windows.Forms.Button btnUserEditAccount;
        private System.Windows.Forms.TabControl tabUser;
        private System.Windows.Forms.TabPage tbpUserRefill;
        private System.Windows.Forms.TabPage tbpUserOrder;
        private System.Windows.Forms.GroupBox grpUserRefillActions;
        private System.Windows.Forms.Button btnUserRefillContact;
        private System.Windows.Forms.Button btnUserCancelRefill;
        private System.Windows.Forms.Button btnUserNewRefill;
        private System.Windows.Forms.GroupBox grpRequestDetails;
        private System.Windows.Forms.Label lblRefillAddressValue;
        private System.Windows.Forms.Label lblRefillAddress;
        private System.Windows.Forms.Label lblRefillStationValue;
        private System.Windows.Forms.Label lblRefillStation;
        private System.Windows.Forms.Label lblRefillStatusValue;
        private System.Windows.Forms.Label lblRefillStatus;
        private System.Windows.Forms.Label lblRefillTotalValue;
        private System.Windows.Forms.Label lblRefillTotal;
        private System.Windows.Forms.Label lblRefillPriceValue;
        private System.Windows.Forms.Label lblRefillPrice;
        private System.Windows.Forms.Label lblRefillQuantityValue;
        private System.Windows.Forms.Label lblRefillQuantity;
        private System.Windows.Forms.GroupBox grpRequestList;
        private System.Windows.Forms.Label lblUserRefillSearch;
        private System.Windows.Forms.DataGridView dgvUserRefill;
        private System.Windows.Forms.GroupBox grpOrderDetails;
        private System.Windows.Forms.Label lblOrderAddressValue;
        private System.Windows.Forms.Label lblOrderAddress;
        private System.Windows.Forms.Label lblOrderProductValue;
        private System.Windows.Forms.Label lblOrderProduct;
        private System.Windows.Forms.Label lblOrderStatusValue;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblOrderTotalValue;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblOrderPriceValue;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.Label lblOrderQuantityValue;
        private System.Windows.Forms.Label lblOrderQuantity;
        private System.Windows.Forms.GroupBox grpOrderList;
        private System.Windows.Forms.TextBox txtUserOrderSearch;
        private System.Windows.Forms.Label lblUserOrderSearch;
        private System.Windows.Forms.DataGridView dgvUserOrders;
        private System.Windows.Forms.GroupBox grpUserOrderActions;
        private System.Windows.Forms.Button btnUserCancelOrder;
        private System.Windows.Forms.Button btnUserNewOrder;
        private System.Windows.Forms.Label lblRefillPaymentValue;
        private System.Windows.Forms.Label lblRefillPayment;
        private System.Windows.Forms.Label lblOrderPaymentValue;
        private System.Windows.Forms.Label lblOrderPayment;
        private System.Windows.Forms.Label lblRefillDateValue;
        private System.Windows.Forms.Label lblRefillDate;
        private System.Windows.Forms.Label lblRefillIDValue;
        private System.Windows.Forms.Label lblRefillID;
        private System.Windows.Forms.Label lblOrderDateValue;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderIDValue;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtUserRefillSearch;
    }
}