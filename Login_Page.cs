using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MELTADO_CAFE
{
    public partial class Login_Page : Form
    {
        string ConnnectionString = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;
        public Login_Page()
        {
            InitializeComponent();
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
        private void lmklbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp_Page signUp_Page = new SignUp_Page();
            signUp_Page.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void lnklbl_forgotpwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPwd_Page forgotPwd_Page = new ForgotPwd_Page();
            forgotPwd_Page.Show();
            this.Hide();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ClearTextBoxes()
        {
            txt_uname.Clear();
            txt_pwd.Clear();
            cmb_role.SelectedIndex = 0; // Reset to first role like "Admin"
            txt_uname.Focus(); // Optional: Set focus back to username
        }

        public static class LoggedInUser
        {
            public static int UserId { get; set; }
            public static string Username { get; set; }
            public static string Email { get; set; }
            public static int RoleId { get; set; }

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            string username = txt_uname.Text.Trim();
            string password = txt_pwd.Text.Trim();
            int roleId = 0;

            if (cmb_role.SelectedValue != null && cmb_role.SelectedValue != DBNull.Value)
            {
                roleId = Convert.ToInt32(cmb_role.SelectedValue);
            } // e.g., "Admin", "Manager", "Staff"

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }



            using (SqlConnection conn = new SqlConnection(ConnnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("ValidateUserLogin", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Correct parameter names and values
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@RoleId", roleId); // ✅ FIXED

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Store in static class
                            LoggedInUser.UserId = Convert.ToInt32(reader["UserId"]);
                            LoggedInUser.Username = reader["Username"].ToString();
                            LoggedInUser.Email = reader["Email"].ToString();
                            LoggedInUser.RoleId = Convert.ToInt32(reader["RoleId"]);
                            string roleName = reader["RoleName"].ToString(); // ✅ Include RoleName from your SELECT
                            int IsActive = Convert.ToInt32(reader["IsActive"]);
                            if (IsActive == 0)
                            {
                                MessageBox.Show($"You are Inactive User {username}");
                            }

                            MessageBox.Show($"{roleName} login successful!");

                            // Redirect based on role
                            if (roleName == "Admin" || roleName == "Manager")
                            {
                                
                                AdminForm adminForm = new AdminForm();
                                adminForm.Show();
                            }
                            else if (roleName == "Staff")
                            {
                                CustomerForm staffForm = new CustomerForm();
                                staffForm.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username, password, or role.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login failed: " + ex.Message);
                }
            }

        }



        private void btnClearall_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {
            RoleSelect();
        }
    }
}
