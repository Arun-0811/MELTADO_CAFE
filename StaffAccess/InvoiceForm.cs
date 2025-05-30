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
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using static MELTADO_CAFE.Login_Page;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace MELTADO_CAFE
{
    public partial class InvoiceForm : Form
    {
        private readonly string _connectionString;
        private readonly int _invoiceId;

        public InvoiceForm(int invoiceId)
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;
            _invoiceId = invoiceId;

            // Configure form appearance
            this.Text = $"Invoice #{invoiceId}";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            SetupDataGridViews();
            LoadInvoiceData();
        }

        private void SetupDataGridViews()
        {
            // Configure header DataGridView
            dgvHeader.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
            dgvHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHeader.RowHeadersVisible = false;
            dgvHeader.AllowUserToAddRows = false;
            dgvHeader.ReadOnly = true;
            dgvHeader.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configure items DataGridView
            dgvItems.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.RowHeadersVisible = false;
            dgvItems.AllowUserToAddRows = false;
            dgvItems.ReadOnly = true;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configure payment DataGridView
            dgvPayments.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.ReadOnly = true;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadInvoiceData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetInvoiceDetails", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InvoiceID", _invoiceId);
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // 1. Load Header Data
                        if (reader.HasRows)
                        {
                            DataTable headerTable = new DataTable();
                            headerTable.Load(reader);
                            dgvHeader.DataSource = headerTable;

                            if (headerTable.Rows.Count > 0)
                            {
                                DataRow row = headerTable.Rows[0];
                                lblInvoiceTitle.Text = $"INVOICE #{row["InvoiceNumber"]}";
                                lblDate.Text = $"Date: {Convert.ToDateTime(row["InvoiceDate"]):dd/MM/yyyy}";
                                lblStatus.Text = $"Status: {row["PaymentStatus"]}";
                                lblSubtotal.Text = $"Subtotal: {Convert.ToDecimal(row["Subtotal"]):C}";
                                lblTax.Text = $"Tax: {Convert.ToDecimal(row["TaxAmount"]):C}";
                                lblTotal.Text = $"Total: {Convert.ToDecimal(row["TotalAmount"]):C}";
                            }
                        }

                        // 2. Load Items Data
                        if (reader.HasRows)
                        {
                            DataTable itemsTable = new DataTable();
                            itemsTable.Load(reader);
                            dgvItems.DataSource = itemsTable;
                        }

                        // 3. Load Payments Data
                        if (reader.HasRows)
                        {
                            DataTable paymentsTable = new DataTable();
                            paymentsTable.Load(reader);
                            dgvPayments.DataSource = paymentsTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading invoice data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Optionally disable buttons to prevent further use
                btnMarkAsPaid.Enabled = true;
                btnPrint.Enabled = false;

                // Do NOT close the form here
                // this.Close();  ← Remove this
            }

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExportInvoiceAsPDF();
        }

        private void ExportInvoiceAsPDF()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    Title = "Save Invoice",
                    FileName = $"MeltadoCafe_Invoice_{_invoiceId}_{DateTime.Now:yyyyMMdd}.pdf"
                })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                            PdfWriter.GetInstance(document, fs);
                            document.Open();

                            // Title
                            Paragraph title = new Paragraph("MELTADO CAFE - CUSTOMER INVOICE",
                                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.DarkGray))
                            {
                                Alignment = Element.ALIGN_CENTER
                            };
                            document.Add(title);

                            // Invoice Info
                            Paragraph info = new Paragraph(
                                $"Invoice ID: {_invoiceId}\nGenerated on: {DateTime.Now:yyyy-MM-dd HH:mm}\n",
                                FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.Gray))
                            {
                                Alignment = Element.ALIGN_CENTER
                            };
                            document.Add(info);
                            document.Add(new Paragraph("\n"));

                            // --- Header Info Table ---
                            if (dgvHeader.DataSource is DataTable headerTable && headerTable.Rows.Count > 0)
                            {
                                PdfPTable headerPdfTable = new PdfPTable(headerTable.Columns.Count)
                                {
                                    WidthPercentage = 100
                                };

                                foreach (DataColumn col in headerTable.Columns)
                                {
                                    PdfPCell headerCell = new PdfPCell(new Phrase(col.ColumnName,
                                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9)))
                                    {
                                        BackgroundColor = new BaseColor(230, 230, 230),
                                        Padding = 4,
                                        HorizontalAlignment = Element.ALIGN_CENTER
                                    };
                                    headerPdfTable.AddCell(headerCell);
                                }

                                foreach (DataRow row in headerTable.Rows)
                                {
                                    foreach (object cell in row.ItemArray)
                                    {
                                        headerPdfTable.AddCell(new PdfPCell(new Phrase(cell.ToString(),
                                            FontFactory.GetFont(FontFactory.HELVETICA, 9)))
                                        { Padding = 4 });
                                    }
                                }

                                document.Add(headerPdfTable);
                                document.Add(new Paragraph("\n"));
                            }

                            // --- Items Table ---
                            if (dgvItems.DataSource is DataTable itemsTable && itemsTable.Rows.Count > 0)
                            {
                                Paragraph itemSection = new Paragraph("Ordered Items",
                                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.Black));
                                document.Add(itemSection);
                                document.Add(new Paragraph("\n"));

                                PdfPTable itemPdfTable = new PdfPTable(itemsTable.Columns.Count)
                                {
                                    WidthPercentage = 100
                                };

                                foreach (DataColumn col in itemsTable.Columns)
                                {
                                    PdfPCell headerCell = new PdfPCell(new Phrase(col.ColumnName,
                                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9)))
                                    {
                                        BackgroundColor = new BaseColor(230, 230, 230),
                                        Padding = 4,
                                        HorizontalAlignment = Element.ALIGN_CENTER
                                    };
                                    itemPdfTable.AddCell(headerCell);
                                }

                                foreach (DataRow row in itemsTable.Rows)
                                {
                                    foreach (object cell in row.ItemArray)
                                    {
                                        itemPdfTable.AddCell(new PdfPCell(new Phrase(cell.ToString(),
                                            FontFactory.GetFont(FontFactory.HELVETICA, 9)))
                                        { Padding = 4 });
                                    }
                                }

                                document.Add(itemPdfTable);
                                document.Add(new Paragraph("\n"));
                            }

                            // --- Payment Info Table ---
                            if (dgvPayments.DataSource is DataTable paymentsTable && paymentsTable.Rows.Count > 0)
                            {
                                Paragraph paymentSection = new Paragraph("Payment Details",
                                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.Black));
                                document.Add(paymentSection);
                                document.Add(new Paragraph("\n"));

                                PdfPTable paymentPdfTable = new PdfPTable(paymentsTable.Columns.Count)
                                {
                                    WidthPercentage = 100
                                };

                                foreach (DataColumn col in paymentsTable.Columns)
                                {
                                    PdfPCell headerCell = new PdfPCell(new Phrase(col.ColumnName,
                                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9)))
                                    {
                                        BackgroundColor = new BaseColor(230, 230, 230),
                                        Padding = 4,
                                        HorizontalAlignment = Element.ALIGN_CENTER
                                    };
                                    paymentPdfTable.AddCell(headerCell);
                                }

                                foreach (DataRow row in paymentsTable.Rows)
                                {
                                    foreach (object cell in row.ItemArray)
                                    {
                                        paymentPdfTable.AddCell(new PdfPCell(new Phrase(cell.ToString(),
                                            FontFactory.GetFont(FontFactory.HELVETICA, 9)))
                                        { Padding = 4 });
                                    }
                                }

                                document.Add(paymentPdfTable);
                            }

                            document.Close();
                        }

                        MessageBox.Show($"Invoice saved successfully to:\n{saveFileDialog.FileName}",
                            "Invoice Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating invoice:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMarkAsPaid_Click(object sender, EventArgs e)
        {
            try
            {
                using (PaymentDialog paymentDialog = new PaymentDialog(_invoiceId))
                {
                    if (paymentDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (SqlConnection connection = new SqlConnection(_connectionString))
                        using (SqlCommand cmd = new SqlCommand("sp_UpdateInvoicePayment", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@InvoiceID", _invoiceId);
                            cmd.Parameters.AddWithValue("@PaymentStatus", "Paid");
                            cmd.Parameters.AddWithValue("@PaymentMethod", paymentDialog.PaymentMethod);
                            cmd.Parameters.AddWithValue("@Notes", $"Paid on {DateTime.Now:g}");
                            cmd.Parameters.AddWithValue("@UpdatedBy", LoggedInUser.UserId);

                            connection.Open();
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Invoice marked as paid successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the display
                        LoadInvoiceData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating payment status: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }

    // Simple payment dialog (create as separate form)
    public class PaymentDialog : Form
        {
            public string PaymentMethod { get; private set; }
            private readonly int _invoiceId;

            public PaymentDialog(int invoiceId)
            {
                _invoiceId = invoiceId;
                InitializeComponents();
            }

            private void InitializeComponents()
            {
                this.Text = "Record Payment";
                this.Size = new Size(300, 200);
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.StartPosition = FormStartPosition.CenterParent;

                Label lblAmount = new Label { Text = "Amount:", Left = 20, Top = 20 };
                TextBox txtAmount = new TextBox { Left = 100, Top = 20, Width = 150, ReadOnly = true };

                Label lblMethod = new Label { Text = "Method:", Left = 20, Top = 50 };
                ComboBox cmbMethod = new ComboBox { Left = 100, Top = 50, Width = 150 };
                cmbMethod.Items.AddRange(new[] { "Cash", "Credit Card", "Debit Card", "Bank Transfer" });

                Button btnOK = new Button { Text = "OK", Left = 100, Top = 100, DialogResult = DialogResult.OK };
                Button btnCancel = new Button { Text = "Cancel", Left = 180, Top = 100, DialogResult = DialogResult.Cancel };

                // Load invoice amount
                try
                {
                    string connStr = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;
                    using (SqlConnection connection = new SqlConnection(connStr))
                    using (SqlCommand cmd = new SqlCommand("SELECT TotalAmount FROM Invoices WHERE InvoiceID = @InvoiceID", connection))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceID", _invoiceId);
                        connection.Open();
                        decimal amount = Convert.ToDecimal(cmd.ExecuteScalar());
                        txtAmount.Text = amount.ToString("C");
                    }
                }
                catch { /* Handle error */ }

                this.Controls.AddRange(new Control[] { lblAmount, txtAmount, lblMethod, cmbMethod, btnOK, btnCancel });

                btnOK.Click += (s, e) =>
                {
                    if (cmbMethod.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a payment method", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = DialogResult.None;
                        return;
                    }

                    PaymentMethod = cmbMethod.SelectedItem.ToString();
                };
            }
        }
    
}
