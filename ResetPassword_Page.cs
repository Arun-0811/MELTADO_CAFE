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


namespace MELTADO_CAFE
{
    public partial class ResetPassword_Page : Form
    {
        string ConnnectionString = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;

        public ResetPassword_Page()
        {
            InitializeComponent();            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();
            string newPassword = txt_newpwd.Text.Trim();
            string confirmPassword = txt_confirmpwd.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter both email and new password.");
                return;
            }
            if(newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_UpdateUserPassword", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Pass parameters to the stored procedure
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", newPassword);  // Consider hashing here

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.");
                        
                        //clear textboxes
                        txt_email.Clear();
                        txt_newpwd.Clear();
                        txt_confirmpwd.Clear();
                        Login_Page loginPage = new Login_Page();
                        loginPage.Show();
                        this.Hide();
                    }                     
                    else
                    {
                        MessageBox.Show("Password Updating Failed.");
                    }
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
