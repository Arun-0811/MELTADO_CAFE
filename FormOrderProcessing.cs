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

namespace MELTADO_CAFE
{
    public partial class FormOrderProcessing : Form
    {
        string ConStr = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;


        public FormOrderProcessing()
        {
            InitializeComponent();
        }


        private void FormOrderProcessing_Load(object sender, EventArgs e)
        {
            PlaceHolder_TextLoad();
            LoadTablesToComboBox();
            LoadMenuItemsToGrid();
            InitializeOrderGrid();
        }
        private void PlaceHolder_TextLoad()
        {
            txt_ItemName.PlaceholderText = "Select Item Name";
            txtQTY.PlaceholderText = "Enter Item Quantity";
            txtUniPrice.PlaceholderText = "Enter Item Price";

        }
        private void LoadTablesToComboBox()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlCommand cmd = new SqlCommand("GetAvailableOrAllTables", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTableNumber.DataSource = dt;
                cmbTableNumber.DisplayMember = "TableNumber"; // What user sees
                cmbTableNumber.ValueMember = "TableID";       // What you use internally
                cmbTableNumber.DropDownStyle = ComboBoxStyle.DropDownList;

            }

        }

        private void LoadMenuItemsToGrid()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlCommand cmd = new SqlCommand("GetMenuItemNamesAndPrices", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMenuItems.DataSource = dt;

                // Optional formatting
                dgvMenuItems.Columns["ItemName"].HeaderText = "Menu Item";
                dgvMenuItems.Columns["Price"].HeaderText = "Price (₹)";
                dgvMenuItems.Columns["Price"].DefaultCellStyle.Format = "C2"; // Currency format
            }
        }

        private void dgvMenuItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure it's not the header row
            {
                DataGridViewRow row = dgvMenuItems.Rows[e.RowIndex];

                txt_ItemName.Text = row.Cells["ItemName"].Value?.ToString();
                txtUniPrice.Text = row.Cells["Price"].Value?.ToString();
            }
        }

        private void ClearMenuItemTextBoxes()
        {
            txt_ItemName.Clear();
            txtQTY.Clear();
            txtUniPrice.Clear();
            cmbPaymentMethod.SelectedIndex = -1; // Reset to no selection
            cmbTableNumber.SelectedIndex = -1; // Reset to no selection
        }


        private void btnSearchBocItems_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchItems.Text.Trim();

            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchMeniItemandPrice", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchText", searchText);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMenuItems.DataSource = dt;
                }
            }
        }

        private void CalculateTotalPrice()
        {
            // Try parsing quantity and unit price
            bool isQtyValid = int.TryParse(txtQTY.Text.Trim(), out int quantity);
            bool isPriceValid = decimal.TryParse(txtUniPrice.Text.Trim(), out decimal unitPrice);

            if (isQtyValid && isPriceValid)
            {
                decimal total = quantity * unitPrice;
                txtTotalAmount.Text = total.ToString("0.00"); // Format to 2 decimal places
            }
            else
            {
                txtTotalAmount.Text = "0.00"; // Reset if invalid input
            }
        }

        private void InitializeOrderGrid()
        {

            dataGridViewOrder.Columns.Add("TableNo", "Seat Number");
            dataGridViewOrder.Columns.Add("ItemName", "Item Name");
            dataGridViewOrder.Columns.Add("Quantity", "Quantity");
            dataGridViewOrder.Columns.Add("UnitPrice", "Unit Price");
            dataGridViewOrder.Columns.Add("Total", "Total");
            dataGridViewOrder.Columns.Add("PayMode", "Payment Mode");
        }
        private void btn_itemADD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ItemName.Text) || string.IsNullOrWhiteSpace(txtQTY.Text))
            {
                MessageBox.Show("Item Name and Quantity are required.");
                return;
            }
            string TableNo = cmbTableNumber.SelectedValue?.ToString() ?? "Not Specified";
            string itemName = txt_ItemName.Text.Trim();
            int qty = int.Parse(txtQTY.Text);
            decimal unitPrice = decimal.Parse(txtUniPrice.Text);
            decimal total = qty * unitPrice;
            string PayMode = cmbPaymentMethod.SelectedItem?.ToString() ?? "Not Specified";

            dataGridViewOrder.Rows.Add(TableNo, itemName, qty, unitPrice, total, PayMode);
            ClearMenuItemTextBoxes();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void cmbTableNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                using (SqlCommand cmd = new SqlCommand("OrderTableNumberwithStatus", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TableID", Convert.ToInt32(cmbTableNumber.SelectedValue));

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtTableStatus.Text = reader["Status"].ToString();
                        }
                        else
                        {
                            txtTableStatus.Text = "Unknown";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return; // Handle the exception gracefully, maybe log it or show a message
            }
        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.SelectedRows.Count > 0)
            {
                dataGridViewOrder.Rows.RemoveAt(dataGridViewOrder.SelectedRows[0].Index);
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.Rows.Count == 0)
            {
                MessageBox.Show("No items to place order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridViewOrder.Rows)
            {
                if (row.IsNewRow) continue; // Skip new row placeholder

                int tableNo = Convert.ToInt32(row.Cells["TableNo"].Value);
                string itemName = row.Cells["ItemName"].Value?.ToString();
                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                decimal total = Convert.ToDecimal(row.Cells["Total"].Value);
                string paymentMethod = row.Cells["PayMode"].Value?.ToString();

                InsertOrder(tableNo, itemName, qty, unitPrice, total, paymentMethod);
            }

            dataGridViewOrder.Rows.Clear();
        }

        private void InsertOrder(int tableNumber, string itemName, int qty, decimal unitPrice, decimal total, string paymentMethod)
        {
            int currentUserId = LoggedInUser.UserId; // Assuming LoggedInUser.UserId is set after login
            using (SqlConnection con = new SqlConnection(ConStr))
            using (SqlCommand cmd = new SqlCommand("InsertOrder", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TableID", tableNumber);
                cmd.Parameters.AddWithValue("@ItemName", itemName);
                cmd.Parameters.AddWithValue("@ItemQty", qty);
                cmd.Parameters.AddWithValue("@ItemUnitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@TotalAmount", total);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@OrderStatus", "Placed"); // Static or use dropdown
                cmd.Parameters.AddWithValue("@CreatedBy", currentUserId);


                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearMenuItemTextBoxes();
        }
    }
}
