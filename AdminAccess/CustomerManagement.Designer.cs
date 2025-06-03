namespace MELTADO_CAFE
{
    partial class CustomerManagement
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
            components = new System.ComponentModel.Container();
            CustomerManagment_panel = new Panel();
            grpbox_Address = new GroupBox();
            txtInstructions = new TextBox();
            txtAddress = new TextBox();
            grpbox_HistoryFeedback = new GroupBox();
            dtpLastVisit = new DateTimePicker();
            txtTotalSpend = new TextBox();
            txtLastFeedback = new TextBox();
            txtTotalVisits = new TextBox();
            grpbox_LoyaltyInfo = new GroupBox();
            numPoints = new NumericUpDown();
            txtCardNo = new TextBox();
            cmbTier = new ComboBox();
            grpbox_Preferences = new GroupBox();
            cmbTable = new ComboBox();
            cmbTime = new ComboBox();
            cmbFavorites = new ComboBox();
            cmbDietary = new ComboBox();
            grpbox_cusdetails = new GroupBox();
            dtpDOB = new DateTimePicker();
            cmbGender = new ComboBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            dgvCustomers = new DataGridView();
            btn_save = new Button();
            btn_delete = new Button();
            btn_clear = new Button();
            btn_search = new Button();
            btn_add = new Button();
            label1 = new Label();
            PopUptoolTip = new ToolTip(components);
            txt_gendercmblist = new TextBox();
            txt_dietarylist = new TextBox();
            txt_usualtimelist = new TextBox();
            txt_membershiptierlist = new TextBox();
            GridView_CustomerPreference = new DataGridView();
            btn_btn_SAVE = new Button();
            btn_btn_ADD = new Button();
            btn_btn_DELETE = new Button();
            btn_btn_CLEAR = new Button();
            grpbox_cuscmbbox = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            panelMain = new Panel();
            txtSearchCustomer = new TextBox();
            btn_btn_membershipclickload = new Button();
            btn_btn_usualtimeload = new Button();
            btn_btn_dietaryclickload = new Button();
            btn_btn_genderclickload = new Button();
            btnRefresh = new Button();
            CustomerManagment_panel.SuspendLayout();
            grpbox_Address.SuspendLayout();
            grpbox_HistoryFeedback.SuspendLayout();
            grpbox_LoyaltyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPoints).BeginInit();
            grpbox_Preferences.SuspendLayout();
            grpbox_cusdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridView_CustomerPreference).BeginInit();
            grpbox_cuscmbbox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerManagment_panel
            // 
            CustomerManagment_panel.BackColor = Color.FromArgb(224, 224, 224);
            CustomerManagment_panel.Controls.Add(grpbox_Address);
            CustomerManagment_panel.Controls.Add(grpbox_HistoryFeedback);
            CustomerManagment_panel.Controls.Add(grpbox_LoyaltyInfo);
            CustomerManagment_panel.Controls.Add(grpbox_Preferences);
            CustomerManagment_panel.Controls.Add(grpbox_cusdetails);
            CustomerManagment_panel.Location = new Point(696, 78);
            CustomerManagment_panel.Name = "CustomerManagment_panel";
            CustomerManagment_panel.Size = new Size(763, 466);
            CustomerManagment_panel.TabIndex = 1;
            // 
            // grpbox_Address
            // 
            grpbox_Address.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpbox_Address.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_Address.Controls.Add(txtInstructions);
            grpbox_Address.Controls.Add(txtAddress);
            grpbox_Address.Location = new Point(267, 236);
            grpbox_Address.Name = "grpbox_Address";
            grpbox_Address.Size = new Size(226, 212);
            grpbox_Address.TabIndex = 4;
            grpbox_Address.TabStop = false;
            grpbox_Address.Text = "Address";
            // 
            // txtInstructions
            // 
            txtInstructions.Location = new Point(17, 133);
            txtInstructions.Multiline = true;
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(193, 61);
            txtInstructions.TabIndex = 14;
            PopUptoolTip.SetToolTip(txtInstructions, "Enter Your Prefferable Delivery Instructions");
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(17, 26);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(193, 91);
            txtAddress.TabIndex = 13;
            PopUptoolTip.SetToolTip(txtAddress, "Enter Your  Home Address");
            // 
            // grpbox_HistoryFeedback
            // 
            grpbox_HistoryFeedback.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpbox_HistoryFeedback.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_HistoryFeedback.Controls.Add(dtpLastVisit);
            grpbox_HistoryFeedback.Controls.Add(txtTotalSpend);
            grpbox_HistoryFeedback.Controls.Add(txtLastFeedback);
            grpbox_HistoryFeedback.Controls.Add(txtTotalVisits);
            grpbox_HistoryFeedback.Location = new Point(512, 14);
            grpbox_HistoryFeedback.Name = "grpbox_HistoryFeedback";
            grpbox_HistoryFeedback.Size = new Size(232, 434);
            grpbox_HistoryFeedback.TabIndex = 3;
            grpbox_HistoryFeedback.TabStop = false;
            grpbox_HistoryFeedback.Text = "History & Feedback";
            // 
            // dtpLastVisit
            // 
            dtpLastVisit.Location = new Point(20, 29);
            dtpLastVisit.Name = "dtpLastVisit";
            dtpLastVisit.Size = new Size(189, 27);
            dtpLastVisit.TabIndex = 15;
            PopUptoolTip.SetToolTip(dtpLastVisit, "Your Last Visited Date");
            // 
            // txtTotalSpend
            // 
            txtTotalSpend.Location = new Point(20, 114);
            txtTotalSpend.Name = "txtTotalSpend";
            txtTotalSpend.Size = new Size(193, 27);
            txtTotalSpend.TabIndex = 17;
            PopUptoolTip.SetToolTip(txtTotalSpend, "Your Total Expence spent here");
            // 
            // txtLastFeedback
            // 
            txtLastFeedback.Location = new Point(20, 160);
            txtLastFeedback.Multiline = true;
            txtLastFeedback.Name = "txtLastFeedback";
            txtLastFeedback.Size = new Size(193, 256);
            txtLastFeedback.TabIndex = 18;
            PopUptoolTip.SetToolTip(txtLastFeedback, "Your Previous Feedback about this cafe");
            // 
            // txtTotalVisits
            // 
            txtTotalVisits.Location = new Point(20, 71);
            txtTotalVisits.Name = "txtTotalVisits";
            txtTotalVisits.Size = new Size(193, 27);
            txtTotalVisits.TabIndex = 16;
            PopUptoolTip.SetToolTip(txtTotalVisits, "Your Total Visits");
            // 
            // grpbox_LoyaltyInfo
            // 
            grpbox_LoyaltyInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpbox_LoyaltyInfo.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_LoyaltyInfo.Controls.Add(numPoints);
            grpbox_LoyaltyInfo.Controls.Add(txtCardNo);
            grpbox_LoyaltyInfo.Controls.Add(cmbTier);
            grpbox_LoyaltyInfo.Location = new Point(18, 288);
            grpbox_LoyaltyInfo.Name = "grpbox_LoyaltyInfo";
            grpbox_LoyaltyInfo.Size = new Size(223, 160);
            grpbox_LoyaltyInfo.TabIndex = 2;
            grpbox_LoyaltyInfo.TabStop = false;
            grpbox_LoyaltyInfo.Text = "Loyalty Info";
            // 
            // numPoints
            // 
            numPoints.Location = new Point(10, 69);
            numPoints.Name = "numPoints";
            numPoints.Size = new Size(193, 27);
            numPoints.TabIndex = 7;
            PopUptoolTip.SetToolTip(numPoints, "Select Reward Points");
            // 
            // txtCardNo
            // 
            txtCardNo.Location = new Point(10, 29);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.Size = new Size(193, 27);
            txtCardNo.TabIndex = 6;
            PopUptoolTip.SetToolTip(txtCardNo, "Enter Your Loyalty Card Number");
            // 
            // cmbTier
            // 
            cmbTier.FormattingEnabled = true;
            cmbTier.Location = new Point(10, 114);
            cmbTier.Name = "cmbTier";
            cmbTier.Size = new Size(193, 28);
            cmbTier.TabIndex = 8;
            PopUptoolTip.SetToolTip(cmbTier, "Select Your Membership Tier");
            // 
            // grpbox_Preferences
            // 
            grpbox_Preferences.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpbox_Preferences.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_Preferences.Controls.Add(cmbTable);
            grpbox_Preferences.Controls.Add(cmbTime);
            grpbox_Preferences.Controls.Add(cmbFavorites);
            grpbox_Preferences.Controls.Add(cmbDietary);
            grpbox_Preferences.Location = new Point(258, 14);
            grpbox_Preferences.Name = "grpbox_Preferences";
            grpbox_Preferences.Size = new Size(230, 204);
            grpbox_Preferences.TabIndex = 1;
            grpbox_Preferences.TabStop = false;
            grpbox_Preferences.Text = "Preferences";
            // 
            // cmbTable
            // 
            cmbTable.FormattingEnabled = true;
            cmbTable.Location = new Point(20, 113);
            cmbTable.Name = "cmbTable";
            cmbTable.Size = new Size(193, 28);
            cmbTable.TabIndex = 12;
            // 
            // cmbTime
            // 
            cmbTime.FormattingEnabled = true;
            cmbTime.Location = new Point(20, 155);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(193, 28);
            cmbTime.TabIndex = 12;
            PopUptoolTip.SetToolTip(cmbTime, "Select Your Prefferable Time");
            // 
            // cmbFavorites
            // 
            cmbFavorites.FormattingEnabled = true;
            cmbFavorites.Location = new Point(20, 28);
            cmbFavorites.Name = "cmbFavorites";
            cmbFavorites.Size = new Size(193, 28);
            cmbFavorites.TabIndex = 10;
            // 
            // cmbDietary
            // 
            cmbDietary.FormattingEnabled = true;
            cmbDietary.Location = new Point(20, 69);
            cmbDietary.Name = "cmbDietary";
            cmbDietary.Size = new Size(193, 28);
            cmbDietary.TabIndex = 10;
            PopUptoolTip.SetToolTip(cmbDietary, "Select Your Dietary(Food Preference)");
            // 
            // grpbox_cusdetails
            // 
            grpbox_cusdetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpbox_cusdetails.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_cusdetails.Controls.Add(dtpDOB);
            grpbox_cusdetails.Controls.Add(cmbGender);
            grpbox_cusdetails.Controls.Add(txtEmail);
            grpbox_cusdetails.Controls.Add(txtPhone);
            grpbox_cusdetails.Controls.Add(txtName);
            grpbox_cusdetails.Location = new Point(15, 14);
            grpbox_cusdetails.Name = "grpbox_cusdetails";
            grpbox_cusdetails.Size = new Size(221, 259);
            grpbox_cusdetails.TabIndex = 0;
            grpbox_cusdetails.TabStop = false;
            grpbox_cusdetails.Text = "Customer Details";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(17, 166);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(189, 27);
            dtpDOB.TabIndex = 4;
            PopUptoolTip.SetToolTip(dtpDOB, "Select Your DOB");
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(13, 209);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(193, 28);
            cmbGender.TabIndex = 5;
            PopUptoolTip.SetToolTip(cmbGender, "Select Your Gender");
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(13, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 27);
            txtEmail.TabIndex = 3;
            PopUptoolTip.SetToolTip(txtEmail, "Enter Your Email");
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(13, 72);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(193, 27);
            txtPhone.TabIndex = 2;
            PopUptoolTip.SetToolTip(txtPhone, "Enter Your PhoneNo");
            // 
            // txtName
            // 
            txtName.Location = new Point(13, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 27);
            txtName.TabIndex = 1;
            PopUptoolTip.SetToolTip(txtName, "Enter Your Name");
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(25, 78);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(627, 309);
            dgvCustomers.TabIndex = 2;
            PopUptoolTip.SetToolTip(dgvCustomers, "Customer Full Data Shown here (Table Format)");
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.Highlight;
            btn_save.FlatStyle = FlatStyle.Popup;
            btn_save.Font = new Font("Georgia", 10.2F);
            btn_save.Location = new Point(195, 474);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(134, 52);
            btn_save.TabIndex = 3;
            btn_save.Text = "SAVE";
            PopUptoolTip.SetToolTip(btn_save, "Click to Save Details");
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.FlatStyle = FlatStyle.Popup;
            btn_delete.Font = new Font("Georgia", 10.2F);
            btn_delete.Location = new Point(367, 474);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(122, 52);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "DELETE";
            PopUptoolTip.SetToolTip(btn_delete, "Delete Details By Id");
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.Info;
            btn_clear.FlatStyle = FlatStyle.Popup;
            btn_clear.Font = new Font("Georgia", 10.2F);
            btn_clear.Location = new Point(524, 474);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(128, 52);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "CLEAR";
            PopUptoolTip.SetToolTip(btn_clear, "Clear All");
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_search
            // 
            btn_search.FlatStyle = FlatStyle.Popup;
            btn_search.Font = new Font("Georgia", 10.2F);
            btn_search.Location = new Point(25, 404);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(115, 43);
            btn_search.TabIndex = 3;
            btn_search.Text = "SEARCH";
            PopUptoolTip.SetToolTip(btn_search, "Search");
            btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.ForestGreen;
            btn_add.FlatStyle = FlatStyle.Popup;
            btn_add.Font = new Font("Georgia", 10.2F);
            btn_add.Location = new Point(25, 474);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(134, 52);
            btn_add.TabIndex = 3;
            btn_add.Text = "ADD";
            PopUptoolTip.SetToolTip(btn_add, "Click to Add Details");
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(625, 19);
            label1.Name = "label1";
            label1.Size = new Size(358, 35);
            label1.TabIndex = 4;
            label1.Text = "Customer Managment";
            // 
            // PopUptoolTip
            // 
            PopUptoolTip.Popup += PopUptoolTip_Popup;
            // 
            // txt_gendercmblist
            // 
            txt_gendercmblist.Location = new Point(15, 36);
            txt_gendercmblist.Name = "txt_gendercmblist";
            txt_gendercmblist.Size = new Size(237, 27);
            txt_gendercmblist.TabIndex = 6;
            PopUptoolTip.SetToolTip(txt_gendercmblist, "Enter Your Genter List");
            // 
            // txt_dietarylist
            // 
            txt_dietarylist.Location = new Point(19, 26);
            txt_dietarylist.Name = "txt_dietarylist";
            txt_dietarylist.Size = new Size(237, 27);
            txt_dietarylist.TabIndex = 6;
            PopUptoolTip.SetToolTip(txt_dietarylist, "Enter Your Dietary Preference List");
            // 
            // txt_usualtimelist
            // 
            txt_usualtimelist.Location = new Point(15, 42);
            txt_usualtimelist.Name = "txt_usualtimelist";
            txt_usualtimelist.Size = new Size(237, 27);
            txt_usualtimelist.TabIndex = 6;
            PopUptoolTip.SetToolTip(txt_usualtimelist, "Enter your Usual Time List");
            // 
            // txt_membershiptierlist
            // 
            txt_membershiptierlist.Location = new Point(19, 42);
            txt_membershiptierlist.Name = "txt_membershiptierlist";
            txt_membershiptierlist.Size = new Size(237, 27);
            txt_membershiptierlist.TabIndex = 6;
            PopUptoolTip.SetToolTip(txt_membershiptierlist, "Enter Your Membership Tier List");
            // 
            // GridView_CustomerPreference
            // 
            GridView_CustomerPreference.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView_CustomerPreference.Location = new Point(696, 579);
            GridView_CustomerPreference.Name = "GridView_CustomerPreference";
            GridView_CustomerPreference.RowHeadersWidth = 51;
            GridView_CustomerPreference.Size = new Size(364, 188);
            GridView_CustomerPreference.TabIndex = 5;
            GridView_CustomerPreference.CellClick += GridView_CustomerPreference_CellClick;
            // 
            // btn_btn_SAVE
            // 
            btn_btn_SAVE.BackColor = SystemColors.Highlight;
            btn_btn_SAVE.FlatStyle = FlatStyle.Popup;
            btn_btn_SAVE.Location = new Point(195, 791);
            btn_btn_SAVE.Name = "btn_btn_SAVE";
            btn_btn_SAVE.Size = new Size(134, 52);
            btn_btn_SAVE.TabIndex = 3;
            btn_btn_SAVE.Text = "SAVE";
            btn_btn_SAVE.UseVisualStyleBackColor = false;
            btn_btn_SAVE.Click += btn_btn_SAVE_Click;
            // 
            // btn_btn_ADD
            // 
            btn_btn_ADD.BackColor = Color.ForestGreen;
            btn_btn_ADD.FlatStyle = FlatStyle.Popup;
            btn_btn_ADD.Location = new Point(38, 791);
            btn_btn_ADD.Name = "btn_btn_ADD";
            btn_btn_ADD.Size = new Size(121, 52);
            btn_btn_ADD.TabIndex = 3;
            btn_btn_ADD.Text = "ADD";
            btn_btn_ADD.UseVisualStyleBackColor = false;
            btn_btn_ADD.Click += btn_btn_add_Click;
            // 
            // btn_btn_DELETE
            // 
            btn_btn_DELETE.BackColor = Color.Red;
            btn_btn_DELETE.FlatStyle = FlatStyle.Popup;
            btn_btn_DELETE.Location = new Point(367, 791);
            btn_btn_DELETE.Name = "btn_btn_DELETE";
            btn_btn_DELETE.Size = new Size(122, 52);
            btn_btn_DELETE.TabIndex = 3;
            btn_btn_DELETE.Text = "DELETE";
            btn_btn_DELETE.UseVisualStyleBackColor = false;
            btn_btn_DELETE.Click += btn_btn_DELETE_Click;
            // 
            // btn_btn_CLEAR
            // 
            btn_btn_CLEAR.BackColor = SystemColors.Info;
            btn_btn_CLEAR.FlatStyle = FlatStyle.Popup;
            btn_btn_CLEAR.Location = new Point(524, 791);
            btn_btn_CLEAR.Name = "btn_btn_CLEAR";
            btn_btn_CLEAR.Size = new Size(136, 52);
            btn_btn_CLEAR.TabIndex = 3;
            btn_btn_CLEAR.Text = "CLEAR";
            btn_btn_CLEAR.UseVisualStyleBackColor = false;
            btn_btn_CLEAR.Click += btn_btn_CLEAR_Click;
            // 
            // grpbox_cuscmbbox
            // 
            grpbox_cuscmbbox.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_cuscmbbox.Controls.Add(txt_gendercmblist);
            grpbox_cuscmbbox.Location = new Point(36, 558);
            grpbox_cuscmbbox.Name = "grpbox_cuscmbbox";
            grpbox_cuscmbbox.Size = new Size(275, 88);
            grpbox_cuscmbbox.TabIndex = 6;
            grpbox_cuscmbbox.TabStop = false;
            grpbox_cuscmbbox.Text = "Customer Gender";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(txt_dietarylist);
            groupBox1.Location = new Point(385, 558);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 88);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Dietary Preference";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 192);
            groupBox2.Controls.Add(txt_usualtimelist);
            groupBox2.Location = new Point(36, 662);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 88);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customer Usual Time";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 192, 192);
            groupBox3.Controls.Add(txt_membershiptierlist);
            groupBox3.Location = new Point(385, 662);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(275, 88);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Customer Membership Tier";
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.AutoSize = true;
            panelMain.BackColor = Color.FromArgb(192, 192, 255);
            panelMain.Controls.Add(txtSearchCustomer);
            panelMain.Controls.Add(btn_btn_membershipclickload);
            panelMain.Controls.Add(btn_btn_usualtimeload);
            panelMain.Controls.Add(btn_btn_dietaryclickload);
            panelMain.Controls.Add(btn_btn_genderclickload);
            panelMain.Controls.Add(groupBox2);
            panelMain.Controls.Add(btn_btn_CLEAR);
            panelMain.Controls.Add(groupBox3);
            panelMain.Controls.Add(grpbox_cuscmbbox);
            panelMain.Controls.Add(btn_btn_DELETE);
            panelMain.Controls.Add(groupBox1);
            panelMain.Controls.Add(btn_btn_SAVE);
            panelMain.Controls.Add(btn_btn_ADD);
            panelMain.Controls.Add(dgvCustomers);
            panelMain.Controls.Add(CustomerManagment_panel);
            panelMain.Controls.Add(btnRefresh);
            panelMain.Controls.Add(btn_search);
            panelMain.Controls.Add(btn_delete);
            panelMain.Controls.Add(btn_save);
            panelMain.Controls.Add(btn_clear);
            panelMain.Controls.Add(GridView_CustomerPreference);
            panelMain.Controls.Add(btn_add);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1471, 866);
            panelMain.TabIndex = 7;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchCustomer.Location = new Point(178, 403);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(323, 38);
            txtSearchCustomer.TabIndex = 8;
            txtSearchCustomer.TextChanged += txtSearchCustomer_textchanged;
            // 
            // btn_btn_membershipclickload
            // 
            btn_btn_membershipclickload.Location = new Point(1261, 690);
            btn_btn_membershipclickload.Name = "btn_btn_membershipclickload";
            btn_btn_membershipclickload.Size = new Size(188, 44);
            btn_btn_membershipclickload.TabIndex = 7;
            btn_btn_membershipclickload.Text = "Membership Tier Load";
            btn_btn_membershipclickload.UseVisualStyleBackColor = true;
            btn_btn_membershipclickload.Click += btn_btn_membershipclickload_Click;
            // 
            // btn_btn_usualtimeload
            // 
            btn_btn_usualtimeload.Location = new Point(1088, 690);
            btn_btn_usualtimeload.Name = "btn_btn_usualtimeload";
            btn_btn_usualtimeload.Size = new Size(145, 44);
            btn_btn_usualtimeload.TabIndex = 7;
            btn_btn_usualtimeload.Text = "Usual Time Load";
            btn_btn_usualtimeload.UseVisualStyleBackColor = true;
            btn_btn_usualtimeload.Click += btn_btn_usualtimeload_Click;
            // 
            // btn_btn_dietaryclickload
            // 
            btn_btn_dietaryclickload.Location = new Point(1261, 602);
            btn_btn_dietaryclickload.Name = "btn_btn_dietaryclickload";
            btn_btn_dietaryclickload.Size = new Size(188, 44);
            btn_btn_dietaryclickload.TabIndex = 7;
            btn_btn_dietaryclickload.Text = "Dietary Preference Load";
            btn_btn_dietaryclickload.UseVisualStyleBackColor = true;
            btn_btn_dietaryclickload.Click += btn_btn_dietaryclickload_Click;
            // 
            // btn_btn_genderclickload
            // 
            btn_btn_genderclickload.Location = new Point(1088, 602);
            btn_btn_genderclickload.Name = "btn_btn_genderclickload";
            btn_btn_genderclickload.Size = new Size(145, 44);
            btn_btn_genderclickload.TabIndex = 7;
            btn_btn_genderclickload.Text = "Gender Load";
            btn_btn_genderclickload.UseVisualStyleBackColor = true;
            btn_btn_genderclickload.Click += btn_btn_genderclickload_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 192, 128);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(537, 403);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 43);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1471, 866);
            Controls.Add(label1);
            Controls.Add(panelMain);
            Name = "CustomerManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerManagement";
            Load += CustomerManagement_Load;
            CustomerManagment_panel.ResumeLayout(false);
            grpbox_Address.ResumeLayout(false);
            grpbox_Address.PerformLayout();
            grpbox_HistoryFeedback.ResumeLayout(false);
            grpbox_HistoryFeedback.PerformLayout();
            grpbox_LoyaltyInfo.ResumeLayout(false);
            grpbox_LoyaltyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPoints).EndInit();
            grpbox_Preferences.ResumeLayout(false);
            grpbox_cusdetails.ResumeLayout(false);
            grpbox_cusdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridView_CustomerPreference).EndInit();
            grpbox_cuscmbbox.ResumeLayout(false);
            grpbox_cuscmbbox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel CustomerManagment_panel;
        private GroupBox grpbox_cusdetails;
        private GroupBox grpbox_Preferences;
        private DateTimePicker dtpDOB;
        private ComboBox cmbGender;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtName;
        private ComboBox cmbTime;
        private ComboBox cmbDietary;
        private GroupBox grpbox_HistoryFeedback;
        private GroupBox grpbox_LoyaltyInfo;
        private NumericUpDown numPoints;
        private TextBox txtCardNo;
        private ComboBox cmbTier;
        private GroupBox grpbox_Address;
        private TextBox txtInstructions;
        private TextBox txtAddress;
        private DateTimePicker dtpLastVisit;
        private TextBox txtTotalSpend;
        private TextBox txtLastFeedback;
        private TextBox txtTotalVisits;
        private DataGridView dgvCustomers;
        private Button btn_save;
        private Button btn_delete;
        private Button btn_clear;
        private Button btn_search;
        private Button btn_add;
        private Label label1;
        private ToolTip PopUptoolTip;
        private DataGridView GridView_CustomerPreference;
        private Button btn_btn_SAVE;
        private Button btn_btn_ADD;
        private Button btn_btn_DELETE;
        private Button btn_btn_CLEAR;
        private GroupBox grpbox_cuscmbbox;
        private TextBox txt_gendercmblist;
        private GroupBox groupBox1;
        private TextBox txt_dietarylist;
        private GroupBox groupBox2;
        private TextBox txt_usualtimelist;
        private GroupBox groupBox3;
        private TextBox txt_membershiptierlist;
        private Panel panelMain;
        private Button btn_btn_membershipclickload;
        private Button btn_btn_usualtimeload;
        private Button btn_btn_dietaryclickload;
        private Button btn_btn_genderclickload;
        private TextBox txtSearchCustomer;
        private ComboBox cmbFavorites;
        private ComboBox cmbTable;
        private Button btnRefresh;
    }
}