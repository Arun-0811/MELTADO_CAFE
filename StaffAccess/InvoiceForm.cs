using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static MELTADO_CAFE.Login_Page;
using System.Drawing.Printing;
using System.Windows.Forms.VisualStyles;

namespace MELTADO_CAFE.StaffAccess
{
    public partial class InvoiceForm : Form
    {

        string ConStr = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;
        private int orderId;
        PrintDocument printDoc = new PrintDocument();
        Font printFont = new Font("Arial", 10);

        public InvoiceForm(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            LoadInvoiceDetails(orderId);
        }

        private void LoadInvoiceDetails(int orderId)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlCommand cmd = new SqlCommand("sp_GetInvoiceDetails", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Header Data
                    lblInvoiceNo.Text = "Invoice #: INV-" + orderId.ToString("D4");
                    lblOrderDate.Text = Convert.ToDateTime(dt.Rows[0]["OrderDate"]).ToString("yyyy-MM-dd");
                    lblCustomerName.Text = dt.Rows[0]["CustomerName"].ToString();
                    lblTableID.Text = dt.Rows[0]["TableNumber"].ToString();
                    lblPaymentMethod.Text = dt.Rows[0]["PaymentMethod"].ToString();
                    lblOrderStatus.Text = dt.Rows[0]["OrderStatus"].ToString();

                    // Prepare grid display table
                    DataTable displayTable = new DataTable();
                    displayTable.Columns.Add("Item Name", typeof(string));
                    displayTable.Columns.Add("Quantity", typeof(int));
                    displayTable.Columns.Add("Unit Price", typeof(decimal));
                    displayTable.Columns.Add("Line Total", typeof(decimal));

                    foreach (DataRow row in dt.Rows)
                    {
                        displayTable.Rows.Add(
                            row["ItemName"],
                            row["Quantity"],
                            row["UnitPrice"],
                            row["TotalPrice"]
                        );
                    }

                    dgvInvoiceItems.DataSource = displayTable;

                    // Format Grid
                    dgvInvoiceItems.Columns["Item Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvInvoiceItems.Columns["Unit Price"].DefaultCellStyle.Format = "0.00";
                    dgvInvoiceItems.Columns["Line Total"].DefaultCellStyle.Format = "0.00";

                    dgvInvoiceItems.ReadOnly = true;
                    dgvInvoiceItems.AllowUserToAddRows = false;
                    dgvInvoiceItems.RowHeadersVisible = false;

                    // Totals Calculation
                    decimal subtotal = displayTable.AsEnumerable().Sum(r => r.Field<decimal>("Line Total"));
                    decimal tax = Math.Round(subtotal * 0.08m, 2); // 8% tax
                    decimal discount = 0m; // Optional
                    decimal grandTotal = subtotal + tax - discount;

                    lblSubTotal.Text = subtotal.ToString("0.00");
                    lblTaxPercentage.Text = tax.ToString("0.00");
                    lblDiscount.Text = discount.ToString("0.00");
                    lblgrandTotal.Text = grandTotal.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Invoice data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertInvoice", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OrderID", orderId);
                cmd.Parameters.AddWithValue("@InvoiceNumber", "INV-" + orderId.ToString("D4"));
                cmd.Parameters.AddWithValue("@CustomerName", lblCustomerName.Text);
                cmd.Parameters.AddWithValue("@TableNumber", lblTableID.Text);
                cmd.Parameters.AddWithValue("@PaymentMethod", lblPaymentMethod.Text);
                cmd.Parameters.AddWithValue("@OrderStatus", lblOrderStatus.Text);
                cmd.Parameters.AddWithValue("@Subtotal", Decimal.Parse(lblSubTotal.Text));
                cmd.Parameters.AddWithValue("@Tax", Decimal.Parse(lblTaxPercentage.Text));
                cmd.Parameters.AddWithValue("@Discount", Decimal.Parse(lblDiscount.Text));
                cmd.Parameters.AddWithValue("@GrandTotal", Decimal.Parse(lblgrandTotal.Text));
                cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserId); // ✅ This is where you place it

