namespace MELTADO_CAFE.StaffAccess
{
    partial class FeedbackForm
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
            cmbCustomer = new ComboBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            nudRating = new NumericUpDown();
            txtComments = new TextBox();
            btnSubmitFeedback = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // cmbCustomer
            // 
            cmbCustomer.FlatStyle = FlatStyle.Popup;
            cmbCustomer.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(317, 170);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(220, 28);
            cmbCustomer.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // nudRating
            // 
            nudRating.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudRating.Location = new Point(317, 235);
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(220, 27);
            nudRating.TabIndex = 1;
            // 
            // txtComments
            // 
            txtComments.BorderStyle = BorderStyle.FixedSingle;
            txtComments.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComments.Location = new Point(172, 306);
            txtComments.Multiline = true;
            txtComments.Name = "txtComments";
            txtComments.Size = new Size(365, 154);
            txtComments.TabIndex = 2;
            // 
            // btnSubmitFeedback
            // 
            btnSubmitFeedback.BackColor = Color.PaleTurquoise;
            btnSubmitFeedback.FlatStyle = FlatStyle.Popup;
            btnSubmitFeedback.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitFeedback.Location = new Point(178, 514);
            btnSubmitFeedback.Name = "btnSubmitFeedback";
            btnSubmitFeedback.Size = new Size(229, 44);
            btnSubmitFeedback.TabIndex = 3;
            btnSubmitFeedback.Text = "Submit Feedback";
            btnSubmitFeedback.UseVisualStyleBackColor = false;
            btnSubmitFeedback.Click += btnSubmitFeedback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 35);
            label1.Name = "label1";
            label1.Size = new Size(412, 35);
            label1.TabIndex = 4;
            label1.Text = "Customer Feedback Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 173);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 5;
            label2.Text = "Customer  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(172, 237);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 5;
            label3.Text = "Rating (1-5)  :";
            // 
            // FeedbackForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 592);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmitFeedback);
            Controls.Add(txtComments);
            Controls.Add(nudRating);
            Controls.Add(cmbCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FeedbackForm";
            Text = "FeedbackForm";
            Load += FeedbackForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCustomer;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private NumericUpDown nudRating;
        private TextBox txtComments;
        private Button btnSubmitFeedback;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}