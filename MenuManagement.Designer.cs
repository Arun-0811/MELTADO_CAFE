namespace MELTADO_CAFE
{
    partial class MenuManagement
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
            txt_Description = new TextBox();
            cmb_Category = new ComboBox();
            picbox_upload = new PictureBox();
            btn_addItems = new Button();
            checkBox_AVAILABLITY = new CheckBox();
            txt_price = new TextBox();
            txt_ItemName = new TextBox();
            btn_uploadImage = new Button();
            MenuItems_gridView = new DataGridView();
            btn_saveItem = new Button();
            btn_deleteItem = new Button();
            btn_clearItems = new Button();
            btn_searchItems = new Button();
            btn_btn_menuitems = new Button();
            grpbox_cuscmbbox = new GroupBox();
            txt_categorycmblist = new TextBox();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            txtSearch = new TextBox();
            dataGridTables = new DataGridView();
            groupBox1 = new GroupBox();
            btn_clearTable = new Button();
            cmb_status = new ComboBox();
            btn_UpdateTable = new Button();
            btn_ADDTable = new Button();
            txtCapacity = new TextBox();
            txt_tablenumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picbox_upload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MenuItems_gridView).BeginInit();
            grpbox_cuscmbbox.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTables).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(33, 75);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(206, 64);
            txt_Description.TabIndex = 0;
            // 
            // cmb_Category
            // 
            cmb_Category.FormattingEnabled = true;
            cmb_Category.Location = new Point(33, 164);
            cmb_Category.Name = "cmb_Category";
            cmb_Category.Size = new Size(206, 28);
            cmb_Category.TabIndex = 1;
            // 
            // picbox_upload
            // 
            picbox_upload.Location = new Point(33, 272);
            picbox_upload.Name = "picbox_upload";
            picbox_upload.Size = new Size(206, 93);
            picbox_upload.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_upload.TabIndex = 2;
            picbox_upload.TabStop = false;
            // 
            // btn_addItems
            // 
            btn_addItems.BackColor = Color.ForestGreen;
            btn_addItems.FlatStyle = FlatStyle.Popup;
            btn_addItems.Location = new Point(315, 430);
            btn_addItems.Name = "btn_addItems";
            btn_addItems.Size = new Size(149, 44);
            btn_addItems.TabIndex = 3;
            btn_addItems.Text = "ADD";
            btn_addItems.UseVisualStyleBackColor = false;
            btn_addItems.Click += btn_addItems_Click;
            // 
            // checkBox_AVAILABLITY
            // 
            checkBox_AVAILABLITY.AutoSize = true;
            checkBox_AVAILABLITY.BackColor = Color.FromArgb(255, 192, 192);
            checkBox_AVAILABLITY.Location = new Point(33, 376);
            checkBox_AVAILABLITY.Name = "checkBox_AVAILABLITY";
            checkBox_AVAILABLITY.Size = new Size(126, 24);
            checkBox_AVAILABLITY.TabIndex = 4;
            checkBox_AVAILABLITY.Text = "For Availablity";
            checkBox_AVAILABLITY.UseVisualStyleBackColor = false;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(33, 224);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(206, 27);
            txt_price.TabIndex = 0;
            // 
            // txt_ItemName
            // 
            txt_ItemName.Location = new Point(33, 23);
            txt_ItemName.Name = "txt_ItemName";
            txt_ItemName.Size = new Size(206, 27);
            txt_ItemName.TabIndex = 0;
            // 
            // btn_uploadImage
            // 
            btn_uploadImage.Location = new Point(33, 418);
            btn_uploadImage.Name = "btn_uploadImage";
            btn_uploadImage.Size = new Size(133, 35);
            btn_uploadImage.TabIndex = 3;
            btn_uploadImage.Text = "Image Upload";
            btn_uploadImage.UseVisualStyleBackColor = true;
            btn_uploadImage.Click += btn_uploadImage_Click;
            // 
            // MenuItems_gridView
            // 
            MenuItems_gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MenuItems_gridView.Location = new Point(315, 174);
            MenuItems_gridView.Name = "MenuItems_gridView";
            MenuItems_gridView.RowHeadersWidth = 51;
            MenuItems_gridView.Size = new Size(634, 224);
            MenuItems_gridView.TabIndex = 5;
            MenuItems_gridView.CellClick += MenuItems_gridView_CellClick;
            // 
            // btn_saveItem
            // 
            btn_saveItem.BackColor = SystemColors.Highlight;
            btn_saveItem.FlatStyle = FlatStyle.Popup;
            btn_saveItem.Location = new Point(519, 432);
            btn_saveItem.Name = "btn_saveItem";
            btn_saveItem.Size = new Size(143, 42);
            btn_saveItem.TabIndex = 3;
            btn_saveItem.Text = "SAVE";
            btn_saveItem.UseVisualStyleBackColor = false;
            btn_saveItem.Click += btn_saveItem_Click;
            // 
            // btn_deleteItem
            // 
            btn_deleteItem.BackColor = Color.Red;
            btn_deleteItem.FlatStyle = FlatStyle.Popup;
            btn_deleteItem.Location = new Point(315, 516);
            btn_deleteItem.Name = "btn_deleteItem";
            btn_deleteItem.Size = new Size(149, 42);
            btn_deleteItem.TabIndex = 3;
            btn_deleteItem.Text = "DELETE";
            btn_deleteItem.UseVisualStyleBackColor = false;
            btn_deleteItem.Click += btn_deleteItem_Click;
            // 
            // btn_clearItems
            // 
            btn_clearItems.BackColor = SystemColors.Info;
            btn_clearItems.FlatStyle = FlatStyle.Popup;
            btn_clearItems.Location = new Point(519, 516);
            btn_clearItems.Name = "btn_clearItems";
            btn_clearItems.Size = new Size(143, 42);
            btn_clearItems.TabIndex = 3;
            btn_clearItems.Text = "CLEAR";
            btn_clearItems.UseVisualStyleBackColor = false;
            btn_clearItems.Click += btn_clearItems_Click;
            // 
            // btn_searchItems
            // 
            btn_searchItems.BackgroundImageLayout = ImageLayout.Center;
            btn_searchItems.FlatStyle = FlatStyle.Popup;
            btn_searchItems.Location = new Point(728, 608);
            btn_searchItems.Name = "btn_searchItems";
            btn_searchItems.Size = new Size(221, 42);
            btn_searchItems.TabIndex = 3;
            btn_searchItems.Text = "SEARCH";
            btn_searchItems.UseVisualStyleBackColor = true;
            btn_searchItems.Click += btn_searchItems_Click;
            // 
            // btn_btn_menuitems
            // 
            btn_btn_menuitems.Location = new Point(315, 99);
            btn_btn_menuitems.Name = "btn_btn_menuitems";
            btn_btn_menuitems.Size = new Size(203, 44);
            btn_btn_menuitems.TabIndex = 9;
            btn_btn_menuitems.Text = "Menu Items Load";
            btn_btn_menuitems.UseVisualStyleBackColor = true;
            btn_btn_menuitems.Click += btn_btn_menuitems_Click;
            // 
            // grpbox_cuscmbbox
            // 
            grpbox_cuscmbbox.BackColor = Color.FromArgb(255, 192, 192);
            grpbox_cuscmbbox.Controls.Add(txt_categorycmblist);
            grpbox_cuscmbbox.Location = new Point(693, 430);
            grpbox_cuscmbbox.Name = "grpbox_cuscmbbox";
            grpbox_cuscmbbox.Size = new Size(256, 79);
            grpbox_cuscmbbox.TabIndex = 8;
            grpbox_cuscmbbox.TabStop = false;
            grpbox_cuscmbbox.Text = "Menu Categories";
            // 
            // txt_categorycmblist
            // 
            txt_categorycmblist.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_categorycmblist.Location = new Point(15, 26);
            txt_categorycmblist.Name = "txt_categorycmblist";
            txt_categorycmblist.Size = new Size(215, 28);
            txt_categorycmblist.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(586, 99);
            button1.Name = "button1";
            button1.Size = new Size(203, 44);
            button1.TabIndex = 9;
            button1.Text = "Menu Categories Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_btn_categoryclickloaded_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(617, 24);
            label1.Name = "label1";
            label1.Size = new Size(297, 35);
            label1.TabIndex = 10;
            label1.Text = "Menu Managment";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(txt_ItemName);
            panel1.Controls.Add(txt_Description);
            panel1.Controls.Add(cmb_Category);
            panel1.Controls.Add(btn_uploadImage);
            panel1.Controls.Add(txt_price);
            panel1.Controls.Add(checkBox_AVAILABLITY);
            panel1.Controls.Add(picbox_upload);
            panel1.Location = new Point(12, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 471);
            panel1.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(728, 540);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 30);
            txtSearch.TabIndex = 6;
            // 
            // dataGridTables
            // 
            dataGridTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTables.Location = new Point(1039, 99);
            dataGridTables.Name = "dataGridTables";
            dataGridTables.RowHeadersWidth = 51;
            dataGridTables.Size = new Size(372, 203);
            dataGridTables.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(btn_clearTable);
            groupBox1.Controls.Add(cmb_status);
            groupBox1.Controls.Add(btn_UpdateTable);
            groupBox1.Controls.Add(btn_ADDTable);
            groupBox1.Controls.Add(txtCapacity);
            groupBox1.Controls.Add(txt_tablenumber);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1039, 331);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 262);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "List of Table available and Ststus";
            // 
            // btn_clearTable
            // 
            btn_clearTable.Location = new Point(237, 201);
            btn_clearTable.Name = "btn_clearTable";
            btn_clearTable.Size = new Size(83, 37);
            btn_clearTable.TabIndex = 8;
            btn_clearTable.Text = "CLEAR";
            btn_clearTable.UseVisualStyleBackColor = true;
            // 
            // cmb_status
            // 
            cmb_status.FormattingEnabled = true;
            cmb_status.Items.AddRange(new object[] { "Reserved", "Available", "OutOfService", "Cancelled" });
            cmb_status.Location = new Point(23, 142);
            cmb_status.Name = "cmb_status";
            cmb_status.Size = new Size(287, 33);
            cmb_status.TabIndex = 1;
            // 
            // btn_UpdateTable
            // 
            btn_UpdateTable.Location = new Point(131, 201);
            btn_UpdateTable.Name = "btn_UpdateTable";
            btn_UpdateTable.Size = new Size(85, 37);
            btn_UpdateTable.TabIndex = 8;
            btn_UpdateTable.Text = "UPDATE";
            btn_UpdateTable.UseVisualStyleBackColor = true;
            // 
            // btn_ADDTable
            // 
            btn_ADDTable.Location = new Point(23, 201);
            btn_ADDTable.Name = "btn_ADDTable";
            btn_ADDTable.Size = new Size(78, 37);
            btn_ADDTable.TabIndex = 8;
            btn_ADDTable.Text = "ADD";
            btn_ADDTable.UseVisualStyleBackColor = true;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(23, 92);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(287, 31);
            txtCapacity.TabIndex = 6;
            // 
            // txt_tablenumber
            // 
            txt_tablenumber.Location = new Point(23, 48);
            txt_tablenumber.Name = "txt_tablenumber";
            txt_tablenumber.Size = new Size(287, 31);
            txt_tablenumber.TabIndex = 7;
            // 
            // MenuManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1460, 705);
            Controls.Add(dataGridTables);
            Controls.Add(groupBox1);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btn_btn_menuitems);
            Controls.Add(grpbox_cuscmbbox);
            Controls.Add(MenuItems_gridView);
            Controls.Add(btn_searchItems);
            Controls.Add(btn_clearItems);
            Controls.Add(btn_deleteItem);
            Controls.Add(btn_saveItem);
            Controls.Add(btn_addItems);
            Controls.Add(panel1);
            Name = "MenuManagement";
            Text = "MenuManagement";
            ((System.ComponentModel.ISupportInitialize)picbox_upload).EndInit();
            ((System.ComponentModel.ISupportInitialize)MenuItems_gridView).EndInit();
            grpbox_cuscmbbox.ResumeLayout(false);
            grpbox_cuscmbbox.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTables).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Description;
        private ComboBox cmb_Category;
        private PictureBox picbox_upload;
        private Button btn_addItems;
        private CheckBox checkBox_AVAILABLITY;
        private TextBox txt_price;
        private TextBox txt_ItemName;
        private Button btn_uploadImage;
        private DataGridView MenuItems_gridView;
        private Button btn_saveItem;
        private Button btn_deleteItem;
        private Button btn_clearItems;
        private Button btn_searchItems;
        private Button btn_btn_menuitems;
        private GroupBox grpbox_cuscmbbox;
        private TextBox txt_categorycmblist;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private TextBox txtSearch;
        private DataGridView dataGridTables;
        private GroupBox groupBox1;
        private Button btn_clearTable;
        private ComboBox cmb_status;
        private Button btn_UpdateTable;
        private Button btn_ADDTable;
        private TextBox txtCapacity;
        private TextBox txt_tablenumber;
    }
}