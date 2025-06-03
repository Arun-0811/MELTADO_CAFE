namespace MELTADO_CAFE.StaffAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            dgvInvoiceItems = new DataGridView();
            lblInvoiceNo = new Label();
            lblOrderDate = new Label();
            lblCustomerName = new Label();
            lblTableID = new Label();
            lblPaymentMethod = new Label();
            lblOrderStatus = new Label();
            label1 = new Label();
            label2 = new Label();
            TableID = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblSubTotal = new Label();
            lblTaxPercentage = new Label();
            lblDiscount = new Label();
            lblgrandTotal = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBoxLogo = new PictureBox();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnSaveInvoice = new Button();
            btnPrintInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // dgvInvoiceItems
            // 
            dgvInvoiceItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceItems.Location = new Point(71, 275);
            dgvInvoiceItems.Name = "dgvInvoiceItems";
            dgvInvoiceItems.RowHeadersWidth = 51;
            dgvInvoiceItems.Size = new Size(557, 117);
            dgvInvoiceItems.TabIndex = 0;
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceNo.Location = new Point(398, 129);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(17, 20);
            lblInvoiceNo.TabIndex = 1;
            lblInvoiceNo.Text = "?";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDate.Location = new Point(398, 170);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(17, 20);
            lblOrderDate.TabIndex = 1;
            lblOrderDate.Text = "?";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(168, 223);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(17, 20);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "?";
            // 
            // lblTableID
            // 
            lblTableID.AutoSize = true;
            lblTableID.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTableID.Location = new Point(495, 223);
            lblTableID.Name = "lblTableID";
            lblTableID.Size = new Size(17, 20);
            lblTableID.TabIndex = 1;
            lblTableID.Text = "?";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMethod.Location = new Point(144, 449);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(17, 20);
            lblPaymentMethod.TabIndex = 1;
            lblPaymentMethod.Text = "?";
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderStatus.Location = new Point(144, 500);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(17, 20);
            lblOrderStatus.TabIndex = 1;
            lblOrderStatus.Text = "?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(447, 66);
            label1.Name = "label1";
            label1.Size = new Size(157, 35);
            label1.TabIndex = 1;
            label1.Text = "INVOICE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 223);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer :";
            // 
            // TableID
            // 
            TableID.AutoSize = true;
            TableID.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableID.Location = new Point(398, 223);
            TableID.Name = "TableID";
            TableID.Size = new Size(85, 20);
            TableID.TabIndex = 1;
            TableID.Text = "Table ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(367, 415);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 1;
            label3.Text = "Subtotal :         ₹";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(403, 449);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 1;
            label4.Text = "Tax :         ₹";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(367, 486);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 1;
            label5.Text = "Discount :        ₹";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(324, 524);
            label6.Name = "label6";
            label6.Size = new Size(172, 20);
            label6.TabIndex = 1;
            label6.Text = "Grand Total :        ₹";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(501, 415);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(17, 20);
            lblSubTotal.TabIndex = 1;
            lblSubTotal.Text = "?";
            // 
            // lblTaxPercentage
            // 
            lblTaxPercentage.AutoSize = true;
            lblTaxPercentage.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaxPercentage.Location = new Point(501, 449);
            lblTaxPercentage.Name = "lblTaxPercentage";
            lblTaxPercentage.Size = new Size(17, 20);
            lblTaxPercentage.TabIndex = 1;
            lblTaxPercentage.Text = "?";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(501, 486);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(17, 20);
            lblDiscount.TabIndex = 1;
            lblDiscount.Text = "?";
            // 
            // lblgrandTotal
            // 
            lblgrandTotal.AutoSize = true;
            lblgrandTotal.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblgrandTotal.Location = new Point(502, 524);
            lblgrandTotal.Name = "lblgrandTotal";
            lblgrandTotal.Size = new Size(17, 20);
            lblgrandTotal.TabIndex = 1;
            lblgrandTotal.Text = "?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(267, 129);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 1;
            label8.Text = "Invoice #: INV-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(334, 170);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 1;
            label9.Text = "Date : ";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(46, 69);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(155, 128);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 449);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 1;
            label7.Text = "Pay Mode :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(71, 500);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 1;
            label10.Text = "Status :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(144, 615);
            label11.Name = "label11";
            label11.Size = new Size(328, 32);
            label11.TabIndex = 1;
            label11.Text = "Thank You for Visiting...!";
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Location = new Point(39, 733);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(146, 42);
            btnSaveInvoice.TabIndex = 3;
            btnSaveInvoice.Text = "Insert to Database";
            btnSaveInvoice.UseVisualStyleBackColor = true;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.Location = new Point(246, 733);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(146, 42);
            btnPrintInvoice.TabIndex = 3;
            btnPrintInvoice.Text = "Print Invoice";
            btnPrintInvoice.UseVisualStyleBackColor = true;
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(662, 834);
            Controls.Add(btnPrintInvoice);
            Controls.Add(btnSaveInvoice);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(lblOrderStatus);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(lblSubTotal);
            Controls.Add(lblgrandTotal);
            Controls.Add(lblDiscount);
            Controls.Add(lblTaxPercentage);
            Controls.Add(label7);
            Controls.Add(lblPaymentMethod);
            Controls.Add(TableID);
            Controls.Add(lblTableID);
            Controls.Add(label2);
            Controls.Add(lblCustomerName);
            Controls.Add(label9);
            Controls.Add(lblOrderDate);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(lblInvoiceNo);
            Controls.Add(dgvInvoiceItems);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInvoiceItems;
        private Label lblInvoiceNo;
        private Label lblOrderDate;
        private Label lblCustomerName;
        private Label lblTableID;
        private Label lblPaymentMethod;
        private Label lblOrderStatus;
        private Label lblGrandTotal;
        private Label label1;
        private Label label2;
        private Label TableID;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblSubTotal;
        private Label lblTaxPercentage;
        private Label lblDiscount;
        private Label lblgrandTotal;
        private Label label8;
        private Label label9;
        private PictureBox pictureBoxLogo;
        private Label label7;
        private Label label10;
        private Label label11;
        private Button btnSaveInvoice;
        private Button btnPrintInvoice;
        //private Label lblGrandTotal;
    }
}