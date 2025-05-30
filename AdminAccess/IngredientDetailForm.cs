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

namespace MELTADO_CAFE
{
    public partial class IngredientDetailForm : Form
    {
        private int? ingredientId; // Nullable for new entries
        private SqlConnection connection;
        private bool isEditMode => ingredientId.HasValue;

        public IngredientDetailForm(int? id = null)
        {
            InitializeComponent();
            ingredientId = id;
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString);

            // UI Setup
            this.Text = isEditMode ? "Edit Ingredient" : "Add New Ingredient";
            btnSave.Text = isEditMode ? "Update" : "Save";

            // Load unit of measure options
            LoadUnitOfMeasureOptions();

            if (isEditMode)
                LoadIngredientDetails();
        }

        private void PlaceHolder_TextLoad()
        {
            // Full Name
            txtName.PlaceholderText = "Ingredient Name";

            // Phone Number
            txtDescription.PlaceholderText = "Enter Description";

            // Email
            txtSupplier.PlaceholderText = "Enter Supplier Name";


        }
        private void LoadUnitOfMeasureOptions()
        {
            // Common units for cafe ingredients
            string[] units = { "g (grams)", "kg (kilograms)", "ml (milliliters)",
                          "L (liters)", "pcs (pieces)", "oz (ounces)" };

            cmbUnit.DataSource = units;
        }

        private void LoadIngredientDetails()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ingredients WHERE IngredientID = @ID", connection);
                cmd.Parameters.AddWithValue("@ID", ingredientId.Value);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtName.Text = reader["IngredientName"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
                        numCurrentStock.Value = Convert.ToDecimal(reader["CurrentStock"]);
                        cmbUnit.Text = reader["UnitOfMeasure"].ToString();
                        numReorderLevel.Value = reader["ReorderLevel"] != DBNull.Value
                            ? Convert.ToDecimal(reader["ReorderLevel"]) : 0;
                        txtSupplier.Text = reader["SupplierInfo"].ToString();
                        numCost.Value = Convert.ToDecimal(reader["CostPerUnit"]);
                        chkActive.Checked = Convert.ToBoolean(reader["IsActive"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ingredient: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                connection.Open();

                if (isEditMode)
                {
                    UpdateIngredient();
                }
                else
                {
                    InsertIngredient();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving ingredient: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Ingredient name is required", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (numCurrentStock.Value < 0)
            {
                MessageBox.Show("Stock cannot be negative", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCurrentStock.Focus();
                return false;
            }

            if (numReorderLevel.Value < 0)
            {
                MessageBox.Show("Reorder level cannot be negative", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numReorderLevel.Focus();
                return false;
            }

            return true;
        }

        private void InsertIngredient()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertIngredient", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters with null checks and conversions
                    cmd.Parameters.AddWithValue("@IngredientName", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description",
                        string.IsNullOrWhiteSpace(txtDescription.Text) ? (object)DBNull.Value : txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@UnitOfMeasure", cmbUnit.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReorderLevel",
                        numReorderLevel.Value > 0 ? (object)numReorderLevel.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@SupplierInfo",
                        string.IsNullOrWhiteSpace(txtSupplier.Text) ? (object)DBNull.Value : txtSupplier.Text.Trim());
                    cmd.Parameters.AddWithValue("@CostPerUnit", numCost.Value);
                    cmd.Parameters.AddWithValue("@CurrentStock", numCurrentStock.Value);

                    // Execute and retrieve the new ID
                    object result = cmd.ExecuteScalar(); // Use ExecuteScalar() for SELECT SCOPE_IDENTITY()
                    int newId = result != null ? Convert.ToInt32(result) : 0;

                    // Log initial stock if any
                    if (numCurrentStock.Value > 0 && newId > 0)
                    {
                        RecordStockAdjustment(newId, numCurrentStock.Value, "Initial Stock");
                    }

                    MessageBox.Show("Ingredient inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting ingredient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateIngredient()
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateIngredient", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IngredientID", ingredientId.Value);
            cmd.Parameters.AddWithValue("@IngredientName", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@Description",
                string.IsNullOrWhiteSpace(txtDescription.Text) ? DBNull.Value : (object)txtDescription.Text.Trim());
            cmd.Parameters.AddWithValue("@UnitOfMeasure", cmbUnit.Text);
            cmd.Parameters.AddWithValue("@ReorderLevel",
                numReorderLevel.Value > 0 ? (object)numReorderLevel.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@SupplierInfo",
                string.IsNullOrWhiteSpace(txtSupplier.Text) ? DBNull.Value : (object)txtSupplier.Text.Trim());
            cmd.Parameters.AddWithValue("@CostPerUnit", numCost.Value);
            cmd.Parameters.AddWithValue("@IsActive", chkActive.Checked);

            cmd.ExecuteNonQuery();
        }

        private int GetLastInsertedId()
        {
            SqlCommand cmd = new SqlCommand("SELECT SCOPE_IDENTITY()", connection);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void RecordStockAdjustment(int ingredientId, decimal quantity, string notes)
        {
            SqlCommand cmd = new SqlCommand("sp_RecordStockTransaction", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IngredientID", ingredientId);
            cmd.Parameters.AddWithValue("@QuantityChanged", quantity);
            cmd.Parameters.AddWithValue("@TransactionType", "Adjustment");
            cmd.Parameters.AddWithValue("@Notes", notes);

            cmd.ExecuteNonQuery();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void numCurrentStock_ValueChanged(object sender, EventArgs e)
        {
            // Visual indicator when stock is below reorder level
            if (numReorderLevel.Value > 0 && numCurrentStock.Value < numReorderLevel.Value)
            {
                numCurrentStock.ForeColor = Color.Red;
                lblStockStatus.Text = "LOW STOCK!";
                lblStockStatus.ForeColor = Color.Red;
            }
            else
            {
                numCurrentStock.ForeColor = SystemColors.WindowText;
                lblStockStatus.Text = "Stock Level";
                lblStockStatus.ForeColor = SystemColors.ControlText;
            }
        }

        private void IngredientDetailForm_Load(object sender, EventArgs e)
        {
            PlaceHolder_TextLoad();
        }
    }
}
