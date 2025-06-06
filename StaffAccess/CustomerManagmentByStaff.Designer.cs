namespace MELTADO_CAFE.StaffAccess
{
    partial class CustomerManagmentByStaff
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
            txtCardNo = new TextBox();
            cmbTier = new ComboBox();
            txtInstructions = new TextBox();
            txtAddress = new TextBox();
            dtpLastVisit = new DateTimePicker();
            txtTotalSpend = new TextBox();
            txtLastFeedback = new TextBox();
            txtTotalVisits = new TextBox();
            cmbTable = new ComboBox();
            cmbTime = new ComboBox();
            cmbFavorites = new ComboBox();
            cmbDietary = new ComboBox();
            dtpDOB = new DateTimePicker();
            cmbGender = new ComboBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtSearchCustomer = new TextBox();
            dgvCustomers = new DataGridView();
            btnRefresh = new Button();
            btn_search = new Button();
            btn_delete = new Button();
            btn_save = new Button();
            btn_clear = new Button();
            btn_add = new Button();
            grpbox_Address = new GroupBox();
            grpbox_HistoryFeedback = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            grpbox_LoyaltyInfo = new GroupBox();
            numPoints = new NumericUpDown();
            grpbox_Preferences = new GroupBox();
            grpbox_cusdetails = new GroupBox();
            CustomerManagment_panel = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            grpbox_Address.SuspendLayout();
            grpbox_HistoryFeedback.SuspendLayout();
            grpbox_LoyaltyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPoints).BeginInit();
            grpbox_Preferences.SuspendLayout();
            grpbox_cusdetails.SuspendLayout();
            CustomerManagment_panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtCardNo
            // 
            txtCardNo.BorderStyle = BorderStyle.FixedSingle;
            txtCardNo.Location = new Point(10, 29);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.Size = new Size(193, 25);
            txtCardNo.TabIndex = 6;
            // 
            // cmbTier
            // 
            cmbTier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTier.FlatStyle = FlatStyle.Popup;
            cmbTier.FormattingEnabled = true;
            cmbTier.Location = new Point(10, 114);
            cmbTier.Name = "cmbTier";
            cmbTier.Size = new Size(193, 26);
            cmbTier.TabIndex = 8;
            // 
            // txtInstructions
            // 
            txtInstructions.BorderStyle = BorderStyle.FixedSingle;
            txtInstructions.Location = new Point(17, 133);
            txtInstructions.Multiline = true;
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(193, 61);
            txtInstructions.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(17, 26);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(193, 91);
            txtAddress.TabIndex = 13;
            // 
            // dtpLastVisit
            // 
            dtpLastVisit.Location = new Point(20, 29);
            dtpLastVisit.Name = "dtpLastVisit";
            dtpLastVisit.Size = new Size(189, 25);
            dtpLastVisit.TabIndex = 15;
            // 
            // txtTotalSpend
            // 
            txtTotalSpend.BorderStyle = BorderStyle.FixedSingle;
            txtTotalSpend.Location = new Point(20, 114);
            txtTotalSpend.Name = "txtTotalSpend";
            txtTotalSpend.Size = new Size(193, 25);
            txtTotalSpend.TabIndex = 17;
            // 
            // txtLastFeedback
            // 
            txtLastFeedback.BorderStyle = BorderStyle.FixedSingle;
            txtLastFeedback.Location = new Point(20, 160);
            txtLastFeedback.Multiline = true;
            txtLastFeedback.Name = "txtLastFeedback";
            txtLastFeedback.Size = new Size(193, 256);
            txtLastFeedback.TabIndex = 18;
            // 
            // txtTotalVisits
            // 
            txtTotalVisits.BorderStyle = BorderStyle.FixedSingle;
            txtTotalVisits.Location = new Point(20, 71);
            txtTotalVisits.Name = "txtTotalVisits";
            txtTotalVisits.Size = new Size(193, 25);
            txtTotalVisits.TabIndex = 16;
            // 
            // cmbTable
            // 
            cmbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTable.FlatStyle = FlatStyle.Popup;
            cmbTable.FormattingEnabled = true;
            cmbTable.Location = new Point(20, 113);
            cmbTable.Name = "cmbTable";
            cmbTable.Size = new Size(193, 26);
            cmbTable.TabIndex = 12;
            // 
            // cmbTime
            // 
            cmbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTime.FlatStyle = FlatStyle.Popup;
            cmbTime.FormattingEnabled = true;
            cmbTime.Location = new Point(20, 155);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(193, 26);
            cmbTime.TabIndex = 12;
            // 
            // cmbFavorites
            // 
            cmbFavorites.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFavorites.FlatStyle = FlatStyle.Popup;
            cmbFavorites.FormattingEnabled = true;
            cmbFavorites.Location = new Point(20, 28);
            cmbFavorites.Name = "cmbFavorites";
            cmbFavorites.Size = new Size(193, 26);
            cmbFavorites.TabIndex = 10;
            // 
            // cmbDietary
            // 
            cmbDietary.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDietary.FlatStyle = FlatStyle.Popup;
            cmbDietary.FormattingEnabled = true;
            cmbDietary.Location = new Point(20, 69);
            cmbDietary.Name = "cmbDietary";
            cmbDietary.Size = new Size(193, 26);
            cmbDietary.TabIndex = 10;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(17, 166);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(189, 25);
            dtpDOB.TabIndex = 4;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Popup;
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(13, 209);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(193, 26);
            cmbGender.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(13, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 25);
            txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(13, 72);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(193, 25);
            txtPhone.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(13, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 25);
            txtName.TabIndex = 1;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCustomer.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchCustomer.Location = new Point(197, 470);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(323, 38);
            txtSearchCustomer.TabIndex = 17;
            txtSearchCustomer.TextChanged += txtSearchCustomer_textchanged;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(44, 145);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(627, 309);
            dgvCustomers.TabIndex = 10;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 192, 128);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(556, 470);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 43);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btn_search
            // 
            btn_search.FlatStyle = FlatStyle.Popup;
            btn_search.Font = new Font("Georgia", 10.2F);
            btn_search.Location = new Point(44, 471);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(115, 43);
            btn_search.TabIndex = 12;
            btn_search.Text = "SEARCH";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.FlatStyle = FlatStyle.Popup;
            btn_delete.Font = new Font("Georgia", 10.2F);
            btn_delete.Location = new Point(386, 541);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(122, 52);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.Highlight;
            btn_save.FlatStyle = FlatStyle.Popup;
            btn_save.Font = new Font("Georgia", 10.2F);
            btn_save.Location = new Point(214, 541);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(134, 52);
            btn_save.TabIndex = 14;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.Info;
            btn_clear.FlatStyle = FlatStyle.Popup;
            btn_clear.Font = new Font("Georgia", 10.2F);
            btn_clear.Location = new Point(543, 541);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(128, 52);
            btn_clear.TabIndex = 15;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.ForestGreen;
            btn_add.FlatStyle = FlatStyle.Popup;
            btn_add.Font = new Font("Georgia", 10.2F);
            btn_add.Location = new Point(44, 541);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(134, 52);
            btn_add.TabIndex = 16;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // grpbox_Address
            // 
            grpbox_Address.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpbox_Address.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_Address.Controls.Add(txtInstructions);
            grpbox_Address.Controls.Add(txtAddress);
            grpbox_Address.Font = new Font("Georgia", 9F);
            grpbox_Address.Location = new Point(267, 236);
            grpbox_Address.Name = "grpbox_Address";
            grpbox_Address.Size = new Size(226, 577);
            grpbox_Address.TabIndex = 4;
            grpbox_Address.TabStop = false;
            grpbox_Address.Text = "Address";
            // 
            // grpbox_HistoryFeedback
            // 
            grpbox_HistoryFeedback.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpbox_HistoryFeedback.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_HistoryFeedback.Controls.Add(dtpLastVisit);
            grpbox_HistoryFeedback.Controls.Add(txtTotalSpend);
            grpbox_HistoryFeedback.Controls.Add(textBox3);
            grpbox_HistoryFeedback.Controls.Add(txtLastFeedback);
            grpbox_HistoryFeedback.Controls.Add(textBox2);
            grpbox_HistoryFeedback.Controls.Add(txtTotalVisits);
            grpbox_HistoryFeedback.Controls.Add(textBox1);
            grpbox_HistoryFeedback.Font = new Font("Georgia", 9F);
            grpbox_HistoryFeedback.Location = new Point(512, 14);
            grpbox_HistoryFeedback.Name = "grpbox_HistoryFeedback";
            grpbox_HistoryFeedback.Size = new Size(232, 799);
            grpbox_HistoryFeedback.TabIndex = 3;
            grpbox_HistoryFeedback.TabStop = false;
            grpbox_HistoryFeedback.Text = "History & Feedback";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(-484, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 25);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(-484, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 25);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-484, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 25);
            textBox1.TabIndex = 1;
            // 
            // grpbox_LoyaltyInfo
            // 
            grpbox_LoyaltyInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpbox_LoyaltyInfo.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_LoyaltyInfo.Controls.Add(numPoints);
            grpbox_LoyaltyInfo.Controls.Add(txtCardNo);
            grpbox_LoyaltyInfo.Controls.Add(cmbTier);
            grpbox_LoyaltyInfo.Font = new Font("Georgia", 9F);
            grpbox_LoyaltyInfo.Location = new Point(18, 288);
            grpbox_LoyaltyInfo.Name = "grpbox_LoyaltyInfo";
            grpbox_LoyaltyInfo.Size = new Size(223, 525);
            grpbox_LoyaltyInfo.TabIndex = 2;
            grpbox_LoyaltyInfo.TabStop = false;
            grpbox_LoyaltyInfo.Text = "Loyalty Info";
            // 
            // numPoints
            // 
            numPoints.Location = new Point(10, 69);
            numPoints.Name = "numPoints";
            numPoints.Size = new Size(193, 25);
            numPoints.TabIndex = 7;
            // 
            // grpbox_Preferences
            // 
            grpbox_Preferences.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpbox_Preferences.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_Preferences.Controls.Add(cmbTable);
            grpbox_Preferences.Controls.Add(cmbTime);
            grpbox_Preferences.Controls.Add(cmbFavorites);
            grpbox_Preferences.Controls.Add(cmbDietary);
            grpbox_Preferences.Font = new Font("Georgia", 9F);
            grpbox_Preferences.Location = new Point(260, 14);
            grpbox_Preferences.Name = "grpbox_Preferences";
            grpbox_Preferences.Size = new Size(236, 203);
            grpbox_Preferences.TabIndex = 1;
            grpbox_Preferences.TabStop = false;
            grpbox_Preferences.Text = "Preferences";
            // 
            // grpbox_cusdetails
            // 
            grpbox_cusdetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpbox_cusdetails.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_cusdetails.Controls.Add(dtpDOB);
            grpbox_cusdetails.Controls.Add(cmbGender);
            grpbox_cusdetails.Controls.Add(txtEmail);
            grpbox_cusdetails.Controls.Add(txtPhone);
            grpbox_cusdetails.Controls.Add(txtName);
            grpbox_cusdetails.Font = new Font("Georgia", 9F);
            grpbox_cusdetails.Location = new Point(12, 14);
            grpbox_cusdetails.Name = "grpbox_cusdetails";
            grpbox_cusdetails.Size = new Size(232, 258);
            grpbox_cusdetails.TabIndex = 0;
            grpbox_cusdetails.TabStop = false;
            grpbox_cusdetails.Text = "Customer Details";
            // 
            // CustomerManagment_panel
            // 
            CustomerManagment_panel.BackColor = Color.FromArgb(224, 224, 224);
            CustomerManagment_panel.Controls.Add(grpbox_Address);
            CustomerManagment_panel.Controls.Add(grpbox_HistoryFeedback);
            CustomerManagment_panel.Controls.Add(grpbox_LoyaltyInfo);
            CustomerManagment_panel.Controls.Add(grpbox_Preferences);
            CustomerManagment_panel.Controls.Add(grpbox_cusdetails);
            CustomerManagment_panel.Location = new Point(722, 145);
            CustomerManagment_panel.Name = "CustomerManagment_panel";
            CustomerManagment_panel.Size = new Size(755, 465);
            CustomerManagment_panel.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(556, 31);
            label1.Name = "label1";
            label1.Size = new Size(358, 35);
            label1.TabIndex = 18;
            label1.Text = "Customer Managment";
            // 
            // CustomerManagmentByStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1512, 654);
            Controls.Add(label1);
            Controls.Add(txtSearchCustomer);
            Controls.Add(dgvCustomers);
            Controls.Add(btnRefresh);
            Controls.Add(btn_search);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Controls.Add(btn_clear);
            Controls.Add(btn_add);
            Controls.Add(CustomerManagment_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerManagmentByStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerManagmentByStaff";
            Load += CustomerManagmentByStaff_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
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
            CustomerManagment_panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCardNo;
        private ComboBox cmbTier;
        private TextBox txtInstructions;
        private TextBox txtAddress;
        private DateTimePicker dtpLastVisit;
        private TextBox txtTotalSpend;
        private TextBox txtLastFeedback;
        private TextBox txtTotalVisits;
        private ComboBox cmbTable;
        private ComboBox cmbTime;
        private ComboBox cmbFavorites;
        private ComboBox cmbDietary;
        private DateTimePicker dtpDOB;
        private ComboBox cmbGender;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtSearchCustomer;
        private DataGridView dgvCustomers;
        private Button btnRefresh;
        private Button btn_search;
        private Button btn_delete;
        private Button btn_save;
        private Button btn_clear;
        private Button btn_add;
        private GroupBox grpbox_Address;
        private GroupBox grpbox_HistoryFeedback;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox grpbox_LoyaltyInfo;
        private NumericUpDown numPoints;
        private GroupBox grpbox_Preferences;
        private GroupBox grpbox_cusdetails;
        private Panel CustomerManagment_panel;
        private Label label1;
    }
}