                SqlParameter outId = new SqlParameter("@InvoiceID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outId);

                con.Open();
                cmd.ExecuteNonQuery();
                int invoiceId = (int)outId.Value;

                MessageBox.Show($"Invoice #{invoiceId} saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);
            previewDialog.Document = printDoc;
            previewDialog.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float contentWidth = 500;
            float x = e.MarginBounds.Left + (e.MarginBounds.Width - contentWidth) / 2; // Center X
            float y = 20;
            float lineHeight = printFont.GetHeight(e.Graphics) + 6;

            float logoX = x + contentWidth - 110; // Push logo to right inside the border
            float logoY = y + 20;

            // Draw outer border
            e.Graphics.DrawRectangle(Pens.Black, x - 10, y - 10, contentWidth, 600); // Adjust height as needed

            // Optional Logo (Top-Right inside border)
            if (pictureBoxLogo.Image != null)
            {
                e.Graphics.DrawImage(pictureBoxLogo.Image, new Rectangle((int)logoX, (int)logoY, 100, 100));
            }

            // Title - Centered
            string title = "MELTADO CAFE - INVOICE";
            SizeF titleSize = e.Graphics.MeasureString(title, new Font("Arial", 16, FontStyle.Bold));
            float titleX = x + (contentWidth - titleSize.Width) / 2;
            e.Graphics.DrawString(title, new Font("Arial", 16, FontStyle.Bold), Brushes.DarkSlateBlue, titleX, y);
            y += lineHeight * 2;

            // Header Info Box
            RectangleF headerBox = new RectangleF(x, y, contentWidth - 20, lineHeight * 6);
            e.Graphics.DrawRectangle(Pens.Gray, Rectangle.Round(headerBox));

            e.Graphics.DrawString(lblInvoiceNo.Text, printFont, Brushes.Black, x + 10, y); y += lineHeight;
            e.Graphics.DrawString(lblOrderDate.Text, printFont, Brushes.Black, x + 10, y); y += lineHeight;
            e.Graphics.DrawString("Customer: " + lblCustomerName.Text, printFont, Brushes.Black, x + 10, y); y += lineHeight;
            e.Graphics.DrawString("Table: " + lblTableID.Text, printFont, Brushes.Black, x + 10, y); y += lineHeight;
            e.Graphics.DrawString("Payment: " + lblPaymentMethod.Text, printFont, Brushes.Black, x + 10, y); y += lineHeight;
            e.Graphics.DrawString("Status: " + lblOrderStatus.Text, printFont, Brushes.Black, x + 10, y); y += lineHeight + 5;

            // Item Header Box
            e.Graphics.FillRectangle(Brushes.LightGray, x, y, contentWidth - 20, lineHeight);
            e.Graphics.DrawRectangle(Pens.Black, x, y, contentWidth - 20, lineHeight);

            e.Graphics.DrawString("Item", printFont, Brushes.Black, x + 5, y);
            e.Graphics.DrawString("Qty", printFont, Brushes.Black, x + 200, y);
            e.Graphics.DrawString("Rate", printFont, Brushes.Black, x + 280, y);
            e.Graphics.DrawString("Total", printFont, Brushes.Black, x + 370, y);
            y += lineHeight;

            // Items
            foreach (DataGridViewRow row in dgvInvoiceItems.Rows)
            {
                if (row.IsNewRow) continue;

                e.Graphics.DrawString(row.Cells[0].Value?.ToString(), printFont, Brushes.Black, x + 5, y);
                e.Graphics.DrawString(row.Cells[1].Value?.ToString(), printFont, Brushes.Black, x + 200, y);
                e.Graphics.DrawString(Convert.ToDecimal(row.Cells[2].Value).ToString("0.00"), printFont, Brushes.Black, x + 280, y);
                e.Graphics.DrawString(Convert.ToDecimal(row.Cells[3].Value).ToString("0.00"), printFont, Brushes.Black, x + 370, y);
                y += lineHeight;
            }

            y += 10;
            e.Graphics.DrawLine(Pens.Black, x, y, x + contentWidth - 20, y);
            y += 10;

            // Totals Box
            RectangleF totalBox = new RectangleF(x, y, contentWidth - 20, lineHeight * 4.5f);
            e.Graphics.DrawRectangle(Pens.Gray, Rectangle.Round(totalBox));

            e.Graphics.DrawString(lblSubTotal.Text, printFont, Brushes.Black, x + 10, y); y += lineHeight;
            e.Graphics.DrawString(lblTaxPercentage.Text, printFont, Brushes.Black, x + 10, y); y += lineHeight;
            e.Graphics.DrawString(lblDiscount.Text, printFont, Brushes.Black, x + 10, y); y += lineHeight;
            e.Graphics.DrawString(lblgrandTotal.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.DarkRed, x + 10, y);
            y += lineHeight + 10;

            // Footer Message - Padded
            float footerY = y + 20;
            string footer = "Thank you for visiting MELTADO Cafe!";
            SizeF footerSize = e.Graphics.MeasureString(footer, new Font("Arial", 10, FontStyle.Italic));
            float footerX = x + (contentWidth - footerSize.Width) / 2;

            e.Graphics.DrawString(footer, new Font("Arial", 10, FontStyle.Italic), Brushes.DarkGreen, footerX, footerY);
        }

    }
}
