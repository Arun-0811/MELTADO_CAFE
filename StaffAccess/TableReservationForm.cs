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

        private int? selectedReservationID = null;

        public TableReservationForm()
        {
            InitializeComponent();
            
            
            LoadReservationGrid();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            // === Load Tables ===
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TableID, TableNumber FROM CafeTable", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxTable.DataSource = dt;
                comboBoxTable.DisplayMember = "TableNumber";
                comboBoxTable.ValueMember = "TableID";
            }

            // === Load Customers ===
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, FullName FROM Customers", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxCustomer.DataSource = dt;
                comboBoxCustomer.DisplayMember = "FullName";
                comboBoxCustomer.ValueMember = "CustomerID";
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
            
            LoadUsualTimeInCustomers();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;


        }

        private void ClearReservationFields()
        {
            try
            {
                comboBoxTable.SelectedIndex = -1;
                comboBoxCustomer.SelectedIndex = -1;
                numPartySize.Text = "";
                cmb_TimesOfDay.SelectedIndex = -1;
                cmb_tableStatus.SelectedIndex = -1;
                datePicker.Value = DateTime.Now;
                timePicker.Value = DateTime.Now;

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
                if (comboBoxTable.SelectedValue == null || comboBoxCustomer.SelectedValue == null)
                {
                    MessageBox.Show("Please select both a table and a customer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(numPartySize.Text, out int partySize))
                {
                    MessageBox.Show("Please enter a valid number for Party Size.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmb_TimesOfDay.SelectedIndex < 0 || string.IsNullOrWhiteSpace(cmb_tableStatus.Text))
                {
                    MessageBox.Show("Please select Time of Day and Status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // === Insert into Database ===
                using (SqlConnection con = new SqlConnection(ConStr))
                using (SqlCommand cmd = new SqlCommand("sp_InsertTableReservation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameters (normalized)
                    cmd.Parameters.AddWithValue("@TableID", Convert.ToInt32(comboBoxTable.SelectedValue));
                    cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(comboBoxCustomer.SelectedValue));
                    cmd.Parameters.AddWithValue("@ReservationDate", datePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@ReservationTime", timePicker.Value.TimeOfDay);
                    // ✅ Use SelectedValue since ValueMember is set
                    cmd.Parameters.AddWithValue("@TimeOfDay", cmb_TimesOfDay.SelectedValue?.ToString());
                    cmd.Parameters.AddWithValue("@PartySize", partySize);
                    cmd.Parameters.AddWithValue("@Status", cmb_tableStatus.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Reservation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (selectedReservationID <= 0)
            {
                MessageBox.Show("Please select a reservation to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Validate table and customer selection
                if (comboBoxTable.SelectedValue == null || comboBoxCustomer.SelectedValue == null)
                {
                    MessageBox.Show("Please select both a table and a customer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate party size
                if (!int.TryParse(numPartySize.Text.Trim(), out int partySize))
                {
                    MessageBox.Show("Invalid Party Size. Please enter a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate usual time selection
                if (cmb_TimesOfDay.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please select a valid usual time of day.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(ConStr))
                using (SqlCommand cmd = new SqlCommand("sp_UpdateTableReservation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Set parameters
                    cmd.Parameters.AddWithValue("@ReservationID", selectedReservationID);
                    cmd.Parameters.AddWithValue("@TableID", Convert.ToInt32(comboBoxTable.SelectedValue));
                    cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(comboBoxCustomer.SelectedValue));
                    cmd.Parameters.AddWithValue("@ReservationDate", datePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@ReservationTime", timePicker.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@TimeOfDay", cmb_TimesOfDay.SelectedValue?.ToString() ?? cmb_TimesOfDay.Text.Trim());
                    cmd.Parameters.AddWithValue("@PartySize", partySize);
                    cmd.Parameters.AddWithValue("@Status", cmb_tableStatus.Text.Trim());

                    // Execute update
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No reservation was updated. Please verify the selected record.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Refresh UI
                    LoadReservationGrid();
                    ClearReservationFields();
                    selectedReservationID = -1;
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






        private void LoadReservationGrid()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("sp_GetAllTableReservations", con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridReservations.DataSource = dt;
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


        void SelectComboBoxItem(ComboBox combo, string value)
        {
            if (value == null) return;

            int index = combo.FindStringExact(value);
            if (index >= 0)
                combo.SelectedIndex = index;
            else
                combo.SelectedIndex = -1; // Clear selection if no match found
        }

        private int GetTableIDFromTableNumber(string tableNumber)
        {
            int tableID = -1;
            string query = "SELECT TableID FROM CafeTable WHERE TableNumber = @TableNumber";

            using (SqlConnection con = new SqlConnection(ConStr))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
                con.Open();

                object result = cmd.ExecuteScalar();
                if (result != null)
                    tableID = Convert.ToInt32(result);
            }
            return tableID;
        }

        private int GetCustomerIDFromName(string fullName)
        {
            int customerID = -1;
            string query = "SELECT CustomerID FROM Customers WHERE FullName = @FullName";

            using (SqlConnection con = new SqlConnection(ConStr))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@FullName", fullName);
                con.Open();

                object result = cmd.ExecuteScalar();
                if (result != null)
                    customerID = Convert.ToInt32(result);
            }
            return customerID;
        }

        private void dataGridReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row

            DataGridViewRow row = dataGridReservations.Rows[e.RowIndex];

            // 1. Reservation ID
            selectedReservationID = int.TryParse(row.Cells["ReservationID"].Value?.ToString(), out int resID) ? resID : -1;

            // 2. Table Number → TableID
            string tableNumber = row.Cells["TableNumber"].Value?.ToString() ?? "";
            int tableID = GetTableIDFromTableNumber(tableNumber);
            if (tableID != -1)
                comboBoxTable.SelectedValue = tableID;
            else
                comboBoxTable.Text = tableNumber;

            // 3. Customer Name → CustomerID
            string customerName = row.Cells["CustomerName"].Value?.ToString() ?? "";
            int customerID = GetCustomerIDFromName(customerName);
            if (customerID != -1)
                comboBoxCustomer.SelectedValue = customerID;
            else
                comboBoxCustomer.Text = customerName;

            // 4. Reservation Date
            if (DateTime.TryParse(row.Cells["ReservationDate"].Value?.ToString(), out DateTime resDate))
                datePicker.Value = resDate;

            // 5. Reservation Time
            if (TimeSpan.TryParse(row.Cells["ReservationTime"].Value?.ToString(), out TimeSpan resTime))
                timePicker.Value = DateTime.Today.Add(resTime);

            string timeOfDay = row.Cells["TimeOfDay"].Value?.ToString() ?? "";

            // Find matching index in the combo box items
            int index = -1;
            for (int i = 0; i < cmb_TimesOfDay.Items.Count; i++)
            {
                // Each item is a DataRowView because it's bound to DataTable
                var drv = cmb_TimesOfDay.Items[i] as DataRowView;
                if (drv != null)
                {
                    string timeSlot = drv["TimeSlot"].ToString();
                    if (string.Equals(timeSlot, timeOfDay, StringComparison.OrdinalIgnoreCase))
                    {
                        index = i;
                        break;
                    }
                }
            }

            if (index >= 0)
                cmb_TimesOfDay.SelectedIndex = index;  // Select matching item
            else
                cmb_TimesOfDay.SelectedIndex = 0;      // Default to "-- Select Usual Time --"


            // 7. Party Size
            if (int.TryParse(row.Cells["PartySize"].Value?.ToString(), out int partySize))
                numPartySize.Value = partySize;
            else
                numPartySize.Value = numPartySize.Minimum;

            // 8. Status
            cmb_tableStatus.Text = row.Cells["Status"].Value?.ToString() ?? "";
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Check if a reservation is selected
            if (selectedReservationID == -1 || selectedReservationID == 0)
            {
                MessageBox.Show("Please select a reservation to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            var confirm = MessageBox.Show("Are you sure you want to delete this reservation?",
                                          "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                using (SqlCommand cmd = new SqlCommand("sp_DeleteTableReservation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReservationID", selectedReservationID);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearReservationFields();
                        LoadReservationGrid();
                        selectedReservationID = -1; // reset selection
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

            
            
            numPartySize.Value = numPartySize.Minimum;
            comboBoxCustomer.SelectedIndex = 0;
            cmb_TimesOfDay.SelectedIndex = 0;
           
            cmb_tableStatus.SelectedIndex = 0;

            datePicker.Value = DateTime.Today;
            timePicker.Value = DateTime.Now;

            selectedReservationID = null; // Reset the selected ID if needed
        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            LoadReservationGrid();
        }

        private void LoadFilteredReservations(string searchTerm)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                using (SqlCommand cmd = new SqlCommand("sp_SearchTableReservations", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            LoadFilteredReservations(searchText);
        }
    }
}
