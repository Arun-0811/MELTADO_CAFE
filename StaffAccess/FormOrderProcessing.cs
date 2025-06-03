using MELTADO_CAFE.StaffAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            LoadActiveReservations();
            dataGridOrderItems.CellValueChanged += dataGridOrderItems_CellValueChanged;

        }


        private void FormOrderProcessing_Load(object sender, EventArgs e)
        {
            PlaceHolder_TextLoad();

            LoadMenuItemsToGrid();
            InitializeOrderGrid();
        }
        private void PlaceHolder_TextLoad()
        {
            txtTableNumber.PlaceholderText = "Enter Table Number";
            txtCustomerName.PlaceholderText = "Enter Customer Name";

            txtPhone.PlaceholderText = "Enter Phone Number";
            txtUnitPrice.PlaceholderText = "Enter Items price";
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMenuItems.Rows[e.RowIndex];
                txtMenuItem.Text = row.Cells["ItemName"].Value.ToString();
                txtUnitPrice.Text = row.Cells["Price"].Value.ToString();
                numericUpDownQuantity.Value = 1; // default
            }
        }

        private void ClearMenuItemTextBoxes()
        {
            txtMenuItem.Clear();
            comboBoxReservation.SelectedIndex = -1;
            comboBoxOrderStatus.SelectedIndex = -1;
            txtTableNumber.Clear();
            txtCustomerName.Clear();

            comboBoxPaymentMethod.SelectedIndex = -1; // Reset to no selection
            txtPhone.Clear(); // Reset to no selection
            txtUnitPrice.Clear();
            numericUpDownQuantity.Value = 1; // Reset to default value
            dgvMenuItems.ClearSelection();

        }


        private void btnSearchBocItems_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchItems.Text.Trim();
            if (String.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Search Input Empty, Please provide name to search...!");
            }

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

        //private void CalculateTotalPrice()
        //{
        //    // Try parsing quantity and unit price
        //    bool isQtyValid = int.TryParse(txtQTY.Text.Trim(), out int quantity);
        //    bool isPriceValid = decimal.TryParse(txtUniPrice.Text.Trim(), out decimal unitPrice);

        //    if (isQtyValid && isPriceValid)
        //    {
        //        decimal total = quantity * unitPrice;
        //        txtTotalAmount.Text = total.ToString("0.00"); // Format to 2 decimal places
        //    }
        //    else
        //    {
        //        txtTotalAmount.Text = "0.00"; // Reset if invalid input
        //    }
        //}

        private void InitializeOrderGrid()
        {
            // Clear existing columns
            dataGridOrderItems.Columns.Clear();

            // Table Number (from reserved table)
            dataGridOrderItems.Columns.Add("TableNumber", "SeatNumber");

            // Item Name
            dataGridOrderItems.Columns.Add("ItemName", "Item Name");

            // Quantity
            DataGridViewTextBoxColumn qtyCol = new DataGridViewTextBoxColumn();
            qtyCol.Name = "Quantity";
            qtyCol.HeaderText = "Qty";
            qtyCol.ValueType = typeof(int);
            qtyCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridOrderItems.Columns.Add(qtyCol);

            // Unit Price
            DataGridViewTextBoxColumn unitPriceCol = new DataGridViewTextBoxColumn();
            unitPriceCol.Name = "UnitPrice";
            unitPriceCol.HeaderText = "Unit Price (₹)";
            unitPriceCol.ValueType = typeof(decimal);
            unitPriceCol.DefaultCellStyle.Format = "N2";
            unitPriceCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridOrderItems.Columns.Add(unitPriceCol);

            // Total
            DataGridViewTextBoxColumn totalCol = new DataGridViewTextBoxColumn();
            totalCol.Name = "Total";
            totalCol.HeaderText = "Total (₹)";
            totalCol.ValueType = typeof(decimal);
            totalCol.DefaultCellStyle.Format = "C2";
            totalCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            totalCol.ReadOnly = true; // Total should be calculated, not edited
            dataGridOrderItems.Columns.Add(totalCol);

            // Payment Mode (optional: could also be a ComboBox outside this grid)
            dataGridOrderItems.Columns.Add("PaymentMode", "Payment Method");

            // Optional: Auto-size columns for better readability
            dataGridOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        //private void btn_itemADD_Click(object sender, EventArgs e)
        //{
        //    string itemName = txt_ItemName.Text.Trim();
        //    string qtyText = txtQTY.Text.Trim();
        //    string unitPriceText = txtUniPrice.Text.Trim().Replace(",", ".");
        //    string tableIdText = txtTblBookedId.Text.Trim();

        //    // Basic validation
        //    if (string.IsNullOrEmpty(itemName) ||
        //        string.IsNullOrEmpty(qtyText) ||
        //        string.IsNullOrEmpty(unitPriceText) ||
        //        string.IsNullOrEmpty(tableIdText))
        //    {
        //        MessageBox.Show("All fields are required.", "Validation Error");
        //        return;
        //    }

        //    if (!int.TryParse(tableIdText, out int tableBookedId) || tableBookedId <= 0)
        //    {
        //        MessageBox.Show("Invalid Table ID.", "Input Error");
        //        return;
        //    }

        //    if (!int.TryParse(qtyText, out int qty) || qty <= 0)
        //    {
        //        MessageBox.Show("Invalid Quantity.", "Input Error");
        //        return;
        //    }

        //    if (!decimal.TryParse(unitPriceText, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal unitPrice) || unitPrice <= 0)
        //    {
        //        MessageBox.Show("Invalid Unit Price.", "Input Error");
        //        return;
        //    }

        //    if (comboBoxPaymentMethod.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Please select a payment method.", "Validation Error");
        //        return;
        //    }

        //    decimal total = qty * unitPrice;
        //    string payMode = comboBoxPaymentMethod.SelectedItem?.ToString() ?? "Not Specified";

        //    try
        //    {
        //        // Columns: TableID, ItemName, Quantity, UnitPrice, Total, PaymentMethod
        //        dataGridOrderItems.Rows.Add(tableBookedId, itemName, qty, unitPrice, total, payMode);
        //        RecalculateTotalAmount();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error adding item to order list: " + ex.Message, "DataGrid Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    // Optional: Clear inputs
        //    // ClearMenuItemTextBoxes();
        //}






        //private void txtQty_TextChanged(object sender, EventArgs e)
        //{
        //    CalculateTotalPrice();
        //}
        public class OrderedItem
        {
            public string ItemName { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
        }


        //private void PlaceOrderAndGetInvoiceId()
        //{
        //    try
        //    {
        //        // 1. Validate inputs
        //        if (string.IsNullOrWhiteSpace(txtTblBookedId.Text) ||
        //            string.IsNullOrWhiteSpace(txt_ItemName.Text) ||
        //            string.IsNullOrWhiteSpace(txtQTY.Text) ||
        //            string.IsNullOrWhiteSpace(txtUniPrice.Text) || string.IsNullOrWhiteSpace(txtAllTotalAmount.Text) ||
        //            cmbPaymentMethod.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Please fill in all fields before placing the order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // 2. Parse and validate values
        //        if (!int.TryParse(txtTblBookedId.Text.Trim(), out int tableId) || tableId <= 0)
        //        {
        //            MessageBox.Show("Invalid Table ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        if (!int.TryParse(txtQTY.Text.Trim(), out int qty) || qty <= 0)
        //        {
        //            MessageBox.Show("Invalid Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        if (!decimal.TryParse(txtUniPrice.Text.Trim().Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal unitPrice) || unitPrice <= 0)
        //        {
        //            MessageBox.Show("Invalid Unit Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }




        //        decimal totalAmount = qty * unitPrice;
        //        string itemName = txt_ItemName.Text.Trim();
        //        string paymentMethod = cmbPaymentMethod.SelectedItem?.ToString() ?? "Not Specified";

        //        // 3. Place order and get invoice ID
        //        foreach (var item in orderedItemsList)
        //        {
        //            using (SqlConnection itemConn = new SqlConnection(ConStr))
        //            {
        //                itemConn.Open();

        //                using (SqlCommand itemCmd = new SqlCommand("InsertOrder", itemConn))
        //            {
        //                    itemCmd.CommandType = CommandType.StoredProcedure;

        //                    itemCmd.Parameters.AddWithValue("@TableID", tableId);
        //                    itemCmd.Parameters.AddWithValue("@ItemName", itemName);
        //                    itemCmd.Parameters.AddWithValue("@ItemQty", qty);
        //                    itemCmd.Parameters.AddWithValue("@ItemUnitPrice", unitPrice);
        //                    itemCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
        //                    itemCmd.Parameters.AddWithValue("@AllTotalAmt", decimal.Parse(txtAllTotalAmount.Text));
        //                    itemCmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
        //                    itemCmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserId); // Ensure this is valid

        //                using (SqlDataReader reader = cmd.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        var orderIdRaw = reader["OrderID"]?.ToString();
        //                        var invoiceIdRaw = reader["InvoiceID"]?.ToString();

        //                        MessageBox.Show($"DEBUG: OrderID={orderIdRaw}, InvoiceID={invoiceIdRaw}");

        //                        int.TryParse(orderIdRaw, out int orderId);
        //                        int.TryParse(invoiceIdRaw, out int invoiceId);

        //                        MessageBox.Show($"Order placed successfully!\nOrder ID: {orderId}\nInvoice ID: {invoiceId}",
        //                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                        // Open the invoice form
        //                        InvoiceForm invoiceForm = new InvoiceForm(orderId);
        //                        invoiceForm.Show(); // or Show() if you prefer
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Order placed but no invoice ID returned.",
        //                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error placing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void PlaceOrderAndGetInvoiceId()
        //{
        //    try
        //    {
        //        // 1. Validate inputs
        //        if (string.IsNullOrWhiteSpace(txtTblBookedId.Text) ||
        //            string.IsNullOrWhiteSpace(txt_ItemName.Text) ||
        //            string.IsNullOrWhiteSpace(txtQTY.Text) ||
        //            string.IsNullOrWhiteSpace(txtUniPrice.Text) ||
        //            string.IsNullOrWhiteSpace(txtGrandTotal.Text) ||
        //            comboBoxPaymentMethod.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Please fill in all fields before placing the order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // 2. Parse values
        //        if (!int.TryParse(txtTblBookedId.Text.Trim(), out int tableId) || tableId <= 0)
        //        {
        //            MessageBox.Show("Invalid Table ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        if (!int.TryParse(txtQTY.Text.Trim(), out int qty) || qty <= 0)
        //        {
        //            MessageBox.Show("Invalid Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        if (!decimal.TryParse(txtUniPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal unitPrice) || unitPrice <= 0)
        //        {
        //            MessageBox.Show("Invalid Unit Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        if (!decimal.TryParse(txtGrandTotal.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal allTotalAmount))
        //        {
        //            MessageBox.Show("Invalid Total Amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        string itemName = txt_ItemName.Text.Trim();
        //        string paymentMethod = comboBoxPaymentMethod.SelectedItem?.ToString() ?? "Not Specified";

        //        decimal totalAmount = qty * unitPrice;

        //        // 3. Insert order and read back OrderID & InvoiceID
        //        using (SqlConnection conn = new SqlConnection(ConStr))
        //        {
        //            conn.Open();

        //            using (SqlCommand cmd = new SqlCommand("InsertOrder", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@TableID", tableId);
        //                cmd.Parameters.AddWithValue("@ItemName", itemName);
        //                cmd.Parameters.AddWithValue("@ItemQty", qty);
        //                cmd.Parameters.AddWithValue("@ItemUnitPrice", unitPrice);
        //                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
        //                cmd.Parameters.AddWithValue("@AllTotalAmt", allTotalAmount);
        //                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
        //                cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserId); // Make sure this is set

        //                using (SqlDataReader reader = cmd.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        int.TryParse(reader["OrderID"]?.ToString(), out int orderId);
        //                        int.TryParse(reader["InvoiceID"]?.ToString(), out int invoiceId);

        //                        MessageBox.Show($"Order placed successfully!\nOrder ID: {orderId}\nInvoice ID: {invoiceId}",
        //                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                        InvoiceForm invoiceForm = new InvoiceForm(orderId);
        //                        invoiceForm.Show();
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Order placed but no invoice ID returned.",
        //                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error placing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}




        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            if (dataGridOrderItems.SelectedRows.Count > 0)
            {
                dataGridOrderItems.Rows.RemoveAt(dataGridOrderItems.SelectedRows[0].Index);
                RecalculateTotalAmount();
            }
        }

        private void RecalculateTotalAmount()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dataGridOrderItems.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    decimal rowTotal;
                    if (decimal.TryParse(row.Cells["Total"].Value.ToString(), out rowTotal))
                    {
                        grandTotal += rowTotal;
                    }
                }
            }

            txtGrandTotal.Text = grandTotal.ToString();
        }


        //private void btnPlaceOrder_Click(object sender, EventArgs e)
        //{

        //    PlaceOrderAndGetInvoiceId();
        //}



        private void OpenInvoiceForm(int invoiceId)
        {
            InvoiceForm invoiceForm = new InvoiceForm(invoiceId);
            invoiceForm.Show(); // or ShowDialog() if you want it modal
        }




        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearMenuItemTextBoxes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOrderDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
        }



        //private void txtTblBookedId_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(ConStr))
        //        using (SqlCommand cmd = new SqlCommand("getbookedtable_Details", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@TableID", Convert.ToInt32(txtTblBookedId.Text));

        //            con.Open();
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    txtTableNumber.Text = reader["Status"]?.ToString();
        //                    txtCustomer.Text = reader["CustomerName"]?.ToString();
        //                    txtContactNumber.Text = reader["ContactNumber"]?.ToString();
        //                    txtCustomerName.Text = Convert.ToDateTime(reader["ReservationDate"]).ToString("yyyy-MM-dd");
        //                    txtOrderDate.Text = reader["ReservationTime"]?.ToString();
        //                    txtPartySize.Text = reader["PartySize"]?.ToString();
        //                    txtTimeOfDay.Text = reader["TimeOfDay"]?.ToString();
        //                    txtMembershipTier.Text = reader["MembershipTier"]?.ToString();
        //                    txtMemberCardNo.Text = reader["MemberCardNo"]?.ToString();
        //                    txtCustomerAddress.Text = reader["CustomerAddress"]?.ToString();
        //                    txtDietaryPreference.Text = reader["DietaryPreference"]?.ToString();
        //                    txtCreditPoint.Text = reader["CreditPoint"]?.ToString();
        //                }
        //                else
        //                {
        //                    txtTableNumber.Text = "Unknown";
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void LoadActiveReservations()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_GetActiveReservations", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Add default row
                DataRow defaultRow = dt.NewRow();
                defaultRow["DisplayText"] = "-- Select Reservation --";
                defaultRow["ReservationID"] = -1;
                dt.Rows.InsertAt(defaultRow, 0);

                comboBoxReservation.DataSource = dt;
                comboBoxReservation.DisplayMember = "DisplayText";
                comboBoxReservation.ValueMember = "ReservationID";
                comboBoxReservation.SelectedIndex = 0;
                comboBoxReservation.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void comboBoxReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxReservation.SelectedIndex > 0)
            {
                int reservationId = Convert.ToInt32(comboBoxReservation.SelectedValue);
                using (SqlConnection con = new SqlConnection(ConStr))
                using (SqlCommand cmd = new SqlCommand("sp_GetReservationDetailsByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTableNumber.Text = reader["TableNumber"].ToString();
                        txtCustomerName.Text = reader["FullName"].ToString();
                        txtPhone.Text = reader["PhoneNumber"].ToString();
                    }
                }
            }
        }

        private void CalculateCartTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridOrderItems.Rows)
            {
                if (row.Cells["Total"].Value != null)
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            txtGrandTotal.Text = total.ToString("0.00");
        }


        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMenuItem.Text) || string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                MessageBox.Show("Please select a menu item.");
                return;
            }

            if (comboBoxReservation.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a valid reservation.");
                return;
            }

            if (comboBoxPaymentMethod.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a valid payment method.");
                return;
            }

            string seatNumber = comboBoxReservation.Text; // for display, e.g., "Table 1 – John"
            string itemName = txtMenuItem.Text.Trim();

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            int qty = (int)numericUpDownQuantity.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            decimal total = unitPrice * qty;
            string paymentMode = comboBoxPaymentMethod.Text;

            // Add to the DataGridView
            dataGridOrderItems.Rows.Add(seatNumber, itemName, qty, unitPrice, total, paymentMode);

            // Recalculate total
            CalculateCartTotal();

            // Optional: clear selection after adding
            txtMenuItem.Clear();
            txtUnitPrice.Clear();
            numericUpDownQuantity.Value = 1;
        }


        private void dataGridOrderItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridOrderItems.Columns["Quantity"].Index ||
                            e.ColumnIndex == dataGridOrderItems.Columns["UnitPrice"].Index))
            {
                var row = dataGridOrderItems.Rows[e.RowIndex];
                if (decimal.TryParse(row.Cells["Quantity"].Value?.ToString(), out decimal qty) &&
                    decimal.TryParse(row.Cells["UnitPrice"].Value?.ToString(), out decimal price))
                {
                    row.Cells["Total"].Value = qty * price;
                }

                CalculateCartTotal();
            }
        }

        private void SaveOrderToDatabase()
        {
            if (dataGridOrderItems.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            int reservationID = Convert.ToInt32(comboBoxReservation.SelectedValue);
            string paymentMethod = comboBoxPaymentMethod.Text;
            string orderStatus = comboBoxOrderStatus.SelectedItem?.ToString() ?? "Pending";

            int createdBy = LoggedInUser.UserId; // Replace with actual user id
            decimal totalAmount = 0;

            // Calculate total
            foreach (DataGridViewRow row in dataGridOrderItems.Rows)
            {
                if (row.Cells["Total"].Value != null)
                    totalAmount += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            int orderId = 0;

            using (SqlConnection con = new SqlConnection(ConStr))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // 1. Insert main order
                    SqlCommand cmdOrder = new SqlCommand("sp_InsertOrder", con, transaction);
                    cmdOrder.CommandType = CommandType.StoredProcedure;
                    cmdOrder.Parameters.AddWithValue("@ReservationID", reservationID);
                    cmdOrder.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    cmdOrder.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    cmdOrder.Parameters.AddWithValue("@OrderStatus", orderStatus);
                    cmdOrder.Parameters.AddWithValue("@CreatedBy", createdBy);

                    SqlParameter outputIdParam = new SqlParameter("@OrderID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmdOrder.Parameters.Add(outputIdParam);

                    cmdOrder.ExecuteNonQuery();
                    orderId = Convert.ToInt32(outputIdParam.Value);

                    // 2. Insert each order item
                    foreach (DataGridViewRow row in dataGridOrderItems.Rows)
                    {
                        // Skip new rows or rows with missing data
                        if (row.IsNewRow || row.Cells["ItemName"].Value == null || row.Cells["Quantity"].Value == null || row.Cells["UnitPrice"].Value == null)
                            continue;

                        string itemName = row.Cells["ItemName"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);

                        int menuItemId = GetMenuItemIDByName(itemName); // Custom helper

                        SqlCommand cmdDetail = new SqlCommand("sp_InsertOrderDetail", con, transaction);
                        cmdDetail.CommandType = CommandType.StoredProcedure;
                        cmdDetail.Parameters.AddWithValue("@OrderID", orderId);
                        cmdDetail.Parameters.AddWithValue("@MenuItemID", menuItemId);
                        cmdDetail.Parameters.AddWithValue("@Quantity", quantity);
                        cmdDetail.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        
                        cmdDetail.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Order placed successfully!");
                    InvoiceForm invoiceForm = new InvoiceForm(orderId);
                    invoiceForm.ShowDialog(); // Show invoice form
                    // Optionally clear cart
                    dataGridOrderItems.Rows.Clear();
                    txtGrandTotal.Text = "0.00";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error placing order: " + ex.Message);
                }
            }
        }

        private int GetMenuItemIDByName(string itemName)
        {
            int itemId = 0;

            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT ItemID FROM MenuItem WHERE ItemName = @ItemName", con);
                cmd.Parameters.AddWithValue("@ItemName", itemName);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                    itemId = Convert.ToInt32(result);
            }

            return itemId;
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            SaveOrderToDatabase();
        }
    }
}
