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

namespace MELTADO_CAFE.StaffAccess
{
    public partial class CustomerManagmentByStaff : Form
    {
        string ConnnectionString = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;

        private int selectedCustomerId = -1;
        public CustomerManagmentByStaff()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Name, Phone Number, Email).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(ConnnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_InsertCustomerData", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Basic Info
                    cmd.Parameters.AddWithValue("@FullName", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text); // Correct: use .Text

                    // Preferences
                    cmd.Parameters.AddWithValue("@FavoriteItems", cmbFavorites.Text); // Correct
                    cmd.Parameters.AddWithValue("@DietaryPreferences", cmbDietary.Text); // Correct
                    cmd.Parameters.AddWithValue("@PreferredTable", cmbTable.SelectedValue != null ? (cmbTable.SelectedValue) : (object)DBNull.Value); // Important
                    cmd.Parameters.AddWithValue("@UsualVisitTime", cmbTime.Text); // Correct
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@DeliveryInstructions", txtInstructions.Text.Trim());

                    // Stats
                    cmd.Parameters.AddWithValue("@TotalVisits", int.TryParse(txtTotalVisits.Text.Trim(), out int totalVisits) ? totalVisits : 0);
                    cmd.Parameters.AddWithValue("@LastVisit", dtpLastVisit.Value);
                    cmd.Parameters.AddWithValue("@TotalSpend", decimal.TryParse(txtTotalSpend.Text.Trim(), out decimal totalSpend) ? totalSpend : 0);
                    cmd.Parameters.AddWithValue("@LoyaltyCardNumber", txtCardNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@RewardPoints", (int)numPoints.Value);
                    cmd.Parameters.AddWithValue("@MembershipTier", cmbTier.Text); // Correct
                    cmd.Parameters.AddWithValue("@LastFeedback", txtLastFeedback.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ClearForm()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            dtpDOB.Value = DateTime.Now;
            cmbGender.SelectedIndex = 0;
            cmbFavorites.SelectedIndex = 0;
            cmbDietary.SelectedIndex = 0;
            cmbTable.SelectedIndex = 0;
            cmbTime.SelectedIndex = 0;
            txtCardNo.Clear();
            numPoints.Value = 0;
            cmbTier.SelectedIndex = 0;
            txtLastFeedback.Clear();
            txtAddress.Clear();
            txtInstructions.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateCustomerData", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerId);
                    cmd.Parameters.AddWithValue("@FullName", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);  // Use .Text

                    cmd.Parameters.AddWithValue("@FavoriteItems", cmbFavorites.Text);  // Use .Text
                    cmd.Parameters.AddWithValue("@DietaryPreferences", cmbDietary.Text);  // Use .Text

                    // PreferredTable is likely bound, so use SelectedValue with null check & conversion
                    cmd.Parameters.AddWithValue("@PreferredTable",
                        cmbTable.SelectedValue != null ? (cmbTable.SelectedValue) : (object)DBNull.Value);

                    cmd.Parameters.AddWithValue("@UsualVisitTime", cmbTime.Text);  // Use .Text
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@DeliveryInstructions", txtInstructions.Text.Trim());

                    // Safer parsing for int and decimal fields
                    cmd.Parameters.AddWithValue("@TotalVisits", int.TryParse(txtTotalVisits.Text.Trim(), out int totalVisits) ? totalVisits : 0);
                    cmd.Parameters.AddWithValue("@LastVisit", dtpLastVisit.Value);
                    cmd.Parameters.AddWithValue("@TotalSpend", decimal.TryParse(txtTotalSpend.Text.Trim(), out decimal totalSpend) ? totalSpend : 0);
                    cmd.Parameters.AddWithValue("@LoyaltyCardNumber", txtCardNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@RewardPoints", (int)numPoints.Value);
                    cmd.Parameters.AddWithValue("@MembershipTier", cmbTier.Text);  // Use .Text
                    cmd.Parameters.AddWithValue("@LastFeedback", txtLastFeedback.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers();
                    ClearForm();
                    selectedCustomerId = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnnectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DeleteCustomer", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Customer deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers();
                    ClearForm();
                    selectedCustomerId = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting customer: " + ex.Message);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            // Clear TextBoxes
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();


            txtTotalVisits.Clear();
            txtTotalSpend.Clear();
            txtCardNo.Clear();
            txtLastFeedback.Clear();
            txtAddress.Clear();
            txtInstructions.Clear();
            txtSearchCustomer.Clear();

            // Reset ComboBoxes
            cmbGender.SelectedIndex = 0;
            cmbDietary.SelectedIndex = 0;
            cmbTime.SelectedIndex = 0;
            cmbTier.SelectedIndex = 0;
            cmbFavorites.SelectedIndex = 0;
            // Reset NumericUpDown
            numPoints.Value = 0;
            cmbTable.SelectedIndex = 0;
            // Reset DateTimePickers
            dtpDOB.Value = DateTime.Now;
            dtpLastVisit.Value = DateTime.Now;

            // Reset selected customer ID
            selectedCustomerId = -1;


        }
        private void LoadGenderInCustomers()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllGenders", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Add default row
                DataRow defaultRow = dt.NewRow();
                defaultRow["GenderName"] = "-- Select Gender --";
                dt.Rows.InsertAt(defaultRow, 0);

                cmbGender.DataSource = dt;
                cmbGender.DisplayMember = "GenderName";
                cmbGender.ValueMember = "GenderName"; // ✅ Set ValueMember
                cmbGender.SelectedIndex = 0;
                cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(ConnnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetAllCustomerInfo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvCustomers.DataSource = dt;
            }
        }
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                selectedCustomerId = Convert.ToInt32(row.Cells["CustomerID"].Value);

                txtName.Text = row.Cells["FullName"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                cmbGender.SelectedValue = row.Cells["Gender"].Value.ToString();//
                cmbFavorites.SelectedValue = row.Cells["FavoriteItems"].Value.ToString();//changed
                cmbDietary.SelectedValue = row.Cells["DietaryPreferences"].Value.ToString();//
                cmbTable.SelectedValue = Convert.ToInt32(row.Cells["PreferredTable"].Value);//
                cmbTime.SelectedValue = row.Cells["UsualVisitTime"].Value.ToString();//
                txtTotalVisits.Text = row.Cells["TotalVisits"].Value.ToString();
                dtpLastVisit.Value = Convert.ToDateTime(row.Cells["LastVisit"].Value);
                txtTotalSpend.Text = row.Cells["TotalSpend"].Value.ToString();
                txtCardNo.Text = row.Cells["LoyaltyCardNumber"].Value.ToString();
                numPoints.Value = Convert.ToInt32(row.Cells["RewardPoints"].Value);
                cmbTier.SelectedValue = row.Cells["MembershipTier"].Value.ToString();//
                txtLastFeedback.Text = row.Cells["LastFeedback"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtInstructions.Text = row.Cells["DeliveryInstructions"].Value.ToString();
            }

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void LoadDietaryPreferenceInCustomers()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllDietaryPreferences", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["PreferenceName"] = "-- Select DietaryPreferences --";
                dt.Rows.InsertAt(defaultRow, 0);

                cmbDietary.DataSource = dt;
                cmbDietary.DisplayMember = "PreferenceName";
                cmbDietary.ValueMember = "PreferenceName"; // ✅ Set ValueMember
                cmbDietary.SelectedIndex = 0;
                cmbDietary.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void LoadCafeTables()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                string query = "SELECT TableID, TableNumber FROM CafeTable";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Insert a default "Select Table" row at the top
                DataRow defaultRow = dt.NewRow();
                defaultRow["TableNumber"] = "-- Select Table --";
                defaultRow["TableID"] = 0;
                dt.Rows.InsertAt(defaultRow, 0);

                cmbTable.DataSource = dt;
                cmbTable.DisplayMember = "TableNumber";
                cmbTable.ValueMember = "TableID";

                cmbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void LoadMenuItems()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                string query = "SELECT * FROM MenuItem";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Insert a default "Select MenuItem" row at the top
                DataRow defaultRow = dt.NewRow();
                defaultRow["ItemName"] = "-- Select MenuItem --"; // assuming ItemName is the display column
                defaultRow["ItemID"] = 0;                         // assuming ItemID is the key column
                dt.Rows.InsertAt(defaultRow, 0);

                cmbFavorites.DataSource = dt;
                cmbFavorites.DisplayMember = "ItemName";  // Change to actual display column in MenuItem table
                cmbFavorites.ValueMember = "ItemName";      // Change to actual ID column in MenuItem table

                // Set DropDownStyle to DropDownList
                cmbFavorites.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void LoadUsualTimeInCustomers()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllVisitTimes", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["TimeSlot"] = "-- Select Usual Time --";
                dt.Rows.InsertAt(defaultRow, 0);

                cmbTime.DataSource = dt;
                cmbTime.DisplayMember = "TimeSlot";
                cmbTime.ValueMember = "TimeSlot"; // ✅ Set ValueMember
                cmbTime.SelectedIndex = 0;
                cmbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void LoadMembershipTierInCustomers()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllMembershipTiers", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["TierName"] = "-- Select Membership Tier --";
                dt.Rows.InsertAt(defaultRow, 0);

                cmbTier.DataSource = dt;
                cmbTier.DisplayMember = "TierName";
                cmbTier.ValueMember = "TierName"; // ✅ Set ValueMember
                cmbTier.SelectedIndex = 0;
                cmbTier.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void txtSearchCustomer_textchanged(object sender, EventArgs e)
        {
            string searchText = txtSearchCustomer.Text.Trim();

            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchCustomers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchText", searchText);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCustomers.DataSource = dt;
                }
            }
        }
        private void CustomerManagmentByStaff_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadGenderInCustomers();
            LoadDietaryPreferenceInCustomers();
            LoadCafeTables();
            LoadMenuItems();
            LoadUsualTimeInCustomers();
            LoadMembershipTierInCustomers();
            LoadCustomers(); // last
        }
    }
}
