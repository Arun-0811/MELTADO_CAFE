namespace MELTADO_CAFE
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnFeedback = new Button();
            btnInventoryManagment = new Button();
            btnCusDetails = new Button();
            btnCustomerDashboard = new Button();
            btnTableReservation = new Button();
            btnOrderProcessing = new Button();
            panel2 = new Panel();
            btn_close = new Button();
            lblTitle = new Label();
            btn_max = new Button();
            btn_min = new Button();
            PanelDesktop = new Panel();
            btnLogout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnFeedback);
            panel1.Controls.Add(btnInventoryManagment);
            panel1.Controls.Add(btnCusDetails);
            panel1.Controls.Add(btnCustomerDashboard);
            panel1.Controls.Add(btnTableReservation);
            panel1.Controls.Add(btnOrderProcessing);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 612);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = Color.FromArgb(255, 192, 192);
            btnFeedback.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnFeedback.Location = new Point(4, 484);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(228, 48);
            btnFeedback.TabIndex = 0;
            btnFeedback.Text = "Feeback Form";
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // btnInventoryManagment
            // 
            btnInventoryManagment.BackColor = Color.FromArgb(255, 192, 192);
            btnInventoryManagment.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnInventoryManagment.Location = new Point(4, 422);
            btnInventoryManagment.Name = "btnInventoryManagment";
            btnInventoryManagment.Size = new Size(228, 56);
            btnInventoryManagment.TabIndex = 0;
            btnInventoryManagment.Text = "Inventory Managment";
            btnInventoryManagment.UseVisualStyleBackColor = false;
            btnInventoryManagment.Click += btnInventoryManagment_Click;
            // 
            // btnCusDetails
            // 
            btnCusDetails.BackColor = Color.FromArgb(255, 192, 192);
            btnCusDetails.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnCusDetails.Location = new Point(7, 259);
            btnCusDetails.Name = "btnCusDetails";
            btnCusDetails.Size = new Size(225, 48);
            btnCusDetails.TabIndex = 0;
            btnCusDetails.Text = "Customer Details";
            btnCusDetails.UseVisualStyleBackColor = false;
            btnCusDetails.Click += btnCusDetails_Click;
            // 
            // btnCustomerDashboard
            // 
            btnCustomerDashboard.BackColor = Color.FromArgb(255, 192, 192);
            btnCustomerDashboard.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnCustomerDashboard.Location = new Point(6, 205);
            btnCustomerDashboard.Name = "btnCustomerDashboard";
            btnCustomerDashboard.Size = new Size(225, 48);
            btnCustomerDashboard.TabIndex = 0;
            btnCustomerDashboard.Text = "Staff Dashboard";
            btnCustomerDashboard.UseVisualStyleBackColor = false;
            btnCustomerDashboard.Click += btnCustomerDashboard_Click;
            // 
            // btnTableReservation
            // 
            btnTableReservation.BackColor = Color.FromArgb(255, 192, 192);
            btnTableReservation.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnTableReservation.Location = new Point(7, 313);
            btnTableReservation.Name = "btnTableReservation";
            btnTableReservation.Size = new Size(225, 48);
            btnTableReservation.TabIndex = 0;
            btnTableReservation.Text = "Table Reservation";
            btnTableReservation.UseVisualStyleBackColor = false;
            btnTableReservation.Click += btnTableReservation_Click;
            // 
            // btnOrderProcessing
            // 
            btnOrderProcessing.BackColor = Color.FromArgb(255, 192, 192);
            btnOrderProcessing.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderProcessing.Location = new Point(4, 367);
            btnOrderProcessing.Name = "btnOrderProcessing";
            btnOrderProcessing.Size = new Size(228, 49);
            btnOrderProcessing.TabIndex = 0;
            btnOrderProcessing.Text = "Order Processing";
            btnOrderProcessing.UseVisualStyleBackColor = false;
            btnOrderProcessing.Click += btnOrderProcessing_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(btn_close);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(btn_max);
            panel2.Controls.Add(btn_min);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(235, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1015, 61);
            panel2.TabIndex = 1;
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.BackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Popup;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.Location = new Point(989, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(21, 19);
            btn_close.TabIndex = 11;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 16.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(128, 64, 0);
            lblTitle.Location = new Point(378, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Staff Dashboard";
            // 
            // btn_max
            // 
            btn_max.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_max.BackColor = Color.Lime;
            btn_max.FlatStyle = FlatStyle.Popup;
            btn_max.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_max.Location = new Point(962, 3);
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
            btn_min.Location = new Point(935, 3);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(21, 19);
            btn_min.TabIndex = 13;
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            // 
            // PanelDesktop
            // 
            PanelDesktop.BackColor = Color.WhiteSmoke;
            PanelDesktop.BackgroundImage = (Image)resources.GetObject("PanelDesktop.BackgroundImage");
            PanelDesktop.BackgroundImageLayout = ImageLayout.Stretch;
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(235, 61);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(1015, 551);
            PanelDesktop.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.BackgroundImageLayout = ImageLayout.Center;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(138, 552);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 37);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1250, 612);
            Controls.Add(PanelDesktop);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnOrderProcessing;
        private Panel panel2;
        private Panel PanelDesktop;
        private PictureBox pictureBox1;
        private Button btnInventoryManagment;
        private Button btnTableReservation;
        private Label lblTitle;
        private Button btnFeedback;
        private Button btn_close;
        private Button btn_max;
        private Button btn_min;
        private Button btnCustomerDashboard;
        private Button btnCusDetails;
        private Button btnLogout;
    }
}