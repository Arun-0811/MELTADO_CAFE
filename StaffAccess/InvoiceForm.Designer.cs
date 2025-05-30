namespace MELTADO_CAFE
{
    partial class InvoiceForm
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
            lblSubtotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            lblInvoiceTitle = new Label();
            lblDate = new Label();
            lblStatus = new Label();
            dgvItems = new DataGridView();
            dgvPayments = new DataGridView();
            dgvHeader = new DataGridView();
            btnPrint = new Button();
            btnMarkAsPaid = new Button();
            btnClose = new Button();
            lblInvoiceGeneration = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHeader).BeginInit();
            SuspendLayout();
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(34, 808);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(16, 20);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "?";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(34, 862);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(16, 20);
            lblTax.TabIndex = 0;
            lblTax.Text = "?";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(34, 904);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(16, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "?";
            // 
            // lblInvoiceTitle
            // 
            lblInvoiceTitle.AutoSize = true;
            lblInvoiceTitle.Location = new Point(34, 107);
            lblInvoiceTitle.Name = "lblInvoiceTitle";
            lblInvoiceTitle.Size = new Size(16, 20);
            lblInvoiceTitle.TabIndex = 0;
            lblInvoiceTitle.Text = "?";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(34, 155);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(16, 20);
            lblDate.TabIndex = 0;
            lblDate.Text = "?";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(1214, 107);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "?";
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(34, 522);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(626, 238);
            dgvItems.TabIndex = 1;
            // 
            // dgvPayments
            // 
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Location = new Point(703, 522);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.Size = new Size(1061, 238);
            dgvPayments.TabIndex = 1;
            // 
            // dgvHeader
            // 
            dgvHeader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHeader.Location = new Point(34, 223);
            dgvHeader.Name = "dgvHeader";
            dgvHeader.RowHeadersWidth = 51;
            dgvHeader.Size = new Size(1730, 251);
            dgvHeader.TabIndex = 1;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(534, 796);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(126, 47);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnMarkAsPaid
            // 
            btnMarkAsPaid.Font = new Font("Georgia", 12F);
            btnMarkAsPaid.Location = new Point(703, 796);
            btnMarkAsPaid.Name = "btnMarkAsPaid";
            btnMarkAsPaid.Size = new Size(212, 47);
            btnMarkAsPaid.TabIndex = 2;
            btnMarkAsPaid.Text = "Mark As Paid";
            btnMarkAsPaid.UseVisualStyleBackColor = true;
            btnMarkAsPaid.Click += btnMarkAsPaid_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Georgia", 12F);
            btnClose.Location = new Point(534, 879);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(132, 47);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblInvoiceGeneration
            // 
            lblInvoiceGeneration.AutoSize = true;
            lblInvoiceGeneration.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInvoiceGeneration.ForeColor = Color.FromArgb(128, 64, 0);
            lblInvoiceGeneration.Location = new Point(598, 29);
            lblInvoiceGeneration.Name = "lblInvoiceGeneration";
            lblInvoiceGeneration.Size = new Size(392, 35);
            lblInvoiceGeneration.TabIndex = 0;
            lblInvoiceGeneration.Text = "INVOICE GENERATION";
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1843, 1055);
            Controls.Add(btnClose);
            Controls.Add(btnMarkAsPaid);
            Controls.Add(btnPrint);
            Controls.Add(dgvHeader);
            Controls.Add(dgvPayments);
            Controls.Add(dgvItems);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(lblStatus);
            Controls.Add(lblDate);
            Controls.Add(lblInvoiceGeneration);
            Controls.Add(lblInvoiceTitle);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHeader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private Label lblInvoiceTitle;
        private Label lblDate;
        private Label lblStatus;
        private DataGridView dgvItems;
        private DataGridView dgvPayments;
        private DataGridView dgvHeader;
        private Button btnPrint;
        private Button btnMarkAsPaid;
        private Button btnClose;
        private Label lblInvoiceGeneration;
    }
}