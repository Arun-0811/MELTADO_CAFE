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
            lblTitle = new Label();
            lblDashboard = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnAddStaffs = new Button();
            btnStaffShedule = new Button();
            btnInventoryManagment = new Button();
            btnMenuManagement = new Button();
            btnCustomerManagement = new Button();
            PanelDesktop.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelDesktop
            // 
            PanelDesktop.Controls.Add(panel2);
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(256, 0);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(937, 559);
            PanelDesktop.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(lblDashboard);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(937, 93);
            panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(625, 53);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(269, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ADMIN DASHBOARD";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(160, 46);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(354, 35);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "ADMIN DASHBOARD";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnAddStaffs);
            panel1.Controls.Add(btnStaffShedule);
            panel1.Controls.Add(btnInventoryManagment);
            panel1.Controls.Add(btnMenuManagement);
            panel1.Controls.Add(btnCustomerManagement);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 559);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnAddStaffs
            // 
            btnAddStaffs.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnAddStaffs.Location = new Point(6, 456);
            btnAddStaffs.Name = "btnAddStaffs";
            btnAddStaffs.Size = new Size(247, 65);
            btnAddStaffs.TabIndex = 0;
            btnAddStaffs.Text = "Add Admin / Staff's";
            btnAddStaffs.UseVisualStyleBackColor = true;
            btnAddStaffs.Click += btnAddStaffs_Click;
            // 
            // btnStaffShedule
            // 
            btnStaffShedule.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnStaffShedule.Location = new Point(3, 385);
            btnStaffShedule.Name = "btnStaffShedule";
            btnStaffShedule.Size = new Size(247, 65);
            btnStaffShedule.TabIndex = 0;
            btnStaffShedule.Text = "Staff Shedule";
            btnStaffShedule.UseVisualStyleBackColor = true;
            btnStaffShedule.Click += btnStaffShedule_Click;
            // 
            // btnInventoryManagment
            // 
            btnInventoryManagment.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnInventoryManagment.Location = new Point(6, 314);
            btnInventoryManagment.Name = "btnInventoryManagment";
            btnInventoryManagment.Size = new Size(247, 65);
            btnInventoryManagment.TabIndex = 0;
            btnInventoryManagment.Text = "Inventory Managment";
            btnInventoryManagment.UseVisualStyleBackColor = true;
            btnInventoryManagment.Click += btnInventoryManagment_Click;
            // 
            // btnMenuManagement
            // 
            btnMenuManagement.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnMenuManagement.Location = new Point(6, 243);
            btnMenuManagement.Name = "btnMenuManagement";
            btnMenuManagement.Size = new Size(247, 65);
            btnMenuManagement.TabIndex = 0;
            btnMenuManagement.Text = "Menu Management";
            btnMenuManagement.UseVisualStyleBackColor = true;
            btnMenuManagement.Click += btnMenuManagement_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerManagement.Location = new Point(6, 172);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(247, 65);
            btnCustomerManagement.TabIndex = 0;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = true;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1193, 559);
            Controls.Add(PanelDesktop);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "AdminForm";
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
        private Label lblDashboard;
        private Panel panel2;
        private Button btnStaffShedule;
        private Button btnAddStaffs;
    }
}