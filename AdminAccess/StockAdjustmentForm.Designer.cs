namespace MELTADO_CAFE
{
    partial class StockAdjustmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockAdjustmentForm));
            lblUnit = new Label();
            txtNotes = new TextBox();
            cmbReason = new ComboBox();
            numQuantity = new NumericUpDown();
            rdoRemove = new RadioButton();
            lblIngredient = new Label();
            rdoAdd = new RadioButton();
            btnConfirm = new Button();
            btn_cancel = new Button();
            lblWarning = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            btn_close = new Button();
            btn_max = new Button();
            btn_min = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Georgia", 10.2F);
            lblUnit.Location = new Point(67, 242);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(17, 20);
            lblUnit.TabIndex = 0;
            lblUnit.Text = "?";
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Location = new Point(419, 403);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(383, 144);
            txtNotes.TabIndex = 1;
            toolTip1.SetToolTip(txtNotes, "Here you ccan enter product wastage Commants");
            // 
            // cmbReason
            // 
            cmbReason.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReason.FlatStyle = FlatStyle.Popup;
            cmbReason.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReason.FormattingEnabled = true;
            cmbReason.Items.AddRange(new object[] { "Wastage/Spoilage", "Received Free Sample", "Inventory Count Error", "Theft/Loss", " Other" });
            cmbReason.Location = new Point(419, 339);
            cmbReason.Name = "cmbReason";
            cmbReason.Size = new Size(229, 29);
            cmbReason.TabIndex = 2;
            toolTip1.SetToolTip(cmbReason, "Select Reason Why this much wastage Occoured..!");
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numQuantity.Location = new Point(417, 290);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(231, 28);
            numQuantity.TabIndex = 3;
            toolTip1.SetToolTip(numQuantity, "number of quantity wasted...!");
            // 
            // rdoRemove
            // 
            rdoRemove.AutoSize = true;
            rdoRemove.Font = new Font("Georgia", 10.8F);
            rdoRemove.Location = new Point(598, 239);
            rdoRemove.Name = "rdoRemove";
            rdoRemove.Size = new Size(145, 25);
            rdoRemove.TabIndex = 4;
            rdoRemove.TabStop = true;
            rdoRemove.Text = "Remove Stock";
            toolTip1.SetToolTip(rdoRemove, "remove wasteage stock ");
            rdoRemove.UseVisualStyleBackColor = true;
            // 
            // lblIngredient
            // 
            lblIngredient.AutoSize = true;
            lblIngredient.Font = new Font("Georgia", 10.2F);
            lblIngredient.Location = new Point(416, 167);
            lblIngredient.Name = "lblIngredient";
            lblIngredient.Size = new Size(17, 20);
            lblIngredient.TabIndex = 0;
            lblIngredient.Text = "?";
            // 
            // rdoAdd
            // 
            rdoAdd.AutoSize = true;
            rdoAdd.Font = new Font("Georgia", 10.8F);
            rdoAdd.Location = new Point(416, 239);
            rdoAdd.Name = "rdoAdd";
            rdoAdd.Size = new Size(111, 25);
            rdoAdd.TabIndex = 4;
            rdoAdd.TabStop = true;
            rdoAdd.Text = "Add Stock";
            toolTip1.SetToolTip(rdoAdd, "Product Came for trial Purposses");
            rdoAdd.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            btnConfirm.Location = new Point(419, 597);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.FlatStyle = FlatStyle.Popup;
            btn_cancel.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            btn_cancel.Location = new Point(572, 597);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Georgia", 10.2F);
            lblWarning.Location = new Point(67, 290);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(17, 20);
            lblWarning.TabIndex = 0;
            lblWarning.Text = "?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(205, 56);
            label1.Name = "label1";
            label1.Size = new Size(555, 32);
            label1.TabIndex = 6;
            label1.Text = "Stock Adjustment / Spoiled / Wastage";
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Popup;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.Location = new Point(931, 3);
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
            btn_max.Location = new Point(904, 3);
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
            btn_min.Location = new Point(877, 3);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(21, 19);
            btn_min.TabIndex = 16;
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            // 
            // StockAdjustmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(957, 661);
            Controls.Add(btn_close);
            Controls.Add(btn_max);
            Controls.Add(btn_min);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btn_cancel);
            Controls.Add(btnConfirm);
            Controls.Add(rdoAdd);
            Controls.Add(rdoRemove);
            Controls.Add(numQuantity);
            Controls.Add(cmbReason);
            Controls.Add(txtNotes);
            Controls.Add(lblIngredient);
            Controls.Add(lblWarning);
            Controls.Add(lblUnit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockAdjustmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockAdjustmentForm";
            Load += StockAdjustmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUnit;
        private TextBox txtNotes;
        private ComboBox cmbReason;
        private NumericUpDown numQuantity;
        private RadioButton rdoRemove;
        private Label lblIngredient;
        private RadioButton rdoAdd;
        private Button btnConfirm;
        private Button btn_cancel;
        private Label lblWarning;
        private PictureBox pictureBox1;
        private Label label1;
        private ToolTip toolTip1;
        private Button btn_close;
        private Button btn_max;
        private Button btn_min;
    }
}