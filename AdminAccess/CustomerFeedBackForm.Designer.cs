namespace MELTADO_CAFE.AdminAccess
{
    partial class CustomerFeedBackForm
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
            dgvFeedback = new DataGridView();
            txtCustomerName = new TextBox();
            txtComments = new TextBox();
            button1 = new Button();
            label1 = new Label();
            btn_close = new Button();
            btn_max = new Button();
            btn_min = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFeedback).BeginInit();
            SuspendLayout();
            // 
            // dgvFeedback
            // 
            dgvFeedback.BorderStyle = BorderStyle.Fixed3D;
            dgvFeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeedback.Location = new Point(95, 161);
            dgvFeedback.Name = "dgvFeedback";
            dgvFeedback.RowHeadersWidth = 51;
            dgvFeedback.Size = new Size(886, 323);
            dgvFeedback.TabIndex = 0;
            dgvFeedback.CellClick += dgvFeedback_CellClick;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(225, 525);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(192, 28);
            txtCustomerName.TabIndex = 1;
            // 
            // txtComments
            // 
            txtComments.BorderStyle = BorderStyle.FixedSingle;
            txtComments.Font = new Font("Georgia", 10.8F);
            txtComments.Location = new Point(468, 525);
            txtComments.Multiline = true;
            txtComments.Name = "txtComments";
            txtComments.ReadOnly = true;
            txtComments.Size = new Size(513, 227);
            txtComments.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(225, 595);
            button1.Name = "button1";
            button1.Size = new Size(159, 38);
            button1.TabIndex = 2;
            button1.Text = "Clear Selection";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 51);
            label1.Name = "label1";
            label1.Size = new Size(435, 35);
            label1.TabIndex = 3;
            label1.Text = "Customer Feedback Details";
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.FlatStyle = FlatStyle.Popup;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.Location = new Point(1083, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(21, 19);
            btn_close.TabIndex = 11;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_max
            // 
            btn_max.BackColor = Color.Lime;
            btn_max.FlatStyle = FlatStyle.Popup;
            btn_max.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_max.Location = new Point(1056, 3);
            btn_max.Name = "btn_max";
            btn_max.Size = new Size(21, 19);
            btn_max.TabIndex = 12;
            btn_max.UseVisualStyleBackColor = false;
            btn_max.Click += btn_max_Click;
            // 
            // btn_min
            // 
            btn_min.BackColor = Color.Yellow;
            btn_min.FlatStyle = FlatStyle.Popup;
            btn_min.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_min.Location = new Point(1029, 3);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(21, 19);
            btn_min.TabIndex = 13;
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            // 
            // CustomerFeedBackForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1102, 798);
            Controls.Add(btn_close);
            Controls.Add(btn_max);
            Controls.Add(btn_min);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtComments);
            Controls.Add(txtCustomerName);
            Controls.Add(dgvFeedback);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerFeedBackForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerFeedBackForm";
            ((System.ComponentModel.ISupportInitialize)dgvFeedback).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFeedback;
        private TextBox txtCustomerName;
        private TextBox txtComments;
        private Button button1;
        private Label label1;
        private Button btn_close;
        private Button btn_max;
        private Button btn_min;
    }
}