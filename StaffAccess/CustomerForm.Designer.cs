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
            btnInventoryManagment = new Button();
            btnTableReservation = new Button();
            btnOrderProcessing = new Button();
            panel2 = new Panel();
            lblDashboard = new Label();
            PanelDesktop = new Panel();
            lblTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnInventoryManagment);
            panel1.Controls.Add(btnTableReservation);
            panel1.Controls.Add(btnOrderProcessing);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 533);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            // btnTableReservation
            // 
            btnTableReservation.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnTableReservation.Location = new Point(6, 243);
            btnTableReservation.Name = "btnTableReservation";
            btnTableReservation.Size = new Size(247, 65);
            btnTableReservation.TabIndex = 0;
            btnTableReservation.Text = "Table Reservation";
            btnTableReservation.UseVisualStyleBackColor = true;
            btnTableReservation.Click += btnTableReservation_Click;
            // 
            // btnOrderProcessing
            // 
            btnOrderProcessing.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderProcessing.Location = new Point(6, 172);
            btnOrderProcessing.Name = "btnOrderProcessing";
            btnOrderProcessing.Size = new Size(247, 65);
            btnOrderProcessing.TabIndex = 0;
            btnOrderProcessing.Text = "Order Processing";
            btnOrderProcessing.UseVisualStyleBackColor = true;
            btnOrderProcessing.Click += btnOrderProcessing_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(lblDashboard);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(256, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 87);
            panel2.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(168, 32);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(340, 35);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "STAFF DASHBOARD";
            // 
            // PanelDesktop
            // 
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(256, 87);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(994, 446);
            PanelDesktop.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(629, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "STAFF DASHBOARD";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 533);
            Controls.Add(PanelDesktop);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerForm";
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
        private Label lblDashboard;
        private Label lblTitle;
    }
}