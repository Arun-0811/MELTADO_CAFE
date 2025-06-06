namespace MELTADO_CAFE
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            PanelDesktop = new Panel();
            panel2 = new Panel();
            btn_close = new Button();
            lbltitle = new Label();
            btn_max = new Button();
            btn_min = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnCustomerFeedback = new Button();
            btnReportingAnalytics = new Button();
            btnAddStaffs = new Button();
            btnStaffShedule = new Button();
            btnInventoryManagment = new Button();
            btnAdminDashboard = new Button();
            btnMenuManagement = new Button();
            btnCustomerManagement = new Button();
            fontDialog1 = new FontDialog();
            btnLogout = new Button();
            PanelDesktop.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelDesktop
            // 
            PanelDesktop.BackColor = Color.WhiteSmoke;
            PanelDesktop.BackgroundImage = (Image)resources.GetObject("PanelDesktop.BackgroundImage");
            PanelDesktop.BackgroundImageLayout = ImageLayout.Stretch;
            PanelDesktop.Controls.Add(panel2);
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(233, 0);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(960, 742);
            PanelDesktop.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(btn_close);
            panel2.Controls.Add(lbltitle);
            panel2.Controls.Add(btn_max);
            panel2.Controls.Add(btn_min);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 59);
            panel2.TabIndex = 1;
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.BackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Popup;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.Location = new Point(934, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(21, 19);
            btn_close.TabIndex = 11;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // lbltitle
            // 
            lbltitle.Anchor = AnchorStyles.None;
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.FromArgb(128, 64, 0);
            lbltitle.Location = new Point(339, 13);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(281, 32);
            lbltitle.TabIndex = 6;
            lbltitle.Text = "Admin DashBoard";
            // 
            // btn_max
            // 
            btn_max.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_max.BackColor = Color.Lime;
            btn_max.FlatStyle = FlatStyle.Popup;
            btn_max.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_max.Location = new Point(907, 3);
            btn_max.Name = "btn_max";
            btn_max.Size = new Size(21, 19);
            btn_max.TabIndex = 12;
            btn_max.UseVisualStyleBackColor = false;
            btn_max.Click += btn_max_Click;
            // 
            // btn_min
            // 
            btn_min.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_min.BackColor = Color.Yellow;
            btn_min.FlatStyle = FlatStyle.Popup;
            btn_min.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_min.Location = new Point(880, 3);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(21, 19);
            btn_min.TabIndex = 13;
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCustomerFeedback);
            panel1.Controls.Add(btnReportingAnalytics);
            panel1.Controls.Add(btnAddStaffs);
            panel1.Controls.Add(btnStaffShedule);
            panel1.Controls.Add(btnInventoryManagment);
            panel1.Controls.Add(btnAdminDashboard);
            panel1.Controls.Add(btnMenuManagement);
            panel1.Controls.Add(btnCustomerManagement);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 742);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnCustomerFeedback
            // 
            btnCustomerFeedback.BackColor = Color.FromArgb(255, 192, 192);
            btnCustomerFeedback.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnCustomerFeedback.Location = new Point(0, 599);
            btnCustomerFeedback.Name = "btnCustomerFeedback";
            btnCustomerFeedback.Size = new Size(225, 56);
            btnCustomerFeedback.TabIndex = 0;
            btnCustomerFeedback.Text = "Customers Feedback's";
            btnCustomerFeedback.UseVisualStyleBackColor = false;
            btnCustomerFeedback.Click += btnCustomerFeedback_Click;
            // 
            // btnReportingAnalytics
            // 
            btnReportingAnalytics.BackColor = Color.FromArgb(255, 192, 192);
            btnReportingAnalytics.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnReportingAnalytics.Location = new Point(3, 537);
            btnReportingAnalytics.Name = "btnReportingAnalytics";
            btnReportingAnalytics.Size = new Size(222, 56);
            btnReportingAnalytics.TabIndex = 0;
            btnReportingAnalytics.Text = "Reporting / Analytics";
            btnReportingAnalytics.UseVisualStyleBackColor = false;
            btnReportingAnalytics.Click += btnReportingAnalytics_Click;
            // 
            // btnAddStaffs
            // 
            btnAddStaffs.BackColor = Color.FromArgb(255, 192, 192);
            btnAddStaffs.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnAddStaffs.Location = new Point(3, 489);
            btnAddStaffs.Name = "btnAddStaffs";
            btnAddStaffs.Size = new Size(222, 42);
            btnAddStaffs.TabIndex = 0;
            btnAddStaffs.Text = "Add Admin / Staff's";
            btnAddStaffs.UseVisualStyleBackColor = false;
            btnAddStaffs.Click += btnAddStaffs_Click;
            // 
            // btnStaffShedule
            // 
            btnStaffShedule.BackColor = Color.FromArgb(255, 192, 192);
            btnStaffShedule.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnStaffShedule.Location = new Point(3, 440);
            btnStaffShedule.Name = "btnStaffShedule";
            btnStaffShedule.Size = new Size(222, 43);
            btnStaffShedule.TabIndex = 0;
            btnStaffShedule.Text = "Staff Shedule";
            btnStaffShedule.UseVisualStyleBackColor = false;
            btnStaffShedule.Click += btnStaffShedule_Click;
            // 
            // btnInventoryManagment
            // 
            btnInventoryManagment.BackColor = Color.FromArgb(255, 192, 192);
            btnInventoryManagment.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnInventoryManagment.Location = new Point(3, 378);
            btnInventoryManagment.Name = "btnInventoryManagment";
            btnInventoryManagment.Size = new Size(225, 56);
            btnInventoryManagment.TabIndex = 0;
            btnInventoryManagment.Text = "Inventory Managment";
            btnInventoryManagment.UseVisualStyleBackColor = false;
            btnInventoryManagment.Click += btnInventoryManagment_Click;
            // 
            // btnAdminDashboard
            // 
            btnAdminDashboard.BackColor = Color.FromArgb(255, 192, 192);
            btnAdminDashboard.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnAdminDashboard.Location = new Point(3, 208);
            btnAdminDashboard.Name = "btnAdminDashboard";
            btnAdminDashboard.Size = new Size(225, 48);
            btnAdminDashboard.TabIndex = 0;
            btnAdminDashboard.Text = "Admin DashBoard";
            btnAdminDashboard.UseVisualStyleBackColor = false;
            btnAdminDashboard.Click += btnAdminDashboard_Click;
            // 
            // btnMenuManagement
            // 
            btnMenuManagement.BackColor = Color.FromArgb(255, 192, 192);
            btnMenuManagement.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnMenuManagement.Location = new Point(3, 324);
            btnMenuManagement.Name = "btnMenuManagement";
            btnMenuManagement.Size = new Size(225, 48);
            btnMenuManagement.TabIndex = 0;
            btnMenuManagement.Text = "Menu Management";
            btnMenuManagement.UseVisualStyleBackColor = false;
            btnMenuManagement.Click += btnMenuManagement_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = Color.FromArgb(255, 192, 192);
            btnCustomerManagement.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerManagement.Location = new Point(3, 262);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(225, 56);
            btnCustomerManagement.TabIndex = 0;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = false;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.BackgroundImageLayout = ImageLayout.Center;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(132, 690);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 37);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1193, 742);
            Controls.Add(PanelDesktop);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            PanelDesktop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelDesktop;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnInventoryManagment;
        private Button btnMenuManagement;
        private Button btnCustomerManagement;
        private Label lblTitle;
        //private Label lblTitle;
        private Panel panel2;
        private Button btnStaffShedule;
        private Button btnAddStaffs;
        private Button btnReportingAnalytics;
        private FontDialog fontDialog1;
        private Label lbltitle;
        private Button btnCustomerFeedback;
        private Button btn_close;
        private Button btn_max;
        private Button btn_min;
        private Button btnAdminDashboard;
        private Button btnLogout;
    }
}