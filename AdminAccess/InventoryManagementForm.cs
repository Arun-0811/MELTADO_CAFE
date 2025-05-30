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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Font = System.Drawing.Font;

namespace MELTADO_CAFE
{
    public partial class InventoryManagementForm : Form
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString);

        public InventoryManagementForm()
        {
            InitializeComponent();
            LoadIngredients();
            SetupDataGridView();
            timer1.Start(); // Start the timer when the form loads
        }

        private void SetupDataGridView()
        {
            // Configure appearance
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredients.RowHeadersVisible = false;
            dgvIngredients.AllowUserToAddRows = false;
            dgvIngredients.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;

            // Enable sorting
            foreach (DataGridViewColumn column in dgvIngredients.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void LoadIngredients()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT IngredientID, IngredientName, CurrentStock, " +
                    "UnitOfMeasure, ReorderLevel, CostPerUnit, " +
                    "CASE WHEN IsActive = 1 THEN 'Active' ELSE 'Inactive' END AS Status " +
                    "FROM Ingredients", connection);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvIngredients.DataSource = dt;

                // Format columns
                dgvIngredients.Columns["CurrentStock"].DefaultCellStyle.Format = "N2";
                dgvIngredients.Columns["ReorderLevel"].DefaultCellStyle.Format = "N2";
                dgvIngredients.Columns["CostPerUnit"].DefaultCellStyle.Format = "C2";

                // Highlight low stock items
                foreach (DataGridViewRow row in dgvIngredients.Rows)
                {
                    decimal currentStock = Convert.ToDecimal(row.Cells["CurrentStock"].Value);
                    decimal reorderLevel = Convert.ToDecimal(row.Cells["ReorderLevel"].Value);

                    if (currentStock <= reorderLevel)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                        row.DefaultCellStyle.Font = new Font(dgvIngredients.Font, FontStyle.Bold);
                    }
                }

                // Update status bar
                lblRecordCount.Text = $"{dt.Rows.Count} ingredients in inventory";

                // Check for low stock items
                int lowStockCount = dt.AsEnumerable()
                    .Count(row => Convert.ToDecimal(row["CurrentStock"]) <= Convert.ToDecimal(row["ReorderLevel"]));

                lblLowStockAlert.Text = lowStockCount > 0
                    ? $"⚠️ {lowStockCount} items need restocking!"
                    : "All stock levels are good";
                lblLowStockAlert.ForeColor = lowStockCount > 0 ? Color.Red : Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ingredients: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        // Button Click Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            IngredientDetailForm detailForm = new IngredientDetailForm();
            if (detailForm.ShowDialog() == DialogResult.OK)
            {
                LoadIngredients(); // Refresh after adding
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvIngredients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ingredient to edit", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ingredientId = Convert.ToInt32(dgvIngredients.SelectedRows[0].Cells["IngredientID"].Value);
            IngredientDetailForm detailForm = new IngredientDetailForm(ingredientId);

            if (detailForm.ShowDialog() == DialogResult.OK)
            {
                LoadIngredients(); // Refresh after editing
            }
        }

        private void btnAdjustStock_Click(object sender, EventArgs e)
        {
            if (dgvIngredients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an ingredient first", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvIngredients.SelectedRows[0];

            // Extract all required parameters
            int ingredientId = Convert.ToInt32(selectedRow.Cells["IngredientID"].Value);
            string ingredientName = selectedRow.Cells["IngredientName"].Value.ToString();
            string unit = selectedRow.Cells["UnitOfMeasure"].Value.ToString();
            decimal currentStock = Convert.ToDecimal(selectedRow.Cells["CurrentStock"].Value);
            decimal? reorderLevel = selectedRow.Cells["ReorderLevel"].Value as decimal?;

            // Initialize form with full context
            StockAdjustmentForm adjustForm = new StockAdjustmentForm(
                ingredientId: ingredientId,
                ingredientName: ingredientName,
                unitOfMeasure: unit,
                currentStock: currentStock,
                reorderLevel: reorderLevel
            );

            // Handle the result
            if (adjustForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh data and show success
                LoadIngredients();

                // Visual feedback for the adjusted item
                selectedRow.Selected = true;
                dgvIngredients.FirstDisplayedScrollingRowIndex = selectedRow.Index;

                MessageBox.Show($"{ingredientName} stock updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            LowStockReportForm reportForm = new LowStockReportForm();
            reportForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadIngredients();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    Title = "Save Inventory Report",
                    FileName = $"MeltadoCafe_Inventory_{DateTime.Now:yyyyMMdd}.pdf"
                })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4.Rotate(), 25, 25, 30, 30);
                            PdfWriter.GetInstance(document, fs);

                            document.Open();

                            // Title
                            Paragraph title = new Paragraph("MELTADO CAFE - INVENTORY REPORT",
                                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.DarkGray))
                            {
                                Alignment = Element.ALIGN_CENTER
                            };
                            document.Add(title);

                            // Subtitle
                            Paragraph subtitle = new Paragraph($"Generated on: {DateTime.Now:yyyy-MM-dd HH:mm}",
                                FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.Gray))
                            {
                                Alignment = Element.ALIGN_CENTER
                            };
                            document.Add(subtitle);

                            document.Add(new Paragraph("\n"));

                            // Build PDF table
                            int visibleColumnCount = dgvIngredients.Columns.Cast<DataGridViewColumn>().Count(c => c.Visible);
                            PdfPTable table = new PdfPTable(visibleColumnCount)
                            {
                                WidthPercentage = 100
                            };

                            // Add headers
                            foreach (DataGridViewColumn column in dgvIngredients.Columns)
                            {
                                if (!column.Visible) continue;

                                PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText,
                                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                                {
                                    BackgroundColor = new BaseColor(240, 240, 240),
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    Padding = 5
                                };
                                table.AddCell(headerCell);
                            }

                            // Add data rows
                            foreach (DataGridViewRow row in dgvIngredients.Rows)
                            {
                                if (row.IsNewRow) continue;

                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (!cell.OwningColumn.Visible) continue;

                                    string cellValue = cell.Value?.ToString() ?? "";

                                    // Format numeric values
                                    if (cell.OwningColumn.Name == "CurrentStock" ||
                                        cell.OwningColumn.Name == "ReorderLevel" ||
                                        cell.OwningColumn.Name == "CostPerUnit")
                                    {
                                        if (decimal.TryParse(cellValue, out decimal numVal))
                                        {
                                            cellValue = cell.OwningColumn.Name == "CostPerUnit"
                                                ? numVal.ToString("C2")
                                                : numVal.ToString("N2");
                                        }
                                    }

                                    // Highlight low stock
                                    BaseColor textColor = BaseColor.Black;
                                    if (cell.OwningColumn.Name == "CurrentStock" &&
                                        row.Cells["ReorderLevel"].Value != DBNull.Value &&
                                        decimal.TryParse(cell.Value?.ToString(), out decimal currentStock) &&
                                        decimal.TryParse(row.Cells["ReorderLevel"].Value?.ToString(), out decimal reorderLevel) &&
                                        currentStock <= reorderLevel)
                                    {
                                        textColor = BaseColor.Red;
                                    }

                                    PdfPCell pdfCell = new PdfPCell(new Phrase(cellValue,
                                        FontFactory.GetFont(FontFactory.HELVETICA, 9, textColor)))
                                    {
                                        Padding = 5
                                    };

                                    table.AddCell(pdfCell);
                                }
                            }

                            document.Add(table);

                            // Add summary warning
                            int lowStockCount = CountLowStockItems();
                            if (lowStockCount > 0)
                            {
                                Paragraph warning = new Paragraph($"\n⚠ {lowStockCount} item(s) below reorder level!",
                                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.Red));
                                document.Add(warning);
                            }

                            document.Close();
                        }

                        MessageBox.Show($"Report saved successfully to:\n{saveFileDialog.FileName}",
                            "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int CountLowStockItems()
{
    int count = 0;
    foreach (DataGridViewRow row in dgvIngredients.Rows)
    {
        if (!row.IsNewRow && 
            row.Cells["CurrentStock"].Value != null && 
            row.Cells["ReorderLevel"].Value != null)
        {
            decimal currentStock = Convert.ToDecimal(row.Cells["CurrentStock"].Value);
            decimal reorderLevel = Convert.ToDecimal(row.Cells["ReorderLevel"].Value);
            if (currentStock <= reorderLevel) count++;
        }
    }
    return count;
}
    }
}
