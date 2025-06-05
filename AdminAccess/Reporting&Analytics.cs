using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using PdfSharp.Drawing;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MELTADO_CAFE.AdminAccess
{
    public partial class Reporting_Analytics : Form
    {
        string ConStr = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;

        private Chart chartTopSelling;
        private Chart chartVisitTrends;
        private Chart chartDailySales;

        // Store data for export
        private DataTable dtTopSelling, dtVisitTrends, dtDailySales;

        public Reporting_Analytics()
        {
            InitializeComponent();

            // Setup UI Controls
            SetupUI();

            Load += Reporting_Analytics_Load;
        }
        [Flags]
        public enum XFontStyle
        {
            Regular = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4,
            Strikeout = 8
        }

        private void SetupUI()
        {
            this.Text = "Meltado Café - Reporting & Analytics";
            this.Size = new Size(900, 900);
            this.BackColor = Color.White;

            // Create export buttons panel
            Panel pnlButtons = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                Padding = new Padding(10),
                BackColor = Color.LightGray
            };
            this.Controls.Add(pnlButtons);
            pnlButtons.BringToFront();

            Button btnExportPdf = new Button
            {
                Text = "Export All Charts to PDF",
                AutoSize = true,
                Location = new Point(10, 10)
            };
            btnExportPdf.Click += BtnExportPdf_Click;
            pnlButtons.Controls.Add(btnExportPdf);

            Button btnExportExcel = new Button
            {
                Text = "Export Data to Excel",
                AutoSize = true,
                Location = new Point(240, 10)
            };
            btnExportExcel.Click += BtnExportExcel_Click;
            pnlButtons.Controls.Add(btnExportExcel);

            // Create a FlowLayoutPanel for charts with scrolling
            FlowLayoutPanel flowCharts = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(10),
                BackColor = Color.WhiteSmoke
            };
            this.Controls.Add(flowCharts);
            flowCharts.BringToFront();

            // Initialize charts with fixed size and margin
            chartTopSelling = new Chart { Size = new Size(850, 300), BackColor = Color.White };
            chartVisitTrends = new Chart { Size = new Size(850, 300), BackColor = Color.White };
            chartDailySales = new Chart { Size = new Size(850, 300), BackColor = Color.White };

            flowCharts.Controls.Add(chartTopSelling);
            flowCharts.Controls.Add(chartVisitTrends);
            flowCharts.Controls.Add(chartDailySales);
        }

        private void Reporting_Analytics_Load(object sender, EventArgs e)
        {
            LoadTopSellingItems();
            LoadCustomerVisitTrends();
            LoadDailySales();
        }

        private void LoadTopSellingItems()
        {
            dtTopSelling = new DataTable();
            chartTopSelling.Series.Clear();
            chartTopSelling.ChartAreas.Clear();
            chartTopSelling.Titles.Clear();
            chartTopSelling.Legends.Clear();

            ChartArea area = new ChartArea("TopItemsArea");
            chartTopSelling.ChartAreas.Add(area);

            Series series = new Series("Top Items")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                ChartArea = "TopItemsArea",
                ToolTip = "#VALX: #VAL (#PERCENT)"
            };

            Legend legend = new Legend("Legend") { Docking = Docking.Right, Font = new Font("Segoe UI", 9) };
            chartTopSelling.Legends.Add(legend);

            using (SqlConnection conn = new SqlConnection(ConStr))
            using (SqlCommand cmd = new SqlCommand("sp_GetTopSellingItems", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TopN", 5);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtTopSelling);


                foreach (DataRow row in dtTopSelling.Rows)
                {
                    DataPoint point = new DataPoint
                    {
                        AxisLabel = row["ItemName"].ToString(),
                        YValues = new[] { Convert.ToDouble(row["TotalQuantitySold"]) },
                        ToolTip = $"{row["ItemName"]}: {row["TotalQuantitySold"]} sold"
                    };
                    series.Points.Add(point);
                }
            }

            chartTopSelling.Series.Add(series);
            chartTopSelling.Titles.Add(new Title("Top-Selling Menu Items") { Font = new Font("Segoe UI", 14, FontStyle.Bold) });
        }

        private void LoadCustomerVisitTrends()
        {
            dtVisitTrends = new DataTable();
            chartVisitTrends.Series.Clear();
            chartVisitTrends.ChartAreas.Clear();
            chartVisitTrends.Titles.Clear();
            chartVisitTrends.Legends.Clear();

            ChartArea area = new ChartArea("VisitTrendsArea");
            chartVisitTrends.ChartAreas.Add(area);

            Series series = new Series("Visitors")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                ChartArea = "VisitTrendsArea",
                Color = Color.SteelBlue,
                ToolTip = "Month: #VALX\nVisitors: #VAL"
            };

            Legend legend = new Legend("Legend") { Docking = Docking.Top, Font = new Font("Segoe UI", 9) };
            chartVisitTrends.Legends.Add(legend);

            using (SqlConnection conn = new SqlConnection(ConStr))
            using (SqlCommand cmd = new SqlCommand("sp_GetCustomerVisitTrends", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtVisitTrends);

                foreach (DataRow row in dtVisitTrends.Rows)
                {
                    DataPoint point = new DataPoint
                    {
                        AxisLabel = row["Month"].ToString(),
                        YValues = new[] { Convert.ToDouble(row["UniqueVisitors"]) },
                        ToolTip = $"Month: {row["Month"]}\nVisitors: {row["UniqueVisitors"]}"
                    };
                    series.Points.Add(point);
                }
            }

            chartVisitTrends.Series.Add(series);
            chartVisitTrends.Titles.Add(new Title("Monthly Unique Visitors") { Font = new Font("Segoe UI", 14, FontStyle.Bold) });
        }

        private void LoadDailySales()
        {
            dtDailySales = new DataTable();
            chartDailySales.Series.Clear();
            chartDailySales.ChartAreas.Clear();
            chartDailySales.Titles.Clear();
            chartDailySales.Legends.Clear();

            ChartArea area = new ChartArea("DailySalesArea");
            chartDailySales.ChartAreas.Add(area);

            Series series = new Series("Sales")
            {
                ChartType = SeriesChartType.Line,
                IsValueShownAsLabel = true,
                ChartArea = "DailySalesArea",
                BorderWidth = 3,
                Color = Color.DarkOrange,
                ToolTip = "#VALX: ₹#VAL{N2}"
            };

            Legend legend = new Legend("Legend") { Docking = Docking.Top, Font = new Font("Segoe UI", 9) };
            chartDailySales.Legends.Add(legend);

            using (SqlConnection conn = new SqlConnection(ConStr))
            using (SqlCommand cmd = new SqlCommand("sp_GetDailySales", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtDailySales);

                foreach (DataRow row in dtDailySales.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["SalesDate"]);
                    decimal revenue = Convert.ToDecimal(row["TotalRevenue"]);

                    DataPoint point = new DataPoint
                    {
                        AxisLabel = date.ToString("dd MMM"),
                        YValues = new[] { Convert.ToDouble(revenue) },
                        ToolTip = $"{date:dd MMM yyyy}: ₹{revenue:N2}"
                    };
                    series.Points.Add(point);
                }
            }

            chartDailySales.Series.Add(series);
            chartDailySales.Titles.Add(new Title("Daily Sales Trend") { Font = new Font("Segoe UI", 14, FontStyle.Bold) });
        }

        // Export charts as PDF
        private void BtnExportPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files (*.pdf)|*.pdf", FileName = "MeltadoCafe_Reports.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportChartsToPdf(sfd.FileName);
                }
            }
        }

        private void ExportChartsToPdf(string filename)
        {
            // Register font resolver
            PdfSharp.Fonts.GlobalFontSettings.FontResolver = new FontResolver();

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Meltado Café Reports";

            AddChartPage(document, chartTopSelling, "Top-Selling Menu Items");
            AddChartPage(document, chartVisitTrends, "Monthly Unique Visitors");
            AddChartPage(document, chartDailySales, "Daily Sales Trend");

            document.Save(filename);
            MessageBox.Show("PDF exported successfully.", "Export PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void AddChartPage(PdfDocument document, Chart chart, string title)
        {
            PdfPage page = document.AddPage();
            page.Size = PdfSharp.PageSize.A4;
            XGraphics gfx = XGraphics.FromPdfPage(page);
            // Explicit enum from PdfSharp.Drawing
            XFont font = new XFont("Segoe UI", 16, PdfSharp.Drawing.XFontStyleEx.Bold);




            gfx.DrawString(title, font, XBrushes.Black, new XRect(0, 20, page.Width, 40), XStringFormats.TopCenter);

            using (MemoryStream ms = new MemoryStream())
            {
                chart.SaveImage(ms, ChartImageFormat.Png);
                ms.Position = 0;
                XImage img = XImage.FromStream(ms);

                // Center image
                double x = (page.Width - img.PixelWidth * 72 / img.HorizontalResolution) / 2;
                double y = 60;
                gfx.DrawImage(img, x, y, img.PixelWidth * 72 / img.HorizontalResolution, img.PixelHeight * 72 / img.VerticalResolution);
            }
        }

        // Export data tables to Excel
        private void BtnExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "MeltadoCafe_ReportData.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportDataToExcel(sfd.FileName);
                }
            }
        }

        private void ExportDataToExcel(string filename)
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                if (dtTopSelling != null)
                    wb.Worksheets.Add(dtTopSelling, "Top Selling Items");

                if (dtVisitTrends != null)
                    wb.Worksheets.Add(dtVisitTrends, "Customer Visit Trends");

                if (dtDailySales != null)
                    wb.Worksheets.Add(dtDailySales, "Daily Sales");

                wb.SaveAs(filename);
            }
            MessageBox.Show("Excel file exported successfully.", "Export Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Reporting_Analytics_Load_1(object sender, EventArgs e)
        {
            //var assembly = Assembly.GetExecutingAssembly();
            //foreach (string name in assembly.GetManifestResourceNames())
            //{
            //    MessageBox.Show(name);  // or Debug.WriteLine(name);
            //}
        }
    }
}
