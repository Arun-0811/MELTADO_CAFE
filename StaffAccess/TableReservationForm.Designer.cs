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
            txtCustomerName = new TextBox();
            comboBoxTable = new ComboBox();
            timePicker = new DateTimePicker();
            numPartySize = new NumericUpDown();
            btnReserve = new Button();
            txtContactNumber = new TextBox();
            datePicker = new DateTimePicker();
            groupbox_ReservInputSec = new GroupBox();
            cmb_tableStatus = new TextBox();
            dataGridReservations = new DataGridView();
            btnCancel = new Button();
            btnRefresh = new Button();
            btnUpdate = new Button();
            cmb_DietoryPreff = new ComboBox();
            groupBox_optionalDetails = new GroupBox();
            cmb_TimesOfDay = new ComboBox();
            cmb_Membershiptier = new ComboBox();
            txt_Cus_Address = new TextBox();
            txtMembercardNo = new TextBox();
            txt_crediPoint = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPartySize).BeginInit();
            groupbox_ReservInputSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReservations).BeginInit();
            groupBox_optionalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txt_crediPoint).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(43, 102);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(198, 31);
            txtCustomerName.TabIndex = 0;
            // 
            // comboBoxTable
            // 
            comboBoxTable.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTable.FormattingEnabled = true;
            comboBoxTable.Location = new Point(43, 40);
            comboBoxTable.Name = "comboBoxTable";
            comboBoxTable.Size = new Size(198, 33);
            comboBoxTable.TabIndex = 1;
            comboBoxTable.SelectedIndexChanged += comboBoxTable_SelectedIndexChanged;
            // 
            // timePicker
            // 
            timePicker.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timePicker.Location = new Point(43, 298);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(198, 30);
            timePicker.TabIndex = 2;
            // 
            // numPartySize
            // 
            numPartySize.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numPartySize.Location = new Point(43, 361);
            numPartySize.Name = "numPartySize";
            numPartySize.Size = new Size(197, 31);
            numPartySize.TabIndex = 3;
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(657, 414);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(198, 50);
            btnReserve.TabIndex = 4;
            btnReserve.Text = "Confirm Reservation";
            btnReserve.UseVisualStyleBackColor = true;
            btnReserve.Click += btnReserve_Click;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNumber.Location = new Point(43, 167);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(198, 31);
            txtContactNumber.TabIndex = 0;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePicker.Location = new Point(43, 231);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(198, 30);
            datePicker.TabIndex = 2;
            // 
            // groupbox_ReservInputSec
            // 
            groupbox_ReservInputSec.BackColor = Color.FromArgb(255, 192, 192);
            groupbox_ReservInputSec.Controls.Add(numPartySize);
            groupbox_ReservInputSec.Controls.Add(timePicker);
            groupbox_ReservInputSec.Controls.Add(datePicker);
            groupbox_ReservInputSec.Controls.Add(cmb_tableStatus);
            groupbox_ReservInputSec.Controls.Add(txtContactNumber);
            groupbox_ReservInputSec.Controls.Add(txtCustomerName);
            groupbox_ReservInputSec.Controls.Add(comboBoxTable);
            groupbox_ReservInputSec.Location = new Point(31, 123);
            groupbox_ReservInputSec.Name = "groupbox_ReservInputSec";
            groupbox_ReservInputSec.Size = new Size(283, 485);
            groupbox_ReservInputSec.TabIndex = 5;
            groupbox_ReservInputSec.TabStop = false;
            groupbox_ReservInputSec.Text = "Reservation Input Section";
            // 
            // cmb_tableStatus
            // 
            cmb_tableStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_tableStatus.Location = new Point(43, 424);
            cmb_tableStatus.Name = "cmb_tableStatus";
            cmb_tableStatus.Size = new Size(198, 31);
            cmb_tableStatus.TabIndex = 0;
            // 
            // dataGridReservations
            // 
            dataGridReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReservations.Location = new Point(657, 123);
            dataGridReservations.Name = "dataGridReservations";
            dataGridReservations.RowHeadersWidth = 51;
            dataGridReservations.Size = new Size(663, 244);
            dataGridReservations.TabIndex = 6;
            dataGridReservations.CellClick += dataGridReservations_CellClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(657, 494);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(198, 50);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Delete Reservation";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(911, 494);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(198, 50);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Clear Resarvation";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(911, 414);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(198, 50);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update Reservation";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmb_DietoryPreff
            // 
            cmb_DietoryPreff.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_DietoryPreff.FormattingEnabled = true;
            cmb_DietoryPreff.Location = new Point(29, 26);
            cmb_DietoryPreff.Name = "cmb_DietoryPreff";
            cmb_DietoryPreff.Size = new Size(226, 33);
            cmb_DietoryPreff.TabIndex = 1;
            cmb_DietoryPreff.SelectedIndexChanged += comboBoxTable_SelectedIndexChanged;
            // 
            // groupBox_optionalDetails
            // 
            groupBox_optionalDetails.BackColor = Color.FromArgb(255, 192, 192);
            groupBox_optionalDetails.Controls.Add(cmb_TimesOfDay);
            groupBox_optionalDetails.Controls.Add(cmb_Membershiptier);
            groupBox_optionalDetails.Controls.Add(cmb_DietoryPreff);
            groupBox_optionalDetails.Controls.Add(txt_Cus_Address);
            groupBox_optionalDetails.Controls.Add(txtMembercardNo);
            groupBox_optionalDetails.Controls.Add(txt_crediPoint);
            groupBox_optionalDetails.Location = new Point(332, 123);
            groupBox_optionalDetails.Name = "groupBox_optionalDetails";
            groupBox_optionalDetails.Size = new Size(289, 485);
            groupBox_optionalDetails.TabIndex = 7;
            groupBox_optionalDetails.TabStop = false;
            groupBox_optionalDetails.Text = "Optional Details";
            // 
            // cmb_TimesOfDay
            // 
            cmb_TimesOfDay.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_TimesOfDay.FormattingEnabled = true;
            cmb_TimesOfDay.Location = new Point(29, 361);
            cmb_TimesOfDay.Name = "cmb_TimesOfDay";
            cmb_TimesOfDay.Size = new Size(226, 33);
            cmb_TimesOfDay.TabIndex = 1;
            cmb_TimesOfDay.SelectedIndexChanged += comboBoxTable_SelectedIndexChanged;
            // 
            // cmb_Membershiptier
            // 
            cmb_Membershiptier.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_Membershiptier.FormattingEnabled = true;
            cmb_Membershiptier.Location = new Point(29, 86);
            cmb_Membershiptier.Name = "cmb_Membershiptier";
            cmb_Membershiptier.Size = new Size(226, 33);
            cmb_Membershiptier.TabIndex = 1;
            cmb_Membershiptier.SelectedIndexChanged += comboBoxTable_SelectedIndexChanged;
            // 
            // txt_Cus_Address
            // 
            txt_Cus_Address.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Cus_Address.Location = new Point(29, 210);
            txt_Cus_Address.Multiline = true;
            txt_Cus_Address.Name = "txt_Cus_Address";
            txt_Cus_Address.Size = new Size(226, 118);
            txt_Cus_Address.TabIndex = 0;
            // 
            // txtMembercardNo
            // 
            txtMembercardNo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMembercardNo.Location = new Point(29, 148);
            txtMembercardNo.Name = "txtMembercardNo";
            txtMembercardNo.Size = new Size(226, 31);
            txtMembercardNo.TabIndex = 0;
            // 
            // txt_crediPoint
            // 
            txt_crediPoint.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_crediPoint.Location = new Point(29, 424);
            txt_crediPoint.Name = "txt_crediPoint";
            txt_crediPoint.Size = new Size(226, 31);
            txt_crediPoint.TabIndex = 3;
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
            // TableReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1370, 633);
            Controls.Add(label1);
            Controls.Add(btnReserve);
            Controls.Add(groupBox_optionalDetails);
            Controls.Add(dataGridReservations);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(groupbox_ReservInputSec);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TableReservationForm";
            Text = "TableReservationForm";
            Load += TableReservationForm_Load;
            ((System.ComponentModel.ISupportInitialize)numPartySize).EndInit();
            groupbox_ReservInputSec.ResumeLayout(false);
            groupbox_ReservInputSec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReservations).EndInit();
            groupBox_optionalDetails.ResumeLayout(false);
            groupBox_optionalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txt_crediPoint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private DateTimePicker timePicker;
        private NumericUpDown numPartySize;
        private Button btnReserve;
        private TextBox txtContactNumber;
        private DateTimePicker datePicker;
        private GroupBox groupbox_ReservInputSec;
        private DataGridView dataGridReservations;
        private Button btnCancel;
        private Button btnRefresh;
        private Button btnUpdate;
        private ComboBox comboBoxTable;
        private ComboBox cmb_DietoryPreff;
        private GroupBox groupBox_optionalDetails;
        private ComboBox cmb_Membershiptier;
        private TextBox txt_Cus_Address;
        private TextBox txtMembercardNo;
        private NumericUpDown txt_crediPoint;
        private TextBox cmb_tableStatus;
        private ComboBox cmb_TimesOfDay;
        private Label label1;
    }
}