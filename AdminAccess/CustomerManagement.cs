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
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MELTADO_CAFE
{
    public partial class CustomerManagement : Form
    {
        string ConnnectionString = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;

        private int selectedCustomerId = -1;

        int selectedGenderID = 0;

        int selectedPreferenceID = 0;

        int selectedVisitTimeID = 0;

        int selectedTierID = 0;

        public CustomerManagement()
        {
            InitializeComponent();
            LoadCustomers();
            LoadGenderInCustomers();
            LoadDietaryPreferenceInCustomers();
            LoadUsualTimeInCustomers();
            LoadMembershipTierInCustomers();
        }

        private enum LoadedDataType
        {
            None,
            Gender,
            DietaryPreference,
            VisitTime,
            MembershipTier
        }

        private LoadedDataType currentDataType = LoadedDataType.None;


        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            PlaceHolder_TextLoad();
            LoadMenuItems();
            LoadGenders(); // Default load
            ShowControls("Gender");
            HighlightActiveButton(btn_btn_genderclickload);
            LoadCafeTables();

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


        private void PlaceHolder_TextLoad()
        {
            // Full Name
            txtName.PlaceholderText = "Enter Full Name";

            // Phone Number
            txtPhone.PlaceholderText = "Enter Phone Number";

            // Email
            txtEmail.PlaceholderText = "Enter Email Address";


            // Loyalty Card
            txtCardNo.PlaceholderText = "Enter Loyalty Card Number";

            // Feedback
            txtLastFeedback.PlaceholderText = "Enter Feedback";

            // Address
            txtAddress.PlaceholderText = "Enter Address";

            //Totalo Visits
            txtTotalVisits.PlaceholderText = "Enter Total Visits";

            //Total Spends
            txtTotalSpend.PlaceholderText = "Enter Total Spends";

            // Instructions
            txtInstructions.PlaceholderText = "Enter Special Instructions";



            // Optionally, validate Date of Birth if needed
            dtpDOB.Value = DateTime.Today;


            //Categories Values Add
            txt_gendercmblist.PlaceholderText = "Enter Your Gender List";
            txt_dietarylist.PlaceholderText = "Enter Your Dietary List";
            txt_usualtimelist.PlaceholderText = "Enter Your Time List";
            txt_membershiptierlist.PlaceholderText = "Enter Your Tier List";
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

        private void PopUptoolTip_Popup(object sender, PopupEventArgs e)
        {

        }



        private void btn_btn_add_Click(object sender, EventArgs e)
        {

            bool isAnyInput = false;

            if (!string.IsNullOrWhiteSpace(txt_gendercmblist.Text))
            {
                isAnyInput = true;
                using (SqlConnection con = new SqlConnection(ConnnectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertGender", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@GenderName", txt_gendercmblist.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                txt_gendercmblist.Clear();
                LoadGenders();
            }

            if (!string.IsNullOrWhiteSpace(txt_dietarylist.Text))
            {
                isAnyInput = true;
                using (SqlConnection con = new SqlConnection(ConnnectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertDietaryPreference", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PreferenceName", txt_dietarylist.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                txt_dietarylist.Clear();
                LoadDietaryPreferences();
            }

            if (!string.IsNullOrWhiteSpace(txt_usualtimelist.Text))
            {
                isAnyInput = true;
                using (SqlConnection con = new SqlConnection(ConnnectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertVisitTime", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TimeSlot", txt_usualtimelist.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                txt_usualtimelist.Clear();
                LoadVisitTimes();
            }

            if (!string.IsNullOrWhiteSpace(txt_membershiptierlist.Text))
            {
                isAnyInput = true;
                using (SqlConnection con = new SqlConnection(ConnnectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertMembershipTier", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TierName", txt_membershiptierlist.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                txt_membershiptierlist.Clear();
                LoadTiers();
            }

            if (!isAnyInput)
            {
                MessageBox.Show("Please enter data in at least one field.");
            }
        }

        private void btn_btn_SAVE_Click(object sender, EventArgs e)
        {

            bool isAnyUpdated = false;

            // Gender update
            if (selectedGenderID != 0 && !string.IsNullOrWhiteSpace(txt_gendercmblist.Text))
            {
                using (SqlConnection con = new SqlConnection(ConnnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateGender", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@GenderID", selectedGenderID);
                    cmd.Parameters.AddWithValue("@GenderName", txt_gendercmblist.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                txt_gendercmblist.Clear();
                selectedGenderID = 0;
                LoadGenders();
                isAnyUpdated = true;
            }

            // Dietary Preference update
            if (selectedPreferenceID != 0 && !string.IsNullOrWhiteSpace(txt_dietarylist.Text))
            {
                using (SqlConnection con = new SqlConnection(ConnnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateDietaryPreference", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DietaryPreferenceID", selectedPreferenceID);
                    cmd.Parameters.AddWithValue("@PreferenceName", txt_dietarylist.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                txt_dietarylist.Clear();
                selectedPreferenceID = 0;
                LoadDietaryPreferences();
                isAnyUpdated = true;
            }

            // Usual Time update
            if (selectedVisitTimeID != 0 && !string.IsNullOrWhiteSpace(txt_usualtimelist.Text))
            {
                using (SqlConnection con = new SqlConnection(ConnnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateVisitTime", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VisitTimeID", selectedVisitTimeID);
                    cmd.Parameters.AddWithValue("@TimeSlot", txt_usualtimelist.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                txt_usualtimelist.Clear();
                selectedVisitTimeID = 0;
                LoadVisitTimes();
                isAnyUpdated = true;
            }

            // Membership Tier update
            if (selectedTierID != 0 && !string.IsNullOrWhiteSpace(txt_membershiptierlist.Text))
            {
                using (SqlConnection con = new SqlConnection(ConnnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateMembershipTier", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TierID", selectedTierID);
                    cmd.Parameters.AddWithValue("@TierName", txt_membershiptierlist.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                txt_membershiptierlist.Clear();
                selectedTierID = 0;
                LoadTiers();
                isAnyUpdated = true;
            }

            if (!isAnyUpdated)
            {
                MessageBox.Show("Please select at least one item to update with valid input.");
            }
        }

        private void btn_btn_DELETE_Click(object sender, EventArgs e)
        {

            bool isAnyDeleted = false;

            // Gender Delete
            if (selectedGenderID != 0)
            {
                DialogResult Genderconfirm = MessageBox.Show("Are you sure you want to delete this gender?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (Genderconfirm == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConnnectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DeleteGender", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@GenderID", selectedGenderID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    txt_gendercmblist.Clear();
                    selectedGenderID = 0;
                    LoadGenders();
                    isAnyDeleted = true;
                }
            }

            // Dietary Preference Delete
            if (selectedPreferenceID != 0)
            {
                var Dietaryconfirm = MessageBox.Show("Are you sure you want to delete this preference?", "Confirm", MessageBoxButtons.YesNo);
                if (Dietaryconfirm == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConnnectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DeleteDietaryPreference", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DietaryPreferenceID", selectedPreferenceID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    txt_dietarylist.Clear();
                    selectedPreferenceID = 0;
                    LoadDietaryPreferences();
                    isAnyDeleted = true;
                }
            }

            // Usual Time Delete
            if (selectedVisitTimeID != 0)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this time slot?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConnnectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DeleteVisitTime", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@VisitTimeID", selectedVisitTimeID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    txt_usualtimelist.Clear();
                    selectedVisitTimeID = 0;
                    LoadVisitTimes();
                    isAnyDeleted = true;
                }
            }

            // Membership Tier Delete
            if (selectedTierID != 0)
            {
                var Membershipconfirm = MessageBox.Show("Are you sure you want to delete this tier?", "Confirm", MessageBoxButtons.YesNo);
                if (Membershipconfirm == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConnnectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DeleteMembershipTier", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TierID", selectedTierID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    txt_membershiptierlist.Clear();
                    selectedTierID = 0;
                    LoadTiers();
                    isAnyDeleted = true;
                }
            }

            if (!isAnyDeleted)
            {
                MessageBox.Show("Please select at least one item to delete.");
            }
        }

        private void GridView_CustomerPreference_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header clicks

            var row = GridView_CustomerPreference.Rows[e.RowIndex];

            switch (currentDataType)
            {
                case LoadedDataType.Gender:
                    selectedGenderID = row.Cells["GenderID"].Value != DBNull.Value
                        ? Convert.ToInt32(row.Cells["GenderID"].Value)
                        : 0;
                    txt_gendercmblist.Text = row.Cells["GenderName"].Value?.ToString() ?? "";
                    ClearOtherSelections("Gender");
                    break;

                case LoadedDataType.DietaryPreference:
                    selectedPreferenceID = row.Cells["DietaryPreferenceID"].Value != DBNull.Value
                        ? Convert.ToInt32(row.Cells["DietaryPreferenceID"].Value)
                        : 0;
                    txt_dietarylist.Text = row.Cells["PreferenceName"].Value?.ToString() ?? "";
                    ClearOtherSelections("DietaryPreference");
                    break;

                case LoadedDataType.VisitTime:
                    selectedVisitTimeID = row.Cells["VisitTimeID"].Value != DBNull.Value
                        ? Convert.ToInt32(row.Cells["VisitTimeID"].Value)
                        : 0;
                    txt_usualtimelist.Text = row.Cells["TimeSlot"].Value?.ToString() ?? "";
                    ClearOtherSelections("VisitTime");
                    break;

                case LoadedDataType.MembershipTier:
                    selectedTierID = row.Cells["TierID"].Value != DBNull.Value
                        ? Convert.ToInt32(row.Cells["TierID"].Value)
                        : 0;
                    txt_membershiptierlist.Text = row.Cells["TierName"].Value?.ToString() ?? "";
                    ClearOtherSelections("MembershipTier");
                    break;

                default:
                    ClearAllSelections();
                    break;
            }
        }


        private void ClearOtherSelections(string except)
        {
            if (except != "Gender")
            {
                selectedGenderID = 0;
                txt_gendercmblist.Clear();
            }
            if (except != "DietaryPreference")
            {
                selectedPreferenceID = 0;
                txt_dietarylist.Clear();
            }
            if (except != "VisitTime")
            {
                selectedVisitTimeID = 0;
                txt_usualtimelist.Clear();
            }
            if (except != "MembershipTier")
            {
                selectedTierID = 0;
                txt_membershiptierlist.Clear();
            }
        }

        private void ClearAllSelections()
        {
            selectedGenderID = 0;
            txt_gendercmblist.Clear();
            selectedPreferenceID = 0;
            txt_dietarylist.Clear();
            selectedVisitTimeID = 0;
            txt_usualtimelist.Clear();
            selectedTierID = 0;
            txt_membershiptierlist.Clear();
        }

        private void btn_btn_CLEAR_Click(object sender, EventArgs e)
        {
            txt_gendercmblist.Clear();
            txt_dietarylist.Clear();
            txt_usualtimelist.Clear();
            txt_membershiptierlist.Clear();
        }

        private void LoadGenders()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllGenders", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView_CustomerPreference.DataSource = dt;
                currentDataType = LoadedDataType.Gender;
                ;

            }
        }

        private void LoadDietaryPreferences()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllDietaryPreferences", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView_CustomerPreference.DataSource = dt;
                currentDataType = LoadedDataType.DietaryPreference;


            }
        }

        private void LoadVisitTimes()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllVisitTimes", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView_CustomerPreference.DataSource = dt;
                currentDataType = LoadedDataType.VisitTime;

            }
        }

        private void LoadTiers()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetAllMembershipTiers", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView_CustomerPreference.DataSource = dt;
                currentDataType = LoadedDataType.MembershipTier;


            }
        }

        private void btn_btn_genderclickload_Click(object sender, EventArgs e)
        {
            LoadGenders();
            ShowControls("Gender");
            HighlightActiveButton((Button)sender);
        }

        private void btn_btn_dietaryclickload_Click(object sender, EventArgs e)
        {
            LoadDietaryPreferences();
            ShowControls("Dietary");
            HighlightActiveButton((Button)sender);
        }

        private void btn_btn_usualtimeload_Click(object sender, EventArgs e)
        {
            LoadVisitTimes();
            ShowControls("VisitTime");
            HighlightActiveButton((Button)sender);
        }

        private void btn_btn_membershipclickload_Click(object sender, EventArgs e)
        {
            LoadTiers();
            ShowControls("Membership");
            HighlightActiveButton((Button)sender);
        }

        // Show/hide controls based on current section
        private void ShowControls(string type)
        {
            txt_gendercmblist.Visible = false;
            txt_dietarylist.Visible = false;
            txt_usualtimelist.Visible = false;
            txt_membershiptierlist.Visible = false;

            txt_gendercmblist.Clear();
            txt_dietarylist.Clear();
            txt_usualtimelist.Clear();
            txt_membershiptierlist.Clear();

            switch (type)
            {
                case "Gender":
                    txt_gendercmblist.Visible = true;
                    txt_gendercmblist.Focus();
                    break;
                case "Dietary":
                    txt_dietarylist.Visible = true;
                    txt_dietarylist.Focus();
                    break;
                case "VisitTime":
                    txt_usualtimelist.Visible = true;
                    txt_usualtimelist.Focus();
                    break;
                case "Membership":
                    txt_membershiptierlist.Visible = true;
                    txt_membershiptierlist.Focus();
                    break;
            }
        }

        // Highlight the active button
        private void HighlightActiveButton(Button activeButton)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.Name.StartsWith("btn"))
                {
                    btn.BackColor = SystemColors.Control; // default
                }
            }

            activeButton.BackColor = Color.LightBlue; // highlight
        }
        private void SetComboBoxValue(ComboBox comboBox, string value)
        {
            if (!string.IsNullOrEmpty(value) && comboBox.Items.Contains(value))
            {
                comboBox.SelectedItem = value;
            }
            else
            {
                comboBox.SelectedIndex = 0; // fallback to default like "-- Select --"
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        
    }
}
