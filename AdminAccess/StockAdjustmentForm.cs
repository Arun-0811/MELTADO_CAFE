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
using System.Xml.Linq;
using static MELTADO_CAFE.Login_Page;

namespace MELTADO_CAFE
{
    public partial class StockAdjustmentForm : Form
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString);

        // Parameters from inventory form
        private readonly int _ingredientId;
        private readonly string _unit;
        private readonly decimal _currentStock;
        private readonly decimal? _reorderLevel;

        public StockAdjustmentForm(int ingredientId, string ingredientName,
                                 string unitOfMeasure, decimal currentStock,
                                 decimal? reorderLevel)
        {
            InitializeComponent();

            // Store parameters
            _ingredientId = ingredientId;
            _unit = unitOfMeasure;
            _currentStock = currentStock;
            _reorderLevel = reorderLevel;

            // UI Setup
            this.Text = $"Adjust Stock: {ingredientName}";
            lblIngredient.Text = $"{ingredientName} (Current: {currentStock} {unitOfMeasure})";
            lblUnit.Text = unitOfMeasure;
            numQuantity.DecimalPlaces = unitOfMeasure == "pcs" ? 0 : 2;

            // Show warning if below reorder level
            if (_reorderLevel.HasValue && currentStock <= _reorderLevel.Value)
            {
                lblWarning.Visible = true;
                lblWarning.Text = "⚠️ STOCK IS BELOW REORDER LEVEL!";
            }
        }

        private void PlaceHolder_TextLoad()
        {
            // Full Name
            txtNotes.PlaceholderText = "Enter stock wastage or deprecated Related Details Here";

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                decimal quantity = rdoAdd.Checked ? numQuantity.Value : -numQuantity.Value;

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.Open();

                    // Record transaction
                    SqlCommand cmd = new SqlCommand("sp_RecordStockTransaction", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IngredientID", _ingredientId);
                    cmd.Parameters.AddWithValue("@QuantityChanged", quantity);
                    cmd.Parameters.AddWithValue("@TransactionType", "Adjustment");
                    cmd.Parameters.AddWithValue("@Notes", $"Manual adjustment: {cmbReason.Text}. {txtNotes.Text}");
                    cmd.Parameters.AddWithValue("@UserID", LoggedInUser.UserId);
                    cmd.ExecuteNonQuery();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to adjust stock: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (numQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Prevent negative stock for removals
            if (rdoRemove.Checked && (_currentStock - numQuantity.Value < 0))
            {
                MessageBox.Show($"Cannot remove more than current stock ({_currentStock} {_unit})",
                    "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void StockAdjustmentForm_Load(object sender, EventArgs e)
        {
            PlaceHolder_TextLoad();
        }
    }
}
