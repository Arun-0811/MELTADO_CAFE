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
            string selectedRole = toggleBtn.Checked? "Admin" : "Staff"; // Toggle button for Admin

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
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@RoleName", selectedRole);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Store in static class
                            LoggedInUser.UserId = Convert.ToInt32(reader["UserId"]);
                            LoggedInUser.Username = reader["Username"].ToString();
                            LoggedInUser.Email = reader["Email"].ToString();
                            LoggedInUser.RoleId = Convert.ToInt32(reader["RoleId"]);

                            // Admin credentials check (Example: hardcoded)
                            if (username == "Admin" && password == "12345" && selectedRole == "Admin")
                            {
                                // Redirect to Admin page
                                MessageBox.Show($"{selectedRole} login successful!");
                                AdminForm adminForm = new AdminForm();
                                adminForm.Show();
                                this.Hide();
                                
                            }
                            else
                            {
                                // Redirect to Customer page
                                MessageBox.Show($"{selectedRole} login successful!");
                                CustomerForm customerForm = new CustomerForm();
                                customerForm.Show();
                                this.Hide();
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login failed: " + ex.Message);
                }
            }
        }
    }
}
