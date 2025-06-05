namespace MELTADO_CAFE
{
    partial class InventoryManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagementForm));
            dgvIngredients = new DataGridView();
            btnAdd = new Button();
            btnLowStock = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            labelDateTime = new Label();
            lblRecordCount = new Label();
            lblLowStockAlert = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvIngredients
            // 
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Location = new Point(122, 175);
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.RowHeadersWidth = 51;
            dgvIngredients.Size = new Size(857, 274);
            dgvIngredients.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(122, 477);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 44);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "➕ Add Ingredient";
            toolTip1.SetToolTip(btnAdd, "Add Stocks Here");
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLowStock
            // 
            btnLowStock.FlatStyle = FlatStyle.Popup;
            btnLowStock.Location = new Point(589, 477);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(146, 44);
            btnLowStock.TabIndex = 1;
            btnLowStock.Text = "🔔View Low Stock";
            toolTip1.SetToolTip(btnLowStock, "Low stock Indication Click here");
            btnLowStock.UseVisualStyleBackColor = true;
            btnLowStock.Click += btnLowStock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(344, 54);
            label1.Name = "label1";
            label1.Size = new Size(518, 32);
            label1.TabIndex = 2;
            label1.Text = "Inventory Management Dashboard";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(287, 477);
            button1.Name = "button1";
            button1.Size = new Size(141, 44);
            button1.TabIndex = 1;
            button1.Text = "✏️Edit Ingredient";
            toolTip1.SetToolTip(button1, "Update Stock Details Here");
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEdit_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(444, 477);
            button2.Name = "button2";
            button2.Size = new Size(128, 44);
            button2.TabIndex = 1;
            button2.Text = "📊 Adjust Stock";
            toolTip1.SetToolTip(button2, "Wastage adjustment click here");
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnAdjustStock_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(751, 477);
            button3.Name = "button3";
            button3.Size = new Size(95, 44);
            button3.TabIndex = 1;
            button3.Text = "🔄 Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnRefresh_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(862, 477);
            button4.Name = "button4";
            button4.Size = new Size(117, 44);
            button4.TabIndex = 1;
            button4.Text = "Print Report";
            toolTip1.SetToolTip(button4, "Print Available Stock Report Click Here");
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnPrintReport_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Location = new Point(29, 146);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(16, 20);
            labelDateTime.TabIndex = 4;
            labelDateTime.Text = "?";
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Location = new Point(29, 570);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(16, 20);
            lblRecordCount.TabIndex = 4;
            lblRecordCount.Text = "?";
            // 
            // lblLowStockAlert
            // 
            lblLowStockAlert.AutoSize = true;
            lblLowStockAlert.Location = new Point(886, 570);
            lblLowStockAlert.Name = "lblLowStockAlert";
            lblLowStockAlert.Size = new Size(16, 20);
            lblLowStockAlert.TabIndex = 4;
            lblLowStockAlert.Text = "?";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // InventoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1152, 623);
            Controls.Add(lblLowStockAlert);
            Controls.Add(lblRecordCount);
            Controls.Add(labelDateTime);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnLowStock);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(dgvIngredients);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryManagementForm";
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvIngredients;
        private Button btnAdd;
        private Button btnLowStock;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Label labelDateTime;
        private Label lblRecordCount;
        private Label lblLowStockAlert;
        private System.Windows.Forms.Timer timer1;
        private ToolTip toolTip1;
    }
}