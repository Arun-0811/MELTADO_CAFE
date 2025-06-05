namespace MELTADO_CAFE
{
    partial class IngredientDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientDetailForm));
            btnCancel = new Button();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtSupplier = new TextBox();
            cmbUnit = new ComboBox();
            numCurrentStock = new NumericUpDown();
            chkActive = new CheckBox();
            numCost = new NumericUpDown();
            numReorderLevel = new NumericUpDown();
            lblStockStatus = new Label();
            toolTip1 = new ToolTip(components);
            btn_close = new Button();
            btn_max = new Button();
            btn_min = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCurrentStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReorderLevel).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(574, 570);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 32);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Location = new Point(305, 558);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(228, 44);
            btnSave.TabIndex = 3;
            btnSave.Text = "SAVE STOCK";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(305, 44);
            label1.Name = "label1";
            label1.Size = new Size(282, 32);
            label1.TabIndex = 5;
            label1.Text = "Ingredient Details ";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(305, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 31);
            txtName.TabIndex = 7;
            toolTip1.SetToolTip(txtName, "Ingreditent Name Enter Here");
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.None;
            txtDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(305, 192);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(230, 31);
            txtDescription.TabIndex = 7;
            toolTip1.SetToolTip(txtDescription, "Ingredient Description here");
            // 
            // txtSupplier
            // 
            txtSupplier.Anchor = AnchorStyles.None;
            txtSupplier.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplier.Location = new Point(305, 384);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(230, 31);
            txtSupplier.TabIndex = 7;
            toolTip1.SetToolTip(txtSupplier, "Enter Supplier Name for Future Communication");
            // 
            // cmbUnit
            // 
            cmbUnit.Anchor = AnchorStyles.None;
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.FlatStyle = FlatStyle.Popup;
            cmbUnit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(305, 286);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(230, 31);
            cmbUnit.TabIndex = 8;
            toolTip1.SetToolTip(cmbUnit, "Unit Measurement oif this stock");
            // 
            // numCurrentStock
            // 
            numCurrentStock.Anchor = AnchorStyles.None;
            numCurrentStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCurrentStock.Location = new Point(305, 238);
            numCurrentStock.Name = "numCurrentStock";
            numCurrentStock.Size = new Size(228, 30);
            numCurrentStock.TabIndex = 9;
            toolTip1.SetToolTip(numCurrentStock, "Currently Available Stock");
            numCurrentStock.ValueChanged += numCurrentStock_ValueChanged;
            // 
            // chkActive
            // 
            chkActive.Anchor = AnchorStyles.None;
            chkActive.AutoSize = true;
            chkActive.Location = new Point(310, 491);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(112, 24);
            chkActive.TabIndex = 10;
            chkActive.Text = "Active Stock";
            toolTip1.SetToolTip(chkActive, "Check if Stock is Active");
            chkActive.UseVisualStyleBackColor = true;
            // 
            // numCost
            // 
            numCost.Anchor = AnchorStyles.None;
            numCost.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCost.Location = new Point(305, 435);
            numCost.Name = "numCost";
            numCost.Size = new Size(228, 30);
            numCost.TabIndex = 9;
            toolTip1.SetToolTip(numCost, "Cost per quantity enter here");
            // 
            // numReorderLevel
            // 
            numReorderLevel.Anchor = AnchorStyles.None;
            numReorderLevel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numReorderLevel.Location = new Point(305, 334);
            numReorderLevel.Name = "numReorderLevel";
            numReorderLevel.Size = new Size(228, 30);
            numReorderLevel.TabIndex = 9;
            toolTip1.SetToolTip(numReorderLevel, "Low stock Indication Level");
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Location = new Point(108, 600);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(16, 20);
            lblStockStatus.TabIndex = 11;
            lblStockStatus.Text = "?";
            toolTip1.SetToolTip(lblStockStatus, "Current Stock Status");
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Popup;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.Location = new Point(825, 2);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(21, 19);
            btn_close.TabIndex = 14;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_max
            // 
            btn_max.BackColor = Color.Lime;
            btn_max.FlatStyle = FlatStyle.Popup;
            btn_max.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_max.Location = new Point(798, 2);
            btn_max.Name = "btn_max";
            btn_max.Size = new Size(21, 19);
            btn_max.TabIndex = 15;
            btn_max.UseVisualStyleBackColor = false;
            btn_max.Click += btn_max_Click;
            // 
            // btn_min
            // 
            btn_min.BackColor = Color.Yellow;
            btn_min.FlatStyle = FlatStyle.Popup;
            btn_min.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_min.Location = new Point(771, 2);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(21, 19);
            btn_min.TabIndex = 16;
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            // 
            // IngredientDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(848, 657);
            Controls.Add(btn_close);
            Controls.Add(btn_max);
            Controls.Add(btn_min);
            Controls.Add(lblStockStatus);
            Controls.Add(chkActive);
            Controls.Add(numReorderLevel);
            Controls.Add(numCost);
            Controls.Add(numCurrentStock);
            Controls.Add(cmbUnit);
            Controls.Add(txtSupplier);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IngredientDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IngredientDetailForm";
            Load += IngredientDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCurrentStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReorderLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtSupplier;
        private ComboBox cmbUnit;
        private NumericUpDown numCurrentStock;
        private CheckBox chkActive;
        private NumericUpDown numCost;
        private NumericUpDown numReorderLevel;
        private Label lblStockStatus;
        private ToolTip toolTip1;
        private Button btn_close;
        private Button btn_max;
        private Button btn_min;
    }
}