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

namespace MELTADO_CAFE.AdminAccess
{
    public partial class CustomerFeedBackForm : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;

        public CustomerFeedBackForm()
        {
            InitializeComponent();
            LoadFeedbackData();
            PlaceHolder_TextLoad();
        }
        private void PlaceHolder_TextLoad()
        {
            // Full Name
            txtCustomerName.PlaceholderText = "Selected Customer Name shown here";

            // Phone Number
            txtComments.PlaceholderText = "Selected Grid View Comments shown Here";


        }
        private void LoadFeedbackData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT 
                                f.FeedbackID,
                                c.FullName AS CustomerName,
                                u.Username AS StaffName,
                                f.Rating,
                                f.Comments,
                                f.SubmittedAt
                            FROM CustomerFeedback f
                            INNER JOIN Customers c ON f.CustomerID = c.CustomerID
                            INNER JOIN Staff s ON f.StaffID = s.StaffID
                            INNER JOIN Users u ON s.UserId = u.UserId
                            ORDER BY f.SubmittedAt DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFeedback.DataSource = dt;
            }
        }

        private void dgvFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFeedback.Rows[e.RowIndex];

                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtComments.Text = row.Cells["Comments"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvFeedback.ClearSelection();         // Deselect any selected row
            txtCustomerName.Clear();              // Clear textboxes
            txtComments.Clear();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btn_close_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
