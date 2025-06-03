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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblOrderId = new Label();
            lblOrderDate = new Label();
            grpbox_custOrderDetails = new GroupBox();
            txtCustomerName = new TextBox();
            txtTableNumber = new TextBox();
            comboBoxReservation = new ComboBox();
            comboBoxOrderStatus = new ComboBox();
            comboBoxPaymentMethod = new ComboBox();
            label3 = new Label();
            lbl_selectPaymethod = new Label();
            btnAddToCart = new Button();
            dgvMenuItems = new DataGridView();
            btn_RemoveItem = new Button();
            txtSearchItems = new TextBox();
            btnSearchBocItems = new Button();
            dataGridOrderItems = new DataGridView();
            btnClearAll = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            txtGrandTotal = new TextBox();
            groupBox1 = new GroupBox();
            numericUpDownQuantity = new NumericUpDown();
            txtMenuItem = new TextBox();
            txtPhone = new TextBox();
            txtUnitPrice = new TextBox();
            btnSaveOrder = new Button();
            grpbox_custOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrderItems).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
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
            grpbox_custOrderDetails.Controls.Add(txtCustomerName);
            grpbox_custOrderDetails.Controls.Add(txtTableNumber);
            grpbox_custOrderDetails.Controls.Add(comboBoxReservation);
            grpbox_custOrderDetails.Controls.Add(comboBoxOrderStatus);
            grpbox_custOrderDetails.Controls.Add(comboBoxPaymentMethod);
            grpbox_custOrderDetails.Controls.Add(label3);
            grpbox_custOrderDetails.Controls.Add(lbl_selectPaymethod);
            grpbox_custOrderDetails.Location = new Point(20, 102);
            grpbox_custOrderDetails.Name = "grpbox_custOrderDetails";
            grpbox_custOrderDetails.Size = new Size(268, 412);
            grpbox_custOrderDetails.TabIndex = 2;
            grpbox_custOrderDetails.TabStop = false;
            grpbox_custOrderDetails.Text = "Orders";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(24, 177);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(214, 30);
            txtCustomerName.TabIndex = 2;
            // 
            // txtTableNumber
            // 
            txtTableNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTableNumber.Location = new Point(27, 106);
            txtTableNumber.Name = "txtTableNumber";
            txtTableNumber.ReadOnly = true;
            txtTableNumber.Size = new Size(212, 30);
            txtTableNumber.TabIndex = 2;
            // 
            // comboBoxReservation
            // 
            comboBoxReservation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReservation.FlatStyle = FlatStyle.Popup;
            comboBoxReservation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxReservation.FormattingEnabled = true;
            comboBoxReservation.Items.AddRange(new object[] { "Cash", "Card", "UPI" });
            comboBoxReservation.Location = new Point(22, 39);
            comboBoxReservation.Name = "comboBoxReservation";
            comboBoxReservation.Size = new Size(216, 31);
            comboBoxReservation.TabIndex = 1;
            comboBoxReservation.SelectedIndexChanged += comboBoxReservation_SelectedIndexChanged;
            // 
            // comboBoxOrderStatus
            // 
            comboBoxOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrderStatus.FlatStyle = FlatStyle.Popup;
            comboBoxOrderStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxOrderStatus.FormattingEnabled = true;
            comboBoxOrderStatus.Items.AddRange(new object[] { "Pending", "Completed", "Cancelled" });
            comboBoxOrderStatus.Location = new Point(29, 268);
            comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            comboBoxOrderStatus.Size = new Size(210, 31);
            comboBoxOrderStatus.TabIndex = 1;
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaymentMethod.FlatStyle = FlatStyle.Popup;
            comboBoxPaymentMethod.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPaymentMethod.FormattingEnabled = true;
            comboBoxPaymentMethod.Items.AddRange(new object[] { "Cash", "Card", "UPI" });
            comboBoxPaymentMethod.Location = new Point(27, 358);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(216, 31);
            comboBoxPaymentMethod.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 242);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 0;
            label3.Text = "Order Status";
            // 
            // lbl_selectPaymethod
            // 
            lbl_selectPaymethod.AutoSize = true;
            lbl_selectPaymethod.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_selectPaymethod.Location = new Point(27, 332);
            lbl_selectPaymethod.Name = "lbl_selectPaymethod";
            lbl_selectPaymethod.Size = new Size(191, 23);
            lbl_selectPaymethod.TabIndex = 0;
            lbl_selectPaymethod.Text = "Select Payment Method";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(333, 411);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(280, 36);
            btnAddToCart.TabIndex = 4;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // dgvMenuItems
            // 
            dgvMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuItems.Location = new Point(679, 108);
            dgvMenuItems.Name = "dgvMenuItems";
            dgvMenuItems.RowHeadersWidth = 51;
            dgvMenuItems.Size = new Size(300, 188);
            dgvMenuItems.TabIndex = 3;
            dgvMenuItems.CellClick += dgvMenuItems_CellClick;
            // 
            // btn_RemoveItem
            // 
            btn_RemoveItem.Location = new Point(518, 464);
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
            txtSearchItems.Location = new Point(1010, 108);
            txtSearchItems.Name = "txtSearchItems";
            txtSearchItems.Size = new Size(197, 30);
            txtSearchItems.TabIndex = 2;
            // 
            // btnSearchBocItems
            // 
            btnSearchBocItems.Location = new Point(1112, 152);
            btnSearchBocItems.Name = "btnSearchBocItems";
            btnSearchBocItems.Size = new Size(95, 36);
            btnSearchBocItems.TabIndex = 4;
            btnSearchBocItems.Text = "SEARCH";
            btnSearchBocItems.UseVisualStyleBackColor = true;
            btnSearchBocItems.Click += btnSearchBocItems_Click;
            // 
            // dataGridOrderItems
            // 
            dataGridOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrderItems.Location = new Point(679, 312);
            dataGridOrderItems.Name = "dataGridOrderItems";
            dataGridOrderItems.RowHeadersWidth = 51;
            dataGridOrderItems.Size = new Size(860, 188);
            dataGridOrderItems.TabIndex = 3;
            dataGridOrderItems.CellClick += dgvMenuItems_CellClick;
            dataGridOrderItems.CellValueChanged += dataGridOrderItems_CellValueChanged;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(1112, 214);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(95, 36);
            btnClearAll.TabIndex = 4;
            btnClearAll.Text = "CLEAR ALL";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1154, 539);
            label2.Name = "label2";
            label2.Size = new Size(193, 23);
            label2.TabIndex = 5;
            label2.Text = "Grand Total Amount :  ₹";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrandTotal.Location = new Point(1379, 534);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(159, 30);
            txtGrandTotal.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownQuantity);
            groupBox1.Controls.Add(txtMenuItem);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Location = new Point(333, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 275);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "OrderDetails";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownQuantity.Location = new Point(37, 210);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(209, 30);
            numericUpDownQuantity.TabIndex = 3;
            // 
            // txtMenuItem
            // 
            txtMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMenuItem.Location = new Point(34, 41);
            txtMenuItem.Name = "txtMenuItem";
            txtMenuItem.ReadOnly = true;
            txtMenuItem.Size = new Size(212, 30);
            txtMenuItem.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(34, 103);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(212, 30);
            txtPhone.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitPrice.Location = new Point(34, 152);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(212, 30);
            txtUnitPrice.TabIndex = 2;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(679, 539);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(145, 36);
            btnSaveOrder.TabIndex = 4;
            btnSaveOrder.Text = "Save Order";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // FormOrderProcessing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1703, 681);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnAddToCart);
            Controls.Add(groupBox1);
            Controls.Add(txtGrandTotal);
            Controls.Add(label2);
            Controls.Add(btnClearAll);
            Controls.Add(btnSearchBocItems);
            Controls.Add(btn_RemoveItem);
            Controls.Add(dataGridOrderItems);
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
            ((System.ComponentModel.ISupportInitialize)dataGridOrderItems).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblOrderId;
        private Label lblOrderDate;
        private GroupBox grpbox_custOrderDetails;
        private DataGridView dgvMenuItems;
        private Button btn_RemoveItem;
        private Button btnAddToCart;
        private ComboBox comboBoxPaymentMethod;
        private Label lbl_selectPaymethod;
        private TextBox txtSearchItems;
        private Button btnSearchBocItems;
        private TextBox txtTableNumber;
        private DataGridView dataGridOrderItems;
        private Button btnClearAll;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtCustomerName;
        private Label label2;
        private TextBox txtGrandTotal;
        private ComboBox comboBoxReservation;
        private ComboBox comboBoxOrderStatus;
        private GroupBox groupBox1;
        private TextBox txtUnitPrice;
        private NumericUpDown numericUpDownQuantity;
        private Button btnSaveOrder;
        private TextBox txtPhone;
        private TextBox txtMenuItem;
        private Label label3;
    }
}