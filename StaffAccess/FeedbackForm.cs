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
using static MELTADO_CAFE.Login_Page;

namespace MELTADO_CAFE.StaffAccess
{
    public partial class FeedbackForm : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;
        public FeedbackForm()
        {
            InitializeComponent();
            LoadCustomers();
        }
        private void PlaceHolder_TextLoad()
        {
            // Full Name
            txtComments.PlaceholderText = "--Comments goes here--";


        }
        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT CustomerID, FullName FROM Customers ORDER BY FullName";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCustomer.DataSource = dt;
                cmbCustomer.DisplayMember = "FullName";
                cmbCustomer.ValueMember = "CustomerID";
                cmbCustomer.DropDownStyle = ComboBoxStyle.DropDown; // allows typing
                cmbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
            int staffId = LoggedInUser.UserId; // You should set this from login session
            int rating = (int)nudRating.Value;
            string comment = txtComments.Text.Trim();

            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Please enter a comment.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = @"
            INSERT INTO CustomerFeedback (CustomerID, StaffID, Rating, Comments)
            VALUES (@CustomerID, @StaffID, @Rating, @Comments)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@StaffID", staffId);
                cmd.Parameters.AddWithValue("@Rating", rating);
                cmd.Parameters.AddWithValue("@Comments", comment);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Feedback submitted successfully!");
            }
        }

    }
}
