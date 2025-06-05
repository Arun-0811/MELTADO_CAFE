using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using static MELTADO_CAFE.Login_Page;

namespace MELTADO_CAFE.AdminAccess
{
    public partial class StaffScheduling : Form
    {
        string ConStr = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;
        private int currentStaffId = -1;
        private int currentScheduleId = -1;
        private int currentAttendanceId = 0;

        public StaffScheduling()
        {
            InitializeComponent();
            PlaceHolder_TextLoad(); // Load placeholder text for input fields
            // Configure the DateTimePicker to show only date (dd/MM/yyyy)
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";

            dtpHireDate.Format = DateTimePickerFormat.Custom;
            dtpHireDate.CustomFormat = "dd/MM/yyyy";

            dtpScheduleDate.Format = DateTimePickerFormat.Custom;
            dtpScheduleDate.CustomFormat = "dd/MM/yyyy";

            dtpAttendanceDate.Format = DateTimePickerFormat.Custom;
            dtpAttendanceDate.CustomFormat = "dd-MM-yyyy"; // or "yyyy-MM-dd" if needed for database format

            // For TimeIn
            dtpTimeIn.Format = DateTimePickerFormat.Time;
            dtpTimeIn.ShowUpDown = true;

            // For TimeOut
            dtpTimeOut.Format = DateTimePickerFormat.Time;
            dtpTimeOut.ShowUpDown = true;

        }
        private void PlaceHolder_TextLoad()
        {
            // Full Name
            txtSearchStaff.PlaceholderText = "--Staff search here--";

            // Phone Number
            txtSearchSchedule.PlaceholderText = "--Schedule search here--";

            // Email
            txtSearchAttendance.PlaceholderText = "--Attendance Search here--";

            txtNotes.PlaceholderText = "Enter Notes...!";
        }
        private void StaffScheduling_Load(object sender, EventArgs e)
        {
            LoadUsersToComboBox();
            LoadGenderToComboBox();
            LoadStaffRecords();
            LoadStaffComboBox();
            LoadShiftComboBox();
            LoadAssignedSchedules();
            LoadStaffComboBoxForAttendances();
            LoadAttendanceHistory();
        }

        private void LoadAttendanceHistory()
        {
            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                string query = @"
            SELECT 
                sa.AttendanceID,
                s.StaffID,
                u.Username AS StaffName,
                sa.AttendanceDate,
                sa.TimeIn,
                sa.TimeOut,
                sa.Notes
            FROM 
                StaffAttendance sa
            INNER JOIN Staff s ON sa.StaffID = s.StaffID
            INNER JOIN Users u ON s.UserId = u.UserId
            ORDER BY sa.AttendanceDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAttendance.DataSource = dt;
            }
        }

        private void LoadUsersToComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    conn.Open();
                    string query = "SELECT UserId, Username FROM Users WHERE IsActive = 1";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbUser.DataSource = dt;
                    cmbUser.DisplayMember = "Username";
                    cmbUser.ValueMember = "UserId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void LoadGenderToComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    conn.Open();
                    string query = "SELECT GenderID, GenderName FROM Gender";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbGender.DataSource = dt;
                    cmbGender.DisplayMember = "GenderName";
                    cmbGender.ValueMember = "GenderID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading gender options: " + ex.Message);
            }
        }

        private void LoadStaffRecords()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    s.StaffID,
                    u.UserId,
                    u.Username,
                    s.GenderID,
                    s.DateOfBirth,
                    s.HireDate,
                    g.GenderName,
                    s.CreatedAt
                FROM Staff s
                INNER JOIN Users u ON s.UserId = u.UserId
                LEFT JOIN Gender g ON s.GenderID = g.GenderID
                ORDER BY s.StaffID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewStaff.DataSource = dt;

                    // Optional: Customize column headers
                    dataGridViewStaff.Columns["StaffID"].HeaderText = "Staff ID";
                    dataGridViewStaff.Columns["UserId"].HeaderText = "User ID";
                    dataGridViewStaff.Columns["Username"].HeaderText = "Username";
                    dataGridViewStaff.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                    dataGridViewStaff.Columns["HireDate"].HeaderText = "Hire Date";
                    dataGridViewStaff.Columns["GenderName"].HeaderText = "Gender";
                    dataGridViewStaff.Columns["CreatedAt"].HeaderText = "Created At";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff records: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedUserId = Convert.ToInt32(cmbUser.SelectedValue);            // From User ComboBox
                int selectedGenderId = Convert.ToInt32(cmbGender.SelectedValue);        // From Gender ComboBox
                DateTime dob = dtpDateOfBirth.Value;                                    // Assume DateTimePicker for DOB
                DateTime hireDate = dtpHireDate.Value;                                  // Optional custom hire date picker
                int createdBy = LoggedInUser.UserId;                                         // e.g., current user's ID

                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("AddStaff", conn); // Use your actual SP name
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserId", selectedUserId);
                    cmd.Parameters.AddWithValue("@GenderID", selectedGenderId);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmd.Parameters.AddWithValue("@HireDate", hireDate);
                    cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Staff record added successfully.");
                        ClearFormControls();         // Clear the inputs
                        LoadStaffRecords();
                    }

                    else
                        MessageBox.Show("Insert failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearFormControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
                else if (ctrl is DateTimePicker)
                    ((DateTimePicker)ctrl).Value = DateTime.Today;

                if (ctrl.HasChildren)
                    ClearFormControlsRecursive(ctrl);
            }
        }

        private void ClearFormControlsRecursive(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
                else if (ctrl is DateTimePicker)
                    ((DateTimePicker)ctrl).Value = DateTime.Today;

                if (ctrl.HasChildren)
                    ClearFormControlsRecursive(ctrl);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentStaffId == -1)
            {
                MessageBox.Show("Please select a staff record first.");
                return;
            }

            try
            {
                int staffId = currentStaffId;
                int selectedUserId = Convert.ToInt32(cmbUser.SelectedValue);          // optional if editable
                int selectedGenderId = Convert.ToInt32(cmbGender.SelectedValue);
                DateTime dob = dtpDateOfBirth.Value.Date;
                DateTime hireDate = dtpHireDate.Value.Date;

                // Optionally, get current logged-in user id as modifier:
                int modifiedBy = LoggedInUser.UserId;  // Define this in your code based on your login/session

                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UpdateStaff", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    cmd.Parameters.AddWithValue("@UserId", selectedUserId);  // ✅ REQUIRED for your procedure
                    cmd.Parameters.AddWithValue("@GenderID", selectedGenderId);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmd.Parameters.AddWithValue("@HireDate", hireDate);
                    cmd.Parameters.AddWithValue("@ModifiedBy", modifiedBy);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Staff record updated successfully.");
                        ClearFormControls();
                        LoadStaffRecords();
                        currentStaffId = -1; // refresh grid                                

                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff record: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentStaffId == -1)
            {
                MessageBox.Show("Please select a staff record first.");
                return;
            }


            try
            {
                int staffId = currentStaffId;

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete the selected staff record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ConStr))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DeleteStaff", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StaffID", staffId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff record deleted successfully.");
                            ClearFormControls();
                            currentStaffId = -1;
                            LoadStaffRecords();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. Staff record may not exist.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting staff record: " + ex.Message);
            }
        }

        private void dataGridViewStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the click is on a valid row (not header)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewStaff.Rows[e.RowIndex];
                currentStaffId = Convert.ToInt32(row.Cells["StaffID"].Value);

                // Assuming your grid has these columns:
                // StaffID (hidden or visible), UserId, GenderID, DateOfBirth, HireDate

                // Load StaffID if you need it later (e.g., for update/delete)
                int staffId = Convert.ToInt32(row.Cells["StaffID"].Value);

                // Load UserId into combo box
                int userId = Convert.ToInt32(row.Cells["UserId"].Value);
                cmbUser.SelectedValue = userId;

                // Load GenderID into combo box
                int genderId = Convert.ToInt32(row.Cells["GenderID"].Value);
                cmbGender.SelectedValue = genderId;

                // Load dates into DateTimePickers
                DateTime dob = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                dtpDateOfBirth.Value = dob;

                DateTime hireDate = Convert.ToDateTime(row.Cells["HireDate"].Value);
                dtpHireDate.Value = hireDate;

                // Optionally store staffId in a form-level variable if needed for update/delete
                currentStaffId = staffId;  // currentStaffId declared at form class level
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchStaff.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                // If search box is empty, reload full data
                LoadStaffRecords();
                return;
            }

            // Assuming your DataGridView is bound to a DataTable or List<Staff>
            // Example if bound to DataTable:

            DataTable dt = (DataTable)dataGridViewStaff.DataSource;
            if (dt == null) return;

            // Use DataView to filter rows by FullName or Username columns (adjust column names)
            DataView dv = new DataView(dt);
            dv.RowFilter = $"FullName LIKE '%{searchTerm}%' OR Username LIKE '%{searchTerm}%'";

            dataGridViewStaff.DataSource = dv;
        }

        private void LoadStaffComboBox()
        {
            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                conn.Open(); // Ensure the connection is explicitly opened

                string query = @"
                SELECT s.StaffID, u.Username AS FullName
                FROM Staff s
                INNER JOIN Users u ON s.UserId = u.UserId
                WHERE u.IsActive = 1";  // Filter active users

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    cmbStaff.DataSource = dt;
                    cmbStaff.DisplayMember = "FullName";
                    cmbStaff.ValueMember = "StaffID";
                    cmbStaff.SelectedIndex = -1;  // Optional: no selection initially
                }
                else
                {
                    MessageBox.Show("No active staff members found.");
                }
            }

        }

        private void LoadStaffComboBoxForAttendances()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    string query = @"
                SELECT s.StaffID, u.Username AS FullName
                FROM Staff s
                INNER JOIN Users u ON s.UserId = u.UserId
                WHERE u.IsActive = 1";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbStaffAttendence.DataSource = dt;
                    cmbStaffAttendence.DisplayMember = "FullName";
                    cmbStaffAttendence.ValueMember = "StaffID";
                    cmbStaffAttendence.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff list: " + ex.Message);
            }
        }

        private void LoadShiftComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    string query = "SELECT ShiftID, ShiftName FROM ShiftTypes";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Ensure data is loaded before setting the DataSource
                        if (dt.Rows.Count > 0)
                        {
                            cmbShift.DataSource = dt;
                            cmbShift.DisplayMember = "ShiftName";  // What user sees
                            cmbShift.ValueMember = "ShiftID";      // Actual value
                            cmbShift.SelectedIndex = -1;           // No default selection
                        }
                        else
                        {
                            MessageBox.Show("No shifts found!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading shifts: " + ex.Message);
            }
        }
        private void btnAssignSchedule_Click(object sender, EventArgs e)
        {
            if (cmbStaff.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a staff member.");
                return;
            }

            if (cmbShift.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a shift.");
                return;
            }

            int staffId = Convert.ToInt32(cmbStaff.SelectedValue);
            DateTime scheduleDate = dtpScheduleDate.Value.Date;  // Only date part
            int shiftId = Convert.ToInt32(cmbShift.SelectedValue);
            int createdBy = LoggedInUser.UserId; // Set this from your login context

            try
            {
                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    using (SqlCommand cmd = new SqlCommand("AddStaffSchedule", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@StaffID", staffId);
                        cmd.Parameters.AddWithValue("@ScheduleDate", scheduleDate);
                        cmd.Parameters.AddWithValue("@ShiftID", shiftId);
                        cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Schedule assigned successfully!");
                        // ✅ Clear the fields
                        cmbStaff.SelectedIndex = -1;
                        cmbShift.SelectedIndex = -1;
                        dtpScheduleDate.Value = DateTime.Today;
                        LoadAssignedSchedules();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning schedule: " + ex.Message);
            }
        }

        private void LoadAssignedSchedules()
        {
            string query = @"
                    SELECT TOP (1000) [ScheduleID],
                          [StaffID],
                          [ScheduleDate],
                          [ShiftID],
                          [CreatedBy],
                          [CreatedAt]
                    FROM [MELTADO_CAFE_DB].[dbo].[StaffSchedules]";

            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewSchedules.DataSource = dt;
            }
        }

        private void dataGridViewSchedules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewSchedules.Rows[e.RowIndex].Cells["ScheduleID"].Value != null)
            {
                DataGridViewRow row = dataGridViewSchedules.Rows[e.RowIndex];

                // Get ScheduleID
                currentScheduleId = Convert.ToInt32(row.Cells["ScheduleID"].Value);

                // Set Staff ComboBox (assuming StaffID column exists and cmbStaff is bound with ValueMember = "StaffID")
                if (row.Cells["StaffID"].Value != DBNull.Value)
                {
                    cmbStaff.SelectedValue = Convert.ToInt32(row.Cells["StaffID"].Value);
                }

                // Set Schedule Date
                if (row.Cells["ScheduleDate"].Value != DBNull.Value)
                {
                    dtpScheduleDate.Value = Convert.ToDateTime(row.Cells["ScheduleDate"].Value);
                }

                // Set Shift ComboBox by ShiftID (recommended for accuracy)
                if (row.Cells["ShiftID"].Value != DBNull.Value)
                {
                    cmbShift.SelectedValue = Convert.ToInt32(row.Cells["ShiftID"].Value);
                }

            }
        }


        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {
            if (currentScheduleId == -1)
            {
                MessageBox.Show("Please select a schedule to update.");
                return;
            }

            int staffId = Convert.ToInt32(cmbStaff.SelectedValue);
            DateTime scheduleDate = dtpScheduleDate.Value.Date;
            int shiftId = Convert.ToInt32(cmbShift.SelectedValue);
            int createdBy = LoggedInUser.UserId;  // Your logged-in user id

            try
            {
                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UpdateStaffSchedule", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ScheduleID", currentScheduleId);
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    cmd.Parameters.AddWithValue("@ScheduleDate", scheduleDate);
                    cmd.Parameters.AddWithValue("@ShiftID", shiftId);
                    cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Schedule updated successfully.");
                        LoadAssignedSchedules();
                        ClearScheduleForm();
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearScheduleForm()
        {
            currentScheduleId = -1;
            cmbStaff.SelectedIndex = -1;
            cmbShift.SelectedIndex = -1;
            dtpScheduleDate.Value = DateTime.Today;
        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            if (currentScheduleId == -1)
            {
                MessageBox.Show("Please select a schedule to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this schedule?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConStr))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DeleteStaffSchedule", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ScheduleID", currentScheduleId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Schedule deleted successfully.");
                            LoadAssignedSchedules();
                            ClearScheduleForm();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void ClearAttendanceForm()
        {
            // Reset ComboBox
            cmbStaffAttendence.SelectedIndex = -1;

            // Reset DateTimePickers to today's date and default time (e.g., 9:00 AM for TimeIn, 6:00 PM for TimeOut)
            dtpAttendanceDate.Value = DateTime.Today;
            dtpTimeIn.Value = DateTime.Today.AddHours(9);  // or any default time
            dtpTimeOut.Value = DateTime.Today.AddHours(18); // or any default time

            // Clear notes textbox
            txtNotes.Clear();
        }


        private void btnSubmitAttendance_Click(object sender, EventArgs e)
        {
            if (cmbStaffAttendence.SelectedValue == null)
            {
                MessageBox.Show("Please select a staff member.");
                return;
            }

            int staffId = Convert.ToInt32(cmbStaffAttendence.SelectedValue);
            DateTime attendanceDate = dtpAttendanceDate.Value.Date;
            DateTime timeIn = dtpTimeIn.Value;
            DateTime timeOut = dtpTimeOut.Value;
            string notes = txtNotes.Text.Trim();
            int createdBy = LoggedInUser.UserId; // Set this from your login logic

            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("AddStaffAttendance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    cmd.Parameters.AddWithValue("@AttendanceDate", attendanceDate);
                    cmd.Parameters.AddWithValue("@TimeIn", timeIn);
                    cmd.Parameters.AddWithValue("@TimeOut", timeOut);
                    cmd.Parameters.AddWithValue("@Notes", notes);
                    cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Attendance submitted successfully.");
                    LoadAttendanceHistory(); // Refresh DataGridView
                    ClearAttendanceForm();   // Optional: clear form fields
                }
            }
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchStaff.Text.Trim();

            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                string query = @"
            SELECT s.StaffID, u.Username AS FullName, g.GenderName, s.DateOfBirth, s.HireDate
            FROM Staff s
            INNER JOIN Users u ON s.UserId = u.UserId
            INNER JOIN Gender g ON s.GenderID = g.GenderID
            WHERE u.Username LIKE @Keyword";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewStaff.DataSource = dt;
            }
        }

        private void btnSearchSchedule_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchSchedule.Text.Trim();

            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                string query = @"
            SELECT ss.ScheduleID, u.Username AS StaffName, st.ShiftName, ss.ScheduleDate
            FROM StaffSchedules ss
            INNER JOIN Staff s ON ss.StaffID = s.StaffID
            INNER JOIN Users u ON s.UserId = u.UserId
            INNER JOIN ShiftTypes st ON ss.ShiftID = st.ShiftID
            WHERE u.Username LIKE @Keyword";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSchedules.DataSource = dt;
            }
        }

        private void btnSearchAttendance_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchAttendance.Text.Trim();

            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                string query = @"
            SELECT sa.AttendanceID, u.Username AS StaffName, sa.AttendanceDate, sa.TimeIn, sa.TimeOut, sa.Notes
            FROM StaffAttendance sa
            INNER JOIN Staff s ON sa.StaffID = s.StaffID
            INNER JOIN Users u ON s.UserId = u.UserId
            WHERE u.Username LIKE @Keyword";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAttendance.DataSource = dt;
            }
        }



        private void dataGridViewAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewAttendance.Rows[e.RowIndex].Cells["AttendanceID"].Value != null)
            {
                DataGridViewRow row = dataGridViewAttendance.Rows[e.RowIndex];

                // Get AttendanceID
                currentAttendanceId = Convert.ToInt32(row.Cells["AttendanceID"].Value);

                // Set Staff ComboBox (assuming StaffID column exists and cmbStaffAttendence is bound with ValueMember = "StaffID")
                if (row.Cells["StaffID"].Value != DBNull.Value)
                {
                    cmbStaffAttendence.SelectedValue = Convert.ToInt32(row.Cells["StaffID"].Value);
                }

                // Set Attendance Date
                if (row.Cells["AttendanceDate"].Value != DBNull.Value)
                {
                    dtpAttendanceDate.Value = Convert.ToDateTime(row.Cells["AttendanceDate"].Value);
                }

                // Set TimeIn
                if (row.Cells["TimeIn"].Value != DBNull.Value)
                {
                    dtpTimeIn.Value = Convert.ToDateTime(row.Cells["TimeIn"].Value);
                }

                // Set TimeOut
                if (row.Cells["TimeOut"].Value != DBNull.Value)
                {
                    dtpTimeOut.Value = Convert.ToDateTime(row.Cells["TimeOut"].Value);
                }

                // Set Notes
                if (row.Cells["Notes"].Value != DBNull.Value)
                {
                    txtNotes.Text = row.Cells["Notes"].Value.ToString();
                }
                else
                {
                    txtNotes.Clear();
                }
            }
        }

        private void btnUpdateAttendance_Click(object sender, EventArgs e)
        {
            if (currentAttendanceId == 0)
            {
                MessageBox.Show("Please select an attendance record to update.");
                return;
            }

            if (cmbStaffAttendence.SelectedValue == null)
            {
                MessageBox.Show("Please select a staff member.");
                return;
            }

            int staffId = Convert.ToInt32(cmbStaffAttendence.SelectedValue);
            DateTime attendanceDate = dtpAttendanceDate.Value.Date;
            DateTime timeIn = dtpTimeIn.Value;
            DateTime timeOut = dtpTimeOut.Value;
            string notes = txtNotes.Text.Trim();

            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateStaffAttendance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AttendanceID", currentAttendanceId);
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    cmd.Parameters.AddWithValue("@AttendanceDate", attendanceDate);
                    cmd.Parameters.AddWithValue("@TimeIn", timeIn);
                    cmd.Parameters.AddWithValue("@TimeOut", timeOut);
                    cmd.Parameters.AddWithValue("@Notes", notes);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Attendance updated successfully.");
                    LoadAttendanceHistory(); // Refresh grid
                    ClearAttendanceForm();   // Clear form
                }
            }
        }

        private void btnDeleteAttendance_Click(object sender, EventArgs e)
        {
            if (currentAttendanceId == 0)
            {
                MessageBox.Show("Please select an attendance record to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteStaffAttendance", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@AttendanceID", currentAttendanceId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Attendance deleted successfully.");
                        LoadAttendanceHistory(); // Refresh grid
                        ClearAttendanceForm();   // Clear form
                    }
                }
            }
        }

    }
}
