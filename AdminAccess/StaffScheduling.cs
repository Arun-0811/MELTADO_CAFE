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

        public StaffScheduling()
        {
            InitializeComponent();
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
                        MessageBox.Show("Staff record added successfully.");
                    else
                        MessageBox.Show("Insert failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                    // If UserId can be updated (usually no), uncomment this
                    // cmd.Parameters.AddWithValue("@UserId", selectedUserId);
                    cmd.Parameters.AddWithValue("@GenderID", selectedGenderId);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmd.Parameters.AddWithValue("@HireDate", hireDate);
                    // Pass ModifiedBy if your proc expects it, otherwise skip
                    cmd.Parameters.AddWithValue("@ModifiedBy", modifiedBy);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Staff record updated successfully.");
                        LoadStaffRecords();  // refresh grid
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
                            LoadStaffRecords(); // Refresh the DataGridView after deletion
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
                string query = @"
            SELECT s.StaffID, u.Username AS FullName
            FROM Staff s
            INNER JOIN Users u ON s.UserId = u.UserId
            WHERE u.IsActive = 1";  // Filter active users only

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbStaff.DataSource = dt;
                cmbStaff.DisplayMember = "FullName";
                cmbStaff.ValueMember = "StaffID";
                cmbStaff.SelectedIndex = -1;
            }
        }

        private void LoadStaffComboBoxForAttendances()
        {
            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                string query = @"
            SELECT s.StaffID, u.Username AS FullName
            FROM Staff s
            INNER JOIN Users u ON s.UserId = u.UserId
            WHERE u.IsActive = 1";  // Filter active users only

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbStaffAttendence.DataSource = dt;
                cmbStaffAttendence.DisplayMember = "FullName";
                cmbStaffAttendence.ValueMember = "StaffID";
                cmbStaffAttendence.SelectedIndex = -1;
            }
        }
        private void LoadShiftComboBox()
        {
            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                string query = "SELECT ShiftID, ShiftName FROM ShiftTypes";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbShift.DataSource = dt;
                cmbShift.DisplayMember = "ShiftName";  // What user sees
                cmbShift.ValueMember = "ShiftID";      // Actual value
                cmbShift.SelectedIndex = -1;           // No default selection
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

                        // Optionally, refresh the schedule grid/list here
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
            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                string query = @"
            SELECT 
                ss.ScheduleID,
                s.StaffID,
                u.Username AS StaffName,
                ss.ScheduleDate,
                st.ShiftName,
                st.StartTime,
                st.EndTime,
                ss.CreatedAt
            FROM StaffSchedules ss
            INNER JOIN Staff s ON ss.StaffID = s.StaffID
            INNER JOIN Users u ON s.UserId = u.UserId
            INNER JOIN ShiftTypes st ON ss.ShiftID = st.ShiftID
            ORDER BY ss.ScheduleDate DESC, u.Username";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewSchedules.DataSource = dt;

                // Optional: Customize columns header text
                dataGridViewSchedules.Columns["ScheduleID"].Visible = false;
                dataGridViewSchedules.Columns["StaffID"].Visible = false;

                dataGridViewSchedules.Columns["StaffName"].HeaderText = "Staff";
                dataGridViewSchedules.Columns["ScheduleDate"].HeaderText = "Schedule Date";
                dataGridViewSchedules.Columns["ShiftName"].HeaderText = "Shift";
                dataGridViewSchedules.Columns["StartTime"].HeaderText = "Shift Start";
                dataGridViewSchedules.Columns["EndTime"].HeaderText = "Shift End";
                dataGridViewSchedules.Columns["CreatedAt"].HeaderText = "Assigned On";

                // Format Date and Time columns if needed
                dataGridViewSchedules.Columns["ScheduleDate"].DefaultCellStyle.Format = "dd MMM yyyy";
                dataGridViewSchedules.Columns["StartTime"].DefaultCellStyle.Format = "hh\\:mm tt";
                dataGridViewSchedules.Columns["EndTime"].DefaultCellStyle.Format = "hh\\:mm tt";
                dataGridViewSchedules.Columns["CreatedAt"].DefaultCellStyle.Format = "dd MMM yyyy HH:mm";
            }
        }

        private void dataGridViewSchedules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // avoid header row
            {
                DataGridViewRow row = dataGridViewSchedules.Rows[e.RowIndex];

                // Get ScheduleID
                currentScheduleId = Convert.ToInt32(row.Cells["ScheduleID"].Value);

                // Set Staff ComboBox (assumes StaffID column exists but hidden)
                int staffId = Convert.ToInt32(row.Cells["StaffID"].Value);
                cmbStaff.SelectedValue = staffId;

                // Set Schedule Date
                DateTime scheduleDate = Convert.ToDateTime(row.Cells["ScheduleDate"].Value);
                dtpScheduleDate.Value = scheduleDate;

                // Set Shift ComboBox (assumes ShiftName column present)
                string shiftName = row.Cells["ShiftName"].Value.ToString();

                // Select the shift in cmbShift based on shiftName
                foreach (DataRowView item in cmbShift.Items)
                {
                    if (item["ShiftName"].ToString() == shiftName)
                    {
                        cmbShift.SelectedItem = item;
                        break;
                    }
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
            cmbStaff.SelectedIndex = -1;
            txtNotes.Clear();
            dtpTimeIn.Value = DateTime.Now;
            dtpTimeOut.Value = DateTime.Now;
        }

        private void btnSubmitAttendance_Click(object sender, EventArgs e)
        {
            if (cmbStaff.SelectedValue == null)
            {
                MessageBox.Show("Please select a staff member.");
                return;
            }

            int staffId = Convert.ToInt32(cmbStaff.SelectedValue);
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

    }
}
