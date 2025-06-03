namespace MELTADO_CAFE
{
    partial class TableReservationForm
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
            comboBoxTable = new ComboBox();
            timePicker = new DateTimePicker();
            numPartySize = new NumericUpDown();
            btnReserve = new Button();
            datePicker = new DateTimePicker();
            groupbox_ReservInputSec = new GroupBox();
            cmb_TimesOfDay = new ComboBox();
            cmb_tableStatus = new ComboBox();
            comboBoxCustomer = new ComboBox();
            dataGridReservations = new DataGridView();
            btnCancel = new Button();
            btnRefresh = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            btnRefreshGrid = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPartySize).BeginInit();
            groupbox_ReservInputSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReservations).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTable
            // 
            comboBoxTable.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTable.Font = new Font("Georgia", 10.2F);
            comboBoxTable.FormattingEnabled = true;
            comboBoxTable.Location = new Point(194, 36);
            comboBoxTable.Name = "comboBoxTable";
            comboBoxTable.Size = new Size(198, 28);
            comboBoxTable.TabIndex = 1;
            comboBoxTable.SelectedIndexChanged += comboBoxTable_SelectedIndexChanged;
            // 
            // timePicker
            // 
            timePicker.Font = new Font("Georgia", 10.2F);
            timePicker.Location = new Point(193, 231);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(198, 27);
            timePicker.TabIndex = 2;
            // 
            // numPartySize
            // 
            numPartySize.Font = new Font("Georgia", 10.2F);
            numPartySize.Location = new Point(193, 294);
            numPartySize.Name = "numPartySize";
            numPartySize.Size = new Size(197, 27);
            numPartySize.TabIndex = 3;
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(510, 410);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(198, 50);
            btnReserve.TabIndex = 4;
            btnReserve.Text = "Confirm Reservation";
            btnReserve.UseVisualStyleBackColor = true;
            btnReserve.Click += btnReserve_Click;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Georgia", 10.2F);
            datePicker.Location = new Point(193, 164);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(198, 27);
            datePicker.TabIndex = 2;
            // 
            // groupbox_ReservInputSec
            // 
            groupbox_ReservInputSec.BackColor = Color.FromArgb(255, 192, 192);
            groupbox_ReservInputSec.Controls.Add(label7);
            groupbox_ReservInputSec.Controls.Add(label6);
            groupbox_ReservInputSec.Controls.Add(label5);
            groupbox_ReservInputSec.Controls.Add(label4);
            groupbox_ReservInputSec.Controls.Add(label3);
            groupbox_ReservInputSec.Controls.Add(label2);
            groupbox_ReservInputSec.Controls.Add(label9);
            groupbox_ReservInputSec.Controls.Add(cmb_TimesOfDay);
            groupbox_ReservInputSec.Controls.Add(numPartySize);
            groupbox_ReservInputSec.Controls.Add(timePicker);
            groupbox_ReservInputSec.Controls.Add(datePicker);
            groupbox_ReservInputSec.Controls.Add(cmb_tableStatus);
            groupbox_ReservInputSec.Controls.Add(comboBoxCustomer);
            groupbox_ReservInputSec.Controls.Add(comboBoxTable);
            groupbox_ReservInputSec.Location = new Point(55, 123);
            groupbox_ReservInputSec.Name = "groupbox_ReservInputSec";
            groupbox_ReservInputSec.Size = new Size(423, 485);
            groupbox_ReservInputSec.TabIndex = 5;
            groupbox_ReservInputSec.TabStop = false;
            groupbox_ReservInputSec.Text = "Reservation Input Section";
            // 
            // cmb_TimesOfDay
            // 
            cmb_TimesOfDay.Font = new Font("Georgia", 10.2F);
            cmb_TimesOfDay.FormattingEnabled = true;
            cmb_TimesOfDay.Location = new Point(192, 418);
            cmb_TimesOfDay.Name = "cmb_TimesOfDay";
            cmb_TimesOfDay.Size = new Size(200, 28);
            cmb_TimesOfDay.TabIndex = 1;
            cmb_TimesOfDay.SelectedIndexChanged += comboBoxTable_SelectedIndexChanged;
            // 
            // cmb_tableStatus
            // 
            cmb_tableStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_tableStatus.Font = new Font("Georgia", 10.2F);
            cmb_tableStatus.FormattingEnabled = true;
            cmb_tableStatus.Items.AddRange(new object[] { "Confirmed", "Pending", "Cancelled", "Completed", "No-Show", "Seated", "Rescheduled" });
            cmb_tableStatus.Location = new Point(192, 357);
            cmb_tableStatus.Name = "cmb_tableStatus";
            cmb_tableStatus.Size = new Size(198, 28);
            cmb_tableStatus.TabIndex = 1;
            cmb_tableStatus.SelectedIndexChanged += comboBoxTable_SelectedIndexChanged;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.Font = new Font("Georgia", 10.2F);
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(193, 98);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(198, 28);
            comboBoxCustomer.TabIndex = 1;
            comboBoxCustomer.SelectedIndexChanged += comboBoxTable_SelectedIndexChanged;
            // 
            // dataGridReservations
            // 
            dataGridReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReservations.Location = new Point(510, 119);
            dataGridReservations.Name = "dataGridReservations";
            dataGridReservations.RowHeadersWidth = 51;
            dataGridReservations.Size = new Size(663, 198);
            dataGridReservations.TabIndex = 6;
            dataGridReservations.CellClick += dataGridReservations_CellClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(510, 490);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(198, 50);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Delete Reservation";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(764, 490);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(198, 50);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Clear Resarvation";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(764, 410);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(198, 50);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update Reservation";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(560, 27);
            label1.Name = "label1";
            label1.Size = new Size(295, 35);
            label1.TabIndex = 8;
            label1.Text = "Table Reservation";
            // 
            // btnRefreshGrid
            // 
            btnRefreshGrid.Location = new Point(1067, 337);
            btnRefreshGrid.Name = "btnRefreshGrid";
            btnRefreshGrid.Size = new Size(106, 43);
            btnRefreshGrid.TabIndex = 4;
            btnRefreshGrid.Text = "REFRESH";
            btnRefreshGrid.UseVisualStyleBackColor = true;
            btnRefreshGrid.Click += btnRefreshGrid_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(510, 329);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 43);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(639, 341);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(226, 31);
            txtSearch.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 10.2F);
            label9.Location = new Point(86, 44);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 8;
            label9.Text = "Table  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F);
            label2.Location = new Point(56, 106);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 8;
            label2.Text = "Customer  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F);
            label3.Location = new Point(56, 171);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 8;
            label3.Text = "Book Date  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F);
            label4.Location = new Point(53, 236);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 8;
            label4.Text = "Book Time  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F);
            label5.Location = new Point(31, 301);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 8;
            label5.Text = "Seat Capacity  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.2F);
            label6.Location = new Point(39, 360);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 8;
            label6.Text = "Table Status  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.2F);
            label7.Location = new Point(6, 426);
            label7.Name = "label7";
            label7.Size = new Size(150, 20);
            label7.TabIndex = 8;
            label7.Text = "Time Of Booking  :";
            // 
            // TableReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1370, 633);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(btnRefreshGrid);
            Controls.Add(btnReserve);
            Controls.Add(txtSearch);
            Controls.Add(dataGridReservations);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(groupbox_ReservInputSec);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TableReservationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableReservationForm";
            Load += TableReservationForm_Load;
            ((System.ComponentModel.ISupportInitialize)numPartySize).EndInit();
            groupbox_ReservInputSec.ResumeLayout(false);
            groupbox_ReservInputSec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker timePicker;
        private NumericUpDown numPartySize;
        private Button btnReserve;
        private DateTimePicker datePicker;
        private GroupBox groupbox_ReservInputSec;
        private DataGridView dataGridReservations;
        private Button btnCancel;
        private Button btnRefresh;
        private Button btnUpdate;
        private ComboBox comboBoxTable;
        private ComboBox cmb_TimesOfDay;
        private Label label1;
        private ComboBox comboBoxCustomer;
        private Button btnRefreshGrid;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cmb_tableStatus;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}