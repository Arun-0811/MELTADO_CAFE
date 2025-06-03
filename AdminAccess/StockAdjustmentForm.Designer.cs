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
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(111, 216);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(16, 20);
            lblUnit.TabIndex = 0;
            lblUnit.Text = "?";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(419, 378);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(290, 101);
            txtNotes.TabIndex = 1;
            toolTip1.SetToolTip(txtNotes, "Here you ccan enter product wastage Commants");
            // 
            // cmbReason
            // 
            cmbReason.FormattingEnabled = true;
            cmbReason.Items.AddRange(new object[] { "Wastage/Spoilage", "Received Free Sample", "Inventory Count Error", "Theft/Loss", " Other" });
            cmbReason.Location = new Point(419, 314);
            cmbReason.Name = "cmbReason";
            cmbReason.Size = new Size(179, 28);
            cmbReason.TabIndex = 2;
            toolTip1.SetToolTip(cmbReason, "Select Reason Why this much wastage Occoured..!");
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(417, 265);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(181, 27);
            numQuantity.TabIndex = 3;
            toolTip1.SetToolTip(numQuantity, "number of quantity wasted...!");
            // 
            // rdoRemove
            // 
            rdoRemove.AutoSize = true;
            rdoRemove.Location = new Point(514, 214);
            rdoRemove.Name = "rdoRemove";
            rdoRemove.Size = new Size(124, 24);
            rdoRemove.TabIndex = 4;
            rdoRemove.TabStop = true;
            rdoRemove.Text = "Remove Stock";
            toolTip1.SetToolTip(rdoRemove, "remove wasteage stock ");
            rdoRemove.UseVisualStyleBackColor = true;
            // 
            // lblIngredient
            // 
            lblIngredient.AutoSize = true;
            lblIngredient.Location = new Point(416, 142);
            lblIngredient.Name = "lblIngredient";
            lblIngredient.Size = new Size(16, 20);
            lblIngredient.TabIndex = 0;
            lblIngredient.Text = "?";
            // 
            // rdoAdd
            // 
            rdoAdd.AutoSize = true;
            rdoAdd.Location = new Point(416, 214);
            rdoAdd.Name = "rdoAdd";
            rdoAdd.Size = new Size(98, 24);
            rdoAdd.TabIndex = 4;
            rdoAdd.TabStop = true;
            rdoAdd.Text = "Add Stock";
            toolTip1.SetToolTip(rdoAdd, "Product Came for trial Purposses");
            rdoAdd.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(416, 536);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(569, 536);
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
            lblWarning.Location = new Point(111, 265);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(16, 20);
            lblWarning.TabIndex = 0;
            lblWarning.Text = "?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 16);
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
            label1.Location = new Point(257, 28);
            label1.Name = "label1";
            label1.Size = new Size(555, 32);
            label1.TabIndex = 6;
            label1.Text = "Stock Adjustment / Spoiled / Wastage";
            // 
            // StockAdjustmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 588);
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
    }
}