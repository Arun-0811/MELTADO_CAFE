using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static MELTADO_CAFE.Login_Page;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MELTADO_CAFE
{
    public partial class SignUp_Page : Form
    {
        string ConnnectionString = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;
        public SignUp_Page()
        {
            InitializeComponent();
            this.Load += SignUp_Page_Load;
        }
        private void PlaceHolder_TextLoad()
        {
            // Full Name
            txt_uname.PlaceholderText = "Enter Full Name";

            // Phone Number
            txt_email.PlaceholderText = "Enter Email Address";

            // Email
            txt_pwd.PlaceholderText = "Enter Password";

            txtConfirmPwd.PlaceholderText = "Confirm Password";

            txtPnoneNo.PlaceholderText = "Phone Number";
        }
        private void SignUp_Page_Load(object sender, EventArgs e)
        {
            RoleSelect();
            PlaceHolder_TextLoad();
            LoadUsersToGrid();
        }
        private void LoadUsersToGrid()
        {
            using (SqlConnection conn = new SqlConnection(ConnnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Users";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewUsers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading users: " + ex.Message);
                }
            }
        }

        private void btn_close_click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void lnklbl_signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
            this.Close();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void RoleSelect()
        {
            using (SqlConnection conn = new SqlConnection(ConnnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetRoleNames", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Add default item at the top
                DataRow defaultRow = dt.NewRow();
                defaultRow["RoleName"] = "-- Select Role --";
                dt.Rows.InsertAt(defaultRow, 0);

                // Bind to ComboBox
                cmb_role.DataSource = dt;
                cmb_role.DisplayMember = "RoleName";
                cmb_role.ValueMember = "RoleId"; // Or RoleId if available
                cmb_role.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            string username = txt_uname.Text.Trim();
            string email = txt_email.Text.Trim();
            string phone = txtPnoneNo.Text.Trim(); // Optional
            string password = txt_pwd.Text.Trim();
            String confirmPassword = txtConfirmPwd.Text.Trim();
            int roleId = 0;

            if (cmb_role.SelectedValue != null && cmb_role.SelectedValue != DBNull.Value)
            {
                roleId = Convert.ToInt32(cmb_role.SelectedValue);
                if (roleId == 2 || roleId > 3)
                {
                    MessageBox.Show("You are not an Admin or Manager to to Add Staff's");
                }
            }

            int createdBy = LoggedInUser.UserId; // Get from login session
            int isValid = toggleBtn.Checked ? 1 : 0;

            // Validation
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.");
                txt_uname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                txt_email.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(phone) && !Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.");
                txtPnoneNo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters.");
                txt_pwd.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                txtConfirmPwd.Focus();
                return;
            }

            if (cmb_role.SelectedIndex <= 0 || cmb_role.SelectedValue == null || cmb_role.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Please select a valid role.");
                cmb_role.Focus();
                return;
            }
            if (password == confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
            }

            using (SqlConnection conn = new SqlConnection(ConnnectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("RegisterUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@PasswordHash", password);
                        cmd.Parameters.AddWithValue("@RoleId", roleId);
                        cmd.Parameters.AddWithValue("@CreatedBy", createdBy);
                        cmd.Parameters.AddWithValue("@IsValid", isValid);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User registered successfully.");

                        // Clear inputs
                        txt_uname.Clear();
                        txt_email.Clear();
                        txtPnoneNo.Clear();
                        txt_pwd.Clear();
                        RoleSelect(); // Refill role combobox
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the click is on a valid row (not header)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];

                // Example: Set form fields with clicked row data
                txt_uname.Text = row.Cells["Username"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
                txtPnoneNo.Text = row.Cells["Phone"].Value?.ToString();
                txt_pwd.Text = row.Cells["PasswordHash"].Value?.ToString(); // if visible
                toggleBtn.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);

                // Select role in ComboBox
                int selectedRoleId = Convert.ToInt32(row.Cells["RoleId"].Value);
                cmb_role.SelectedValue = selectedRoleId;
            }
        }
        private void UpdateUser()
        {
            if (dataGridViewUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user from the grid to update.");
                return;
            }

            try
            {
                int userId = Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["UserId"].Value);
                string username = txt_uname.Text.Trim();
                string email = txt_email.Text.Trim();
                string phone = txtPnoneNo.Text.Trim();
                string password = txt_pwd.Text.Trim();
                int roleId = Convert.ToInt32(cmb_role.SelectedValue);
                int isActive = toggleBtn.Checked ? 1 : 0;
                int CreatedBy = LoggedInUser.UserId;

                using (SqlConnection conn = new SqlConnection(ConnnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UpdateUser", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@PasswordHash", password); // Ensure hashing if needed
                    cmd.Parameters.AddWithValue("@RoleId", roleId);
                    cmd.Parameters.AddWithValue("@IsActive", isActive);
                    cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully.");
                        LoadUsersToGrid(); // reload updated grid
                        ClearTextBoxes();  // optional: clear form
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearTextBoxes()
        {
            txt_uname.Clear();
            txt_pwd.Clear();
            cmb_role.SelectedIndex = 0; // Reset to default item like "-- Select Role --"
            txt_email.Clear();
            txtConfirmPwd.Clear();
            txtPnoneNo.Clear();
            toggleBtn.Checked = false;

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void DeleteUser()
        {
            if (dataGridViewUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user from the grid to delete.");
                return;
            }

            try
            {
                int userId = Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["UserId"].Value);

                var confirmResult = MessageBox.Show("Are you sure you want to delete this user?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                    return;

                using (SqlConnection conn = new SqlConnection(ConnnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        int result = cmd.ExecuteNonQuery();

                        // Your stored procedure returns 0 or 1 via RETURN statement, 
                        // but ExecuteNonQuery returns affected rows count.
                        // To get return value, use a parameter (see below).

                        // For now, check rows affected:
                        if (result > 0)
                        {
                            MessageBox.Show("User deleted successfully.");
                            LoadUsersToGrid();
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. User not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
    }
}
