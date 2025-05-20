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
        }

        private void SignUp_Page_Load(object sender, EventArgs e)
        {
            RoleSelect();
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
                cmb_role.ValueMember = "RoleName"; // Or RoleId if available
                cmb_role.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            string username = txt_uname.Text;
            string email = txt_email.Text;
            string password = txt_pwd.Text;
            string roleName = cmb_role.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(ConnnectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("RegisterUserByRole", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); // Hash before if needed
                        cmd.Parameters.AddWithValue("@RoleName", roleName);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Data inserted successfully.");

                        //clear textboxes
                        txt_uname.Clear();
                        txt_email.Clear();
                        txt_pwd.Clear();
                        RoleSelect(); // Reset to default item
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
    }
}
