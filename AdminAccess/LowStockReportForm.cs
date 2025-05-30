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
    public partial class LowStockReportForm : Form
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString);

        public LowStockReportForm()
        {
            InitializeComponent();
            LoadLowStockItems();
        }

        private void LoadLowStockItems()
        {
            SqlCommand cmd = new SqlCommand("sp_GetLowStockItems", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvLowStock.DataSource = dt;
        }
    }
}
