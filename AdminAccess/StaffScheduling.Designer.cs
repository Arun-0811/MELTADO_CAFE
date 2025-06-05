namespace MELTADO_CAFE.AdminAccess
{
    partial class StaffScheduling
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
            btnSave = new Button();
            dataGridViewStaff = new DataGridView();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpHireDate = new DateTimePicker();
            dtpDateOfBirth = new DateTimePicker();
            cmbGender = new ComboBox();
            cmbUser = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            txtSearchStaff = new TextBox();
            btnSearchStaff = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cmbShift = new ComboBox();
            cmbStaff = new ComboBox();
            dtpScheduleDate = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btnSearchSchedule = new Button();
            dataGridViewSchedules = new DataGridView();
            txtSearchSchedule = new TextBox();
            groupBox3 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            cmbStaffAttendence = new ComboBox();
            dtpTimeOut = new DateTimePicker();
            txtNotes = new TextBox();
            dtpTimeIn = new DateTimePicker();
            dtpAttendanceDate = new DateTimePicker();
            txtSearchAttendance = new TextBox();
            dataGridViewAttendance = new DataGridView();
            btnSearchAttendance = new Button();
            button8 = new Button();
            button9 = new Button();
            btnSubmitAttendance = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedules).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(464, 299);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 39);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Location = new Point(466, 110);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.ReadOnly = true;
            dataGridViewStaff.RowHeadersWidth = 51;
            dataGridViewStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStaff.Size = new Size(385, 174);
            dataGridViewStaff.TabIndex = 3;
            dataGridViewStaff.CellClick += dataGridViewStaff_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(755, 299);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 39);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpHireDate);
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(cmbGender);
            groupBox1.Controls.Add(cmbUser);
            groupBox1.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(39, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 228);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Management";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 187);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 7;
            label5.Text = "Hire Date  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 134);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 7;
            label4.Text = "Date Of Birth  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 82);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 7;
            label3.Text = "Gender  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 30);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 7;
            label2.Text = "Staff  :";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(172, 182);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(190, 27);
            dtpHireDate.TabIndex = 5;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(172, 129);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(190, 27);
            dtpDateOfBirth.TabIndex = 6;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Morning Shift", "Afternoon Shift", "Evening Shift", "Night Shift" });
            cmbGender.Location = new Point(172, 74);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(190, 28);
            cmbGender.TabIndex = 3;
            // 
            // cmbUser
            // 
            cmbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUser.FormattingEnabled = true;
            cmbUser.Items.AddRange(new object[] { "Anitha R", "David Kumar", "Priya Menon", "Ravi Shankar" });
            cmbUser.Location = new Point(172, 27);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(190, 28);
            cmbUser.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            button1.Location = new Point(609, 299);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 0;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 32);
            label1.Name = "label1";
            label1.Size = new Size(339, 32);
            label1.TabIndex = 5;
            label1.Text = "Staff Shedule / Managment";
            // 
            // txtSearchStaff
            // 
            txtSearchStaff.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchStaff.Location = new Point(883, 114);
            txtSearchStaff.Name = "txtSearchStaff";
            txtSearchStaff.Size = new Size(193, 30);
            txtSearchStaff.TabIndex = 6;
            // 
            // btnSearchStaff
            // 
            btnSearchStaff.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStaff.Location = new Point(883, 169);
            btnSearchStaff.Name = "btnSearchStaff";
            btnSearchStaff.Size = new Size(94, 39);
            btnSearchStaff.TabIndex = 0;
            btnSearchStaff.Text = "Search";
            btnSearchStaff.UseVisualStyleBackColor = true;
            btnSearchStaff.Click += btnSearchStaff_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 192);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmbShift);
            groupBox2.Controls.Add(cmbStaff);
            groupBox2.Controls.Add(dtpScheduleDate);
            groupBox2.Font = new Font("Georgia", 10.2F);
            groupBox2.Location = new Point(42, 377);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 168);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Staff Scheduling";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 129);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 7;
            label8.Text = "Shift Time  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 79);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 7;
            label7.Text = "Schedule Date  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 33);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 7;
            label6.Text = "Staff  :";
            // 
            // cmbShift
            // 
            cmbShift.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShift.FormattingEnabled = true;
            cmbShift.Items.AddRange(new object[] { "Anitha R", "David Kumar", "Priya Menon", "Ravi Shankar" });
            cmbShift.Location = new Point(178, 126);
            cmbShift.Name = "cmbShift";
            cmbShift.Size = new Size(190, 28);
            cmbShift.TabIndex = 4;
            // 
            // cmbStaff
            // 
            cmbStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStaff.FormattingEnabled = true;
            cmbStaff.Items.AddRange(new object[] { "Anitha R", "David Kumar", "Priya Menon", "Ravi Shankar" });
            cmbStaff.Location = new Point(178, 25);
            cmbStaff.Name = "cmbStaff";
            cmbStaff.Size = new Size(190, 28);
            cmbStaff.TabIndex = 4;
            // 
            // dtpScheduleDate
            // 
            dtpScheduleDate.Location = new Point(178, 74);
            dtpScheduleDate.Name = "dtpScheduleDate";
            dtpScheduleDate.Size = new Size(190, 27);
            dtpScheduleDate.TabIndex = 6;
            // 
            // button3
            // 
            button3.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            button3.Location = new Point(883, 375);
            button3.Name = "button3";
            button3.Size = new Size(167, 39);
            button3.TabIndex = 0;
            button3.Text = "Assign Shedule ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnAssignSchedule_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            button4.Location = new Point(883, 431);
            button4.Name = "button4";
            button4.Size = new Size(167, 39);
            button4.TabIndex = 0;
            button4.Text = "Update Shedule ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnUpdateSchedule_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            button5.Location = new Point(883, 485);
            button5.Name = "button5";
            button5.Size = new Size(167, 39);
            button5.TabIndex = 0;
            button5.Text = "Delete Shedule ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnDeleteSchedule_Click;
            // 
            // btnSearchSchedule
            // 
            btnSearchSchedule.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            btnSearchSchedule.Location = new Point(756, 551);
            btnSearchSchedule.Name = "btnSearchSchedule";
            btnSearchSchedule.Size = new Size(94, 39);
            btnSearchSchedule.TabIndex = 0;
            btnSearchSchedule.Text = "Search";
            btnSearchSchedule.UseVisualStyleBackColor = true;
            btnSearchSchedule.Click += btnSearchSchedule_Click;
            // 
            // dataGridViewSchedules
            // 
            dataGridViewSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedules.Location = new Point(466, 377);
            dataGridViewSchedules.Name = "dataGridViewSchedules";
            dataGridViewSchedules.ReadOnly = true;
            dataGridViewSchedules.RowHeadersWidth = 51;
            dataGridViewSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSchedules.Size = new Size(385, 154);
            dataGridViewSchedules.TabIndex = 3;
            dataGridViewSchedules.CellClick += dataGridViewSchedules_CellClick;
            // 
            // txtSearchSchedule
            // 
            txtSearchSchedule.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchSchedule.Location = new Point(536, 560);
            txtSearchSchedule.Name = "txtSearchSchedule";
            txtSearchSchedule.Size = new Size(193, 30);
            txtSearchSchedule.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 192, 192);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cmbStaffAttendence);
            groupBox3.Controls.Add(dtpTimeOut);
            groupBox3.Controls.Add(txtNotes);
            groupBox3.Controls.Add(dtpTimeIn);
            groupBox3.Controls.Add(dtpAttendanceDate);
            groupBox3.Font = new Font("Georgia", 10.2F);
            groupBox3.Location = new Point(42, 613);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(368, 345);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = " Staff Attendance";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(52, 240);
            label13.Name = "label13";
            label13.Size = new Size(65, 20);
            label13.TabIndex = 7;
            label13.Text = "Notes  :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 184);
            label12.Name = "label12";
            label12.Size = new Size(94, 20);
            label12.TabIndex = 7;
            label12.Text = "Out Time  :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 135);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 7;
            label11.Text = "In Time  :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 83);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 7;
            label10.Text = "Atten. Date  :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 34);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 7;
            label9.Text = "Staff  :";
            // 
            // cmbStaffAttendence
            // 
            cmbStaffAttendence.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStaffAttendence.FormattingEnabled = true;
            cmbStaffAttendence.Items.AddRange(new object[] { "Anitha R", "David Kumar", "Priya Menon", "Ravi Shankar" });
            cmbStaffAttendence.Location = new Point(154, 26);
            cmbStaffAttendence.Name = "cmbStaffAttendence";
            cmbStaffAttendence.Size = new Size(190, 28);
            cmbStaffAttendence.TabIndex = 4;
            // 
            // dtpTimeOut
            // 
            dtpTimeOut.Location = new Point(154, 184);
            dtpTimeOut.Name = "dtpTimeOut";
            dtpTimeOut.Size = new Size(190, 27);
            dtpTimeOut.TabIndex = 6;
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(154, 235);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(190, 88);
            txtNotes.TabIndex = 6;
            // 
            // dtpTimeIn
            // 
            dtpTimeIn.Location = new Point(154, 128);
            dtpTimeIn.Name = "dtpTimeIn";
            dtpTimeIn.Size = new Size(190, 27);
            dtpTimeIn.TabIndex = 6;
            // 
            // dtpAttendanceDate
            // 
            dtpAttendanceDate.Location = new Point(154, 78);
            dtpAttendanceDate.Name = "dtpAttendanceDate";
            dtpAttendanceDate.Size = new Size(190, 27);
            dtpAttendanceDate.TabIndex = 6;
            // 
            // txtSearchAttendance
            // 
            txtSearchAttendance.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchAttendance.Location = new Point(881, 617);
            txtSearchAttendance.Name = "txtSearchAttendance";
            txtSearchAttendance.Size = new Size(193, 30);
            txtSearchAttendance.TabIndex = 14;
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Location = new Point(464, 613);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.ReadOnly = true;
            dataGridViewAttendance.RowHeadersWidth = 51;
            dataGridViewAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAttendance.Size = new Size(395, 260);
            dataGridViewAttendance.TabIndex = 13;
            dataGridViewAttendance.CellClick += dataGridViewAttendance_CellClick;
            // 
            // btnSearchAttendance
            // 
            btnSearchAttendance.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchAttendance.Location = new Point(881, 672);
            btnSearchAttendance.Name = "btnSearchAttendance";
            btnSearchAttendance.Size = new Size(94, 39);
            btnSearchAttendance.TabIndex = 9;
            btnSearchAttendance.Text = "Search";
            btnSearchAttendance.UseVisualStyleBackColor = true;
            btnSearchAttendance.Click += btnSearchAttendance_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            button8.Location = new Point(822, 907);
            button8.Name = "button8";
            button8.Size = new Size(153, 51);
            button8.TabIndex = 10;
            button8.Text = "Delete Attendence";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnDeleteAttendance_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            button9.Location = new Point(644, 907);
            button9.Name = "button9";
            button9.Size = new Size(158, 51);
            button9.TabIndex = 11;
            button9.Text = "Update Attendence";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnUpdateAttendance_Click;
            // 
            // btnSubmitAttendance
            // 
            btnSubmitAttendance.Font = new Font("Georgia", 10.2F, FontStyle.Bold);
            btnSubmitAttendance.Location = new Point(464, 907);
            btnSubmitAttendance.Name = "btnSubmitAttendance";
            btnSubmitAttendance.Size = new Size(160, 51);
            btnSubmitAttendance.TabIndex = 12;
            btnSubmitAttendance.Text = "Submit Attendence";
            btnSubmitAttendance.UseVisualStyleBackColor = true;
            btnSubmitAttendance.Click += btnSubmitAttendance_Click;
            // 
            // StaffScheduling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1105, 1044);
            Controls.Add(txtSearchAttendance);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(btnSearchAttendance);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(btnSubmitAttendance);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(txtSearchSchedule);
            Controls.Add(txtSearchStaff);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewSchedules);
            Controls.Add(btnSearchSchedule);
            Controls.Add(dataGridViewStaff);
            Controls.Add(button5);
            Controls.Add(btnSearchStaff);
            Controls.Add(button4);
            Controls.Add(btnDelete);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffScheduling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffScheduling";
            Load += StaffScheduling_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedules).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private DataGridView dataGridViewStaff;
        private Button btnDelete;
        private GroupBox groupBox1;
        private DateTimePicker dtpHireDate;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cmbGender;
        private ComboBox cmbUser;
        private Button button1;
        private Label label1;
        private TextBox txtSearchStaff;
        private Button btnSearchStaff;
        private GroupBox groupBox2;
        private ComboBox cmbStaff;
        private DateTimePicker dtpScheduleDate;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btnSearchSchedule;
        private DataGridView dataGridViewSchedules;
        private TextBox txtSearchSchedule;
        private GroupBox groupBox3;
        private ComboBox cmbStaffAttendence;
        private DateTimePicker dtpTimeOut;
        private TextBox txtNotes;
        private DateTimePicker dtpTimeIn;
        private DateTimePicker dtpAttendanceDate;
        private TextBox txtSearchAttendance;
        private DataGridView dataGridViewAttendance;
        private Button btnSearchAttendance;
        private Button button8;
        private Button button9;
        private Button btnSubmitAttendance;
        private ComboBox cmbShift;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
    }
}