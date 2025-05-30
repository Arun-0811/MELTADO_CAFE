namespace MELTADO_CAFE
{
    partial class FormOrderProcessing
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
            label1 = new Label();
            lblOrderId = new Label();
            lblOrderDate = new Label();
            grpbox_custOrderDetails = new GroupBox();
            txtTotalAmount = new TextBox();
            txtUniPrice = new TextBox();
            txtQTY = new TextBox();
            btn_itemADD = new Button();
            txtTableStatus = new TextBox();
            txt_ItemName = new TextBox();
            cmbPaymentMethod = new ComboBox();
            lbl_selectPaymethod = new Label();
            lblTtl = new Label();
            cmbTableNumber = new ComboBox();
            label2 = new Label();
            btnPlaceOrder = new Button();
            dgvMenuItems = new DataGridView();
            btn_RemoveItem = new Button();
            txtSearchItems = new TextBox();
            btnSearchBocItems = new Button();
            dataGridViewOrder = new DataGridView();
            btnClearAll = new Button();
            grpbox_custOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 29);
            label1.Name = "label1";
            label1.Size = new Size(442, 38);
            label1.TabIndex = 0;
            label1.Text = "Order Processing - Meltado Cafe";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderId.ForeColor = Color.Black;
            lblOrderId.Location = new Point(20, 41);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(121, 23);
            lblOrderId.TabIndex = 1;
            lblOrderId.Text = "Order ID: 1001";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDate.ForeColor = Color.Black;
            lblOrderDate.Location = new Point(814, 44);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(235, 23);
            lblOrderDate.TabIndex = 1;
            lblOrderDate.Text = "Order Date: 26/05/2025 15:04";
            // 
            // grpbox_custOrderDetails
            // 
            grpbox_custOrderDetails.Controls.Add(txtTotalAmount);
            grpbox_custOrderDetails.Controls.Add(txtUniPrice);
            grpbox_custOrderDetails.Controls.Add(txtQTY);
            grpbox_custOrderDetails.Controls.Add(btn_itemADD);
            grpbox_custOrderDetails.Controls.Add(txtTableStatus);
            grpbox_custOrderDetails.Controls.Add(txt_ItemName);
            grpbox_custOrderDetails.Controls.Add(cmbPaymentMethod);
            grpbox_custOrderDetails.Controls.Add(lbl_selectPaymethod);
            grpbox_custOrderDetails.Controls.Add(lblTtl);
            grpbox_custOrderDetails.Controls.Add(cmbTableNumber);
            grpbox_custOrderDetails.Controls.Add(label2);
            grpbox_custOrderDetails.Location = new Point(20, 89);
            grpbox_custOrderDetails.Name = "grpbox_custOrderDetails";
            grpbox_custOrderDetails.Size = new Size(251, 486);
            grpbox_custOrderDetails.TabIndex = 2;
            grpbox_custOrderDetails.TabStop = false;
            grpbox_custOrderDetails.Text = "Customer & Order Details";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(95, 301);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(125, 30);
            txtTotalAmount.TabIndex = 2;
            txtTotalAmount.Text = "0.00";
            // 
            // txtUniPrice
            // 
            txtUniPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUniPrice.Location = new Point(23, 252);
            txtUniPrice.Name = "txtUniPrice";
            txtUniPrice.ReadOnly = true;
            txtUniPrice.Size = new Size(197, 30);
            txtUniPrice.TabIndex = 2;
            // 
            // txtQTY
            // 
            txtQTY.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQTY.Location = new Point(23, 203);
            txtQTY.Name = "txtQTY";
            txtQTY.Size = new Size(197, 30);
            txtQTY.TabIndex = 2;
            txtQTY.TextChanged += txtQty_TextChanged;
            // 
            // btn_itemADD
            // 
            btn_itemADD.Location = new Point(27, 430);
            btn_itemADD.Name = "btn_itemADD";
            btn_itemADD.Size = new Size(196, 36);
            btn_itemADD.TabIndex = 4;
            btn_itemADD.Text = "ADD";
            btn_itemADD.UseVisualStyleBackColor = true;
            btn_itemADD.Click += btn_itemADD_Click;
            // 
            // txtTableStatus
            // 
            txtTableStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTableStatus.Location = new Point(26, 105);
            txtTableStatus.Name = "txtTableStatus";
            txtTableStatus.ReadOnly = true;
            txtTableStatus.Size = new Size(197, 30);
            txtTableStatus.TabIndex = 2;
            // 
            // txt_ItemName
            // 
            txt_ItemName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ItemName.Location = new Point(23, 155);
            txt_ItemName.Name = "txt_ItemName";
            txt_ItemName.Size = new Size(197, 30);
            txt_ItemName.TabIndex = 2;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.FlatStyle = FlatStyle.Popup;
            cmbPaymentMethod.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Card", "UPI" });
            cmbPaymentMethod.Location = new Point(23, 371);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(200, 31);
            cmbPaymentMethod.TabIndex = 1;
            // 
            // lbl_selectPaymethod
            // 
            lbl_selectPaymethod.AutoSize = true;
            lbl_selectPaymethod.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_selectPaymethod.Location = new Point(23, 345);
            lbl_selectPaymethod.Name = "lbl_selectPaymethod";
            lbl_selectPaymethod.Size = new Size(191, 23);
            lbl_selectPaymethod.TabIndex = 0;
            lbl_selectPaymethod.Text = "Select Payment Method";
            // 
            // lblTtl
            // 
            lblTtl.AutoSize = true;
            lblTtl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTtl.Location = new Point(24, 308);
            lblTtl.Name = "lblTtl";
            lblTtl.Size = new Size(69, 23);
            lblTtl.TabIndex = 0;
            lblTtl.Text = "Total:  ₹";
            // 
            // cmbTableNumber
            // 
            cmbTableNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTableNumber.FlatStyle = FlatStyle.Popup;
            cmbTableNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTableNumber.FormattingEnabled = true;
            cmbTableNumber.Location = new Point(20, 56);
            cmbTableNumber.Name = "cmbTableNumber";
            cmbTableNumber.Size = new Size(200, 31);
            cmbTableNumber.TabIndex = 1;
            cmbTableNumber.SelectedIndexChanged += cmbTableNumber_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 30);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 0;
            label2.Text = "Select Table";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlaceOrder.Location = new Point(635, 321);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(146, 36);
            btnPlaceOrder.TabIndex = 4;
            btnPlaceOrder.Text = "PLACE ORDER";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // dgvMenuItems
            // 
            dgvMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuItems.Location = new Point(299, 102);
            dgvMenuItems.Name = "dgvMenuItems";
            dgvMenuItems.RowHeadersWidth = 51;
            dgvMenuItems.Size = new Size(300, 188);
            dgvMenuItems.TabIndex = 3;
            dgvMenuItems.CellClick += dgvMenuItems_CellClick;
            // 
            // btn_RemoveItem
            // 
            btn_RemoveItem.Location = new Point(954, 321);
            btn_RemoveItem.Name = "btn_RemoveItem";
            btn_RemoveItem.Size = new Size(95, 36);
            btn_RemoveItem.TabIndex = 4;
            btn_RemoveItem.Text = "REMOVE";
            btn_RemoveItem.UseVisualStyleBackColor = true;
            btn_RemoveItem.Click += btn_RemoveItem_Click;
            // 
            // txtSearchItems
            // 
            txtSearchItems.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchItems.Location = new Point(402, 327);
            txtSearchItems.Name = "txtSearchItems";
            txtSearchItems.Size = new Size(197, 30);
            txtSearchItems.TabIndex = 2;
            // 
            // btnSearchBocItems
            // 
            btnSearchBocItems.Location = new Point(299, 327);
            btnSearchBocItems.Name = "btnSearchBocItems";
            btnSearchBocItems.Size = new Size(95, 36);
            btnSearchBocItems.TabIndex = 4;
            btnSearchBocItems.Text = "SEARCH";
            btnSearchBocItems.UseVisualStyleBackColor = true;
            btnSearchBocItems.Click += btnSearchBocItems_Click;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Location = new Point(635, 102);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.RowHeadersWidth = 51;
            dataGridViewOrder.Size = new Size(414, 188);
            dataGridViewOrder.TabIndex = 3;
            dataGridViewOrder.CellClick += dgvMenuItems_CellClick;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(299, 390);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(95, 36);
            btnClearAll.TabIndex = 4;
            btnClearAll.Text = "CLEAR ALL";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // FormOrderProcessing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1078, 587);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnClearAll);
            Controls.Add(btnSearchBocItems);
            Controls.Add(btn_RemoveItem);
            Controls.Add(dataGridViewOrder);
            Controls.Add(dgvMenuItems);
            Controls.Add(grpbox_custOrderDetails);
            Controls.Add(txtSearchItems);
            Controls.Add(lblOrderDate);
            Controls.Add(lblOrderId);
            Controls.Add(label1);
            ForeColor = Color.Navy;
            Location = new Point(350, 10);
            Name = "FormOrderProcessing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOrderProcessing";
            Load += FormOrderProcessing_Load;
            grpbox_custOrderDetails.ResumeLayout(false);
            grpbox_custOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblOrderId;
        private Label lblOrderDate;
        private GroupBox grpbox_custOrderDetails;
        private ComboBox cmbTableNumber;
        private Label label2;
        private DataGridView dgvMenuItems;
        private Button btn_RemoveItem;
        private TextBox txtTotalAmount;
        private TextBox txtUniPrice;
        private TextBox txtQTY;
        private TextBox txt_ItemName;
        private Button btn_itemADD;
        private ComboBox cmbPaymentMethod;
        private Label lbl_selectPaymethod;
        private Button btnPlaceOrder;
        private Label lblTtl;
        private TextBox txtSearchItems;
        private Button btnSearchBocItems;
        private TextBox txtTableStatus;
        private DataGridView dataGridViewOrder;
        private Button btnClearAll;
    }
}