using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MELTADO_CAFE
{
    public partial class TableReservationForm : Form
    {
        string ConStr = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;

        private int? SelectedTableID = -1;

        public TableReservationForm()
        {
            InitializeComponent();
            LoadDietaryPreferenceInCustomers();
            LoadMembershipTierInCustomers();
            LoadReservationGrid();
        }

        private void LoadDietaryPreferenceInCustomers()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllDietaryPreferences", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["PreferenceName"] = "-- Select DietaryPreferences --";
                dt.Rows.InsertAt(defaultRow, 0);

                cmb_DietoryPreff.DataSource = dt;
                cmb_DietoryPreff.DisplayMember = "PreferenceName";
                cmb_DietoryPreff.ValueMember = "PreferenceName"; // ✅ Set ValueMember
                cmb_DietoryPreff.SelectedIndex = 0;
                cmb_DietoryPreff.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }

        private void LoadUsualTimeInCustomers()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllVisitTimes", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["TimeSlot"] = "-- Select Usual Time --";
                dt.Rows.InsertAt(defaultRow, 0);

                cmb_TimesOfDay.DataSource = dt;
                cmb_TimesOfDay.DisplayMember = "TimeSlot";
                cmb_TimesOfDay.ValueMember = "TimeSlot"; // ✅ Set ValueMember
                cmb_TimesOfDay.SelectedIndex = 0;
                cmb_TimesOfDay.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void LoadMembershipTierInCustomers()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllMembershipTiers", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["TierName"] = "-- Select Membership Tier --";
                dt.Rows.InsertAt(defaultRow, 0);

                cmb_Membershiptier.DataSource = dt;
                cmb_Membershiptier.DisplayMember = "TierName";
                cmb_Membershiptier.ValueMember = "TierName"; // ✅ Set ValueMember
                cmb_Membershiptier.SelectedIndex = 0;
                cmb_Membershiptier.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void PlaceHolder_TextLoad()
        {
            txtCustomerName.PlaceholderText = "Enter Customer Name";
            txtContactNumber.PlaceholderText = "Enter Contact Number";
            txtMembercardNo.PlaceholderText = "Enter Membership Card No";
            txt_Cus_Address.PlaceholderText = "Enter Address";

        }
        private void LoadTablesToComboBox()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlCommand cmd = new SqlCommand("GetAvailableOrAllTables", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxTable.DataSource = dt;
                comboBoxTable.DisplayMember = "TableNumber"; // What user sees
                comboBoxTable.ValueMember = "TableID";       // What you use internally
                comboBoxTable.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }

        private void ClearForm()
        {
            txtCustomerName.Clear();
            txtContactNumber.Clear();
            numPartySize.Value = 1;
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTable.SelectedValue == null ||
                !(comboBoxTable.SelectedValue is int) ||
                (int)comboBoxTable.SelectedValue == 0)  // Skip placeholder
                return;

            int selectedTableId = Convert.ToInt32(comboBoxTable.SelectedValue);

            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlCommand cmd = new SqlCommand("GetCafeTableDetailsById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableID", selectedTableId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    numPartySize.Text = reader["Capacity"].ToString();
                    cmb_tableStatus.Text = reader["Status"].ToString();
                }
                con.Close();
            }
        }

        private void TableReservationForm_Load(object sender, EventArgs e)
        {
            LoadTablesToComboBox();
            cmb_tableStatus.ReadOnly = true;
            PlaceHolder_TextLoad();
            LoadUsualTimeInCustomers();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;


        }

        private void ClearReservationFields()
        {
            try
            {
                comboBoxTable.SelectedIndex = 0;
                txtCustomerName.Clear();
                txtContactNumber.Clear();
                datePicker.Value = DateTime.Now;
                timePicker.Value = DateTime.Now;
                numPartySize.Value = numPartySize.Minimum;  // Assuming NumericUpDown
                cmb_TimesOfDay.SelectedIndex = 0;
                cmb_Membershiptier.SelectedIndex = 0;
                txtMembercardNo.Clear();
                txt_Cus_Address.Clear();
                cmb_DietoryPreff.SelectedIndex = 0;
                txt_crediPoint.Value = numPartySize.Minimum;
                cmb_tableStatus.Clear();
                SelectedTableID = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing fields: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                // === Basic Validation ===
                if (comboBoxTable.SelectedValue == null)
                {
                    MessageBox.Show("Please select a table.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                    string.IsNullOrWhiteSpace(txtContactNumber.Text) ||
                    string.IsNullOrWhiteSpace(numPartySize.Text) ||
                    cmb_TimesOfDay.SelectedIndex <= 0 ||
                    string.IsNullOrWhiteSpace(cmb_tableStatus.Text))
                {
                    MessageBox.Show("Please fill all required fields: Customer Name, Contact Number, Party Size, Time of Day, and Status.",
                                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(numPartySize.Text, out int partySize))
                {
                    MessageBox.Show("Please enter a valid number for Party Size.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txt_crediPoint.Text) && !int.TryParse(txt_crediPoint.Text, out _))
                {
                    MessageBox.Show("Credit Point must be a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // === Insert into Database ===
                using (SqlConnection con = new SqlConnection(ConStr))
                using (SqlCommand cmd = new SqlCommand("sp_InsertTableReservation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    cmd.Parameters.AddWithValue("@TableNumber", comboBoxTable.SelectedValue);
                    cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReservationDate", datePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@ReservationTime", timePicker.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@PartySize", partySize);
                    cmd.Parameters.AddWithValue("@TimeOfDay", cmb_TimesOfDay.Text.Trim());
                    cmd.Parameters.AddWithValue("@MembershipTier", cmb_Membershiptier.Text.Trim());
                    cmd.Parameters.AddWithValue("@MemberCardNo", txtMembercardNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@CustomerAddress", txt_Cus_Address.Text.Trim());
                    cmd.Parameters.AddWithValue("@DietaryPreference", cmb_DietoryPreff.Text.Trim());
                    cmd.Parameters.AddWithValue("@CreditPoint",
                        string.IsNullOrWhiteSpace(txt_crediPoint.Text) ? DBNull.Value : Convert.ToInt32(txt_crediPoint.Text));
                    cmd.Parameters.AddWithValue("@Status", cmb_tableStatus.Text.Trim());

                    // Execute
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    // Success feedback
                    if (result != null && int.TryParse(result.ToString(), out int newID))
                    {
                        MessageBox.Show($"Reservation added successfully. Reservation ID: {newID}",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClearReservationFields();
                    LoadReservationGrid();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException fmtEx)
            {
                MessageBox.Show("Invalid input format: " + fmtEx.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedTableID == null)
            {
                MessageBox.Show("Please select a reservation to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Basic validations
            if (comboBoxTable.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtContactNumber.Text) ||
                string.IsNullOrWhiteSpace(numPartySize.Text) ||
                cmb_TimesOfDay.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(cmb_tableStatus.Text))
            {
                MessageBox.Show("Please fill in all required fields: Table, Name, Contact, Party Size, Time of Day, and Status.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(numPartySize.Text, out int partySize))
            {
                MessageBox.Show("Party Size must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txt_crediPoint.Text) && !int.TryParse(txt_crediPoint.Text, out _))
            {
                MessageBox.Show("Credit Points must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                using (SqlCommand cmd = new SqlCommand("sp_UpdateTableReservation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameter assignments
                    cmd.Parameters.AddWithValue("@TableID", SelectedTableID);
                    cmd.Parameters.AddWithValue("@TableNumber", comboBoxTable.SelectedValue?.ToString());
                    cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReservationDate", datePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@ReservationTime", timePicker.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@PartySize", partySize);

                    // Safely retrieve combo box values (avoid DataRowView issue)
                    cmd.Parameters.AddWithValue("@TimeOfDay", cmb_TimesOfDay.SelectedValue is not null
                        ? cmb_TimesOfDay.SelectedValue.ToString()
                        : cmb_TimesOfDay.Text.Trim());

                    cmd.Parameters.AddWithValue("@MembershipTier", cmb_Membershiptier.SelectedValue is not null
                        ? cmb_Membershiptier.SelectedValue.ToString()
                        : cmb_Membershiptier.Text.Trim());

                    cmd.Parameters.AddWithValue("@MemberCardNo", txtMembercardNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@CustomerAddress", txt_Cus_Address.Text.Trim());

                    cmd.Parameters.AddWithValue("@DietaryPreference", cmb_DietoryPreff.SelectedValue is not null
                        ? cmb_DietoryPreff.SelectedValue.ToString()
                        : cmb_DietoryPreff.Text.Trim());

                    cmd.Parameters.AddWithValue("@CreditPoint", string.IsNullOrWhiteSpace(txt_crediPoint.Text)
                        ? (object)DBNull.Value
                        : Convert.ToInt32(txt_crediPoint.Text));

                    cmd.Parameters.AddWithValue("@Status", cmb_tableStatus.Text.Trim());

                    // Execute update
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearReservationFields();
                        LoadReservationGrid();
                    }
                    else
                    {
                        MessageBox.Show("No reservation updated. Please verify the Table ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException fmtEx)
            {
                MessageBox.Show("Invalid input format: " + fmtEx.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void LoadReservationGrid()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TableReservation_Booked", con))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridReservations.DataSource = dt;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SelectComboBoxItem(ComboBox combo, string value)
        {
            if (value == null) return;

            int index = combo.FindStringExact(value);
            if (index >= 0)
                combo.SelectedIndex = index;
            else
                combo.SelectedIndex = -1; // Clear selection if no match found
        }

        private void dataGridReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridReservations.Rows[e.RowIndex];

                    // Safely assign TableID
                    if (row.Cells["TableID"].Value != DBNull.Value)
                        SelectedTableID = Convert.ToInt32(row.Cells["TableID"].Value);
                    else
                        SelectedTableID = -1;

                    // Assign text and combo values
                    comboBoxTable.SelectedValue = row.Cells["TableNumber"].Value?.ToString();
                    txtCustomerName.Text = row.Cells["CustomerName"].Value?.ToString();
                    txtContactNumber.Text = row.Cells["ContactNumber"].Value?.ToString();

                    // Date & Time Pickers
                    datePicker.Value = row.Cells["ReservationDate"].Value != DBNull.Value
                        ? Convert.ToDateTime(row.Cells["ReservationDate"].Value)
                        : DateTime.Now;

                    timePicker.Value = row.Cells["ReservationTime"].Value != DBNull.Value
                        ? DateTime.Today.Add(TimeSpan.Parse(row.Cells["ReservationTime"].Value.ToString()))
                        : DateTime.Now;

                    // Numeric fields
                    numPartySize.Value = row.Cells["PartySize"].Value != DBNull.Value
                        ? Convert.ToInt32(row.Cells["PartySize"].Value)
                        : 1;

                    txt_crediPoint.Text = row.Cells["CreditPoint"].Value?.ToString();

                    // Safe ComboBox value assignments
                    cmb_TimesOfDay.SelectedValue = row.Cells["TimeOfDay"].Value?.ToString();
                    cmb_Membershiptier.SelectedValue = row.Cells["MembershipTier"].Value?.ToString();
                    cmb_DietoryPreff.SelectedValue = row.Cells["DietaryPreference"].Value?.ToString();
                    cmb_tableStatus.Text = row.Cells["Status"].Value?.ToString();

                    // Address and Membership
                    txtMembercardNo.Text = row.Cells["MemberCardNo"].Value?.ToString();
                    txt_Cus_Address.Text = row.Cells["CustomerAddress"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservation data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (SelectedTableID == null)
            {
                MessageBox.Show("Please select a reservation to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                using (SqlCommand cmd = new SqlCommand("sp_DeleteTableReservation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TableID", SelectedTableID.Value);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearReservationFields();
                        LoadReservationGrid();
                        SelectedTableID = null; // Reset selection
                    }
                    else
                    {
                        MessageBox.Show("No reservation was deleted. It may not exist.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comboBoxTable.SelectedIndex = 0;

            txtCustomerName.Clear();
            txtContactNumber.Clear();
            numPartySize.Value = numPartySize.Minimum;

            cmb_TimesOfDay.SelectedIndex = 0;
            cmb_Membershiptier.SelectedIndex = 0;
            txtMembercardNo.Clear();
            txt_Cus_Address.Clear();
            cmb_DietoryPreff.SelectedIndex = 0;
            txt_crediPoint.Value = numPartySize.Minimum;
            cmb_tableStatus.Clear();

            datePicker.Value = DateTime.Today;
            timePicker.Value = DateTime.Now;

            SelectedTableID = null; // Reset the selected ID if needed
        }
    }
}
