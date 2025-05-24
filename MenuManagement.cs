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
    public partial class MenuManagement : Form
    {
        string ConnnectionString = ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString;
        private string uploadedImagePath = "";
        private int selectedItemId = -1;
        private int categoryId = 0;
        


        public MenuManagement()
        {
            InitializeComponent();
            PlaceHolder_TextLoad();
            LoadCategories();
            LoadMenuCategories();
        }

        enum LoadedGridDataType
        {
            MenuItems,
            MenuCategory,
            // Add other types if needed
        }

        private void PlaceHolder_TextLoad()
        {
            txt_ItemName.PlaceholderText = "Enter Item Name";
            txt_Description.PlaceholderText = "Enter Item Description";
            txt_price.PlaceholderText = "Enter Item Price";

        }
        private void LoadCategories()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MenuCategory", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Insert a default "Select Category" row at the top
                DataRow defaultRow = dt.NewRow();
                defaultRow["CategoryName"] = "-- Select MenuCategory --";
                defaultRow["CategoryID"] = 0;
                dt.Rows.InsertAt(defaultRow, 0);

                cmb_Category.DataSource = dt;
                cmb_Category.DisplayMember = "CategoryName";
                cmb_Category.ValueMember = "CategoryID";

                // Set DropDownStyle to DropDownList
                cmb_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void btn_uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                uploadedImagePath = ofd.FileName;
                picbox_upload.Image = Image.FromFile(uploadedImagePath);
            }
        }

        private void btn_addItems_Click(object sender, EventArgs e)
        {
            try
            {
                // CASE 1: Add Menu Item if input fields are filled
                if (!string.IsNullOrWhiteSpace(txt_ItemName.Text) &&
                    !string.IsNullOrWhiteSpace(txt_Description.Text) &&
                    !string.IsNullOrWhiteSpace(txt_price.Text) &&
                    cmb_Category.SelectedIndex >= 0)
                {
                    using (SqlConnection con = new SqlConnection(ConnnectionString))
                    using (SqlCommand cmd = new SqlCommand("sp_InsertMenuItem", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@name", txt_ItemName.Text);
                        cmd.Parameters.AddWithValue("@desc", txt_Description.Text);
                        cmd.Parameters.AddWithValue("@categoryName", cmb_Category.Text);  // Pass name, not ID
                        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txt_price.Text));
                        cmd.Parameters.AddWithValue("@image", uploadedImagePath);
                        cmd.Parameters.AddWithValue("@available", checkBox_AVAILABLITY.Checked);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Menu item inserted successfully.");
                        LoadMenuItems();
                        ClearItemForm();
                    }
                }

                // CASE 2: Add new category if category text input is filled
                else if (!string.IsNullOrWhiteSpace(txt_categorycmblist.Text))
                {
                    using (SqlConnection con = new SqlConnection(ConnnectionString))
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO MenuCategory (CategoryName) VALUES (@catName)", con))
                    {
                        cmd.Parameters.AddWithValue("@catName", txt_categorycmblist.Text.Trim());
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New category added successfully.");
                    }

                    txt_categorycmblist.Clear();
                    LoadMenuCategories(); // Refresh the ComboBox
                }

                // If nothing was filled
                else
                {
                    MessageBox.Show("Please fill in either item details or a category name.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("A database error occurred:\n" + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for the price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_saveItem_Click(object sender, EventArgs e)
        {
            bool isAnyUpdated = false;

            try
            {
                if (currentDataType == LoadedDataType.MenuItems)
                {
                    if (selectedItemId <= 0)
                    {
                        MessageBox.Show("Please select a menu item to update.");
                        return;
                    }

                    using (SqlConnection con = new SqlConnection(ConnnectionString))
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateMenuItem", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@itemId", selectedItemId);
                        cmd.Parameters.AddWithValue("@name", txt_ItemName.Text);
                        cmd.Parameters.AddWithValue("@desc", txt_Description.Text);
                        cmd.Parameters.AddWithValue("@categoryName", cmb_Category.Text.Trim());
                        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txt_price.Text));
                        cmd.Parameters.AddWithValue("@image", string.IsNullOrEmpty(uploadedImagePath) ? DBNull.Value : uploadedImagePath);

                        cmd.Parameters.AddWithValue("@available", checkBox_AVAILABLITY.Checked);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Menu item updated successfully.");
                            isAnyUpdated = true;
                            ClearItemForm();
                            LoadMenuItems();
                        }
                        else
                        {
                            MessageBox.Show("No item was updated. Please check the Item ID.");
                        }
                    }
                }
                else if (currentDataType == LoadedDataType.MenuCategory)
                {
                    if (categoryId <= 0 || string.IsNullOrWhiteSpace(txt_categorycmblist.Text))
                    {
                        MessageBox.Show("Please select a category and enter a valid name.");
                        return;
                    }

                    using (SqlConnection con = new SqlConnection(ConnnectionString))
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateMenuCategory", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.Parameters.AddWithValue("@NewCategoryName", txt_categorycmblist.Text.Trim());

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category updated successfully.");
                            isAnyUpdated = true;
                            txt_categorycmblist.Clear();
                            LoadMenuCategories();
                        }
                        else
                        {
                            MessageBox.Show("No category was updated. Please check the Category ID.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No data type selected. Please load Menu Items or Categories.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("A database error occurred:\n" + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid format for price or ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void MenuItems_gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= MenuItems_gridView.Rows.Count)
                return;

            try
            {
                DataGridViewRow row = MenuItems_gridView.Rows[e.RowIndex];

                if (currentDataType == LoadedDataType.MenuItems)
                {
                    selectedItemId = Convert.ToInt32(row.Cells["ItemID"].Value);
                    txt_ItemName.Text = row.Cells["ItemName"].Value?.ToString();
                    txt_Description.Text = row.Cells["Description"].Value?.ToString();
                    txt_price.Text = row.Cells["Price"].Value?.ToString();
                    checkBox_AVAILABLITY.Checked = Convert.ToBoolean(row.Cells["IsAvailable"].Value);

                    categoryId = Convert.ToInt32(row.Cells["CategoryID"].Value);

                    // Match combobox with CategoryID
                    foreach (DataRowView item in cmb_Category.Items)
                    {
                        if (Convert.ToInt32(item["CategoryID"]) == categoryId)
                        {
                            cmb_Category.SelectedItem = item;
                            break;
                        }
                    }

                    string imagePath = row.Cells["ImagePath"].Value?.ToString();
                    uploadedImagePath = imagePath; // <-- Store image path here

                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        picbox_upload.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        picbox_upload.Image = null;
                    }
                }
                else if (currentDataType == LoadedDataType.MenuCategory)
                {
                    categoryId = Convert.ToInt32(row.Cells["CategoryID"].Value);
                    txt_categorycmblist.Text = row.Cells["CategoryName"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading details:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearItemForm()
        {
            txt_ItemName.Clear();
            txt_Description.Clear();
            txt_price.Clear();
            txt_categorycmblist.Clear();

            cmb_Category.SelectedIndex = -1;
            checkBox_AVAILABLITY.Checked = false;

            picbox_upload.Image = null;
            uploadedImagePath = string.Empty;

            selectedItemId = -1;
            categoryId = 0;
        }


        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedItemId <= 0)
                {
                    MessageBox.Show("Please select an item to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.No) return;

                using (SqlConnection con = new SqlConnection(ConnnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_DeleteMenuItem", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemID", selectedItemId);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Menu item deleted successfully.");
                        ClearItemForm();      // Optional: reset fields
                        LoadMenuItems();      // Optional: refresh grid
                    }
                    else
                    {
                        MessageBox.Show("No item found with the specified ID.");
                    }
                }

                // OPTIONAL: Delete category if needed
                if (categoryId != 0 && !string.IsNullOrWhiteSpace(txt_categorycmblist.Text))
                {
                    DialogResult categoryDeleteConfirm = MessageBox.Show(
                        "Do you also want to delete the associated category?",
                        "Delete Category",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (categoryDeleteConfirm == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(ConnnectionString))
                        using (SqlCommand cmd = new SqlCommand("sp_DeleteMenuCategory", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }

                        txt_categorycmblist.Clear();
                        LoadMenuCategories();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("A database error occurred:\n" + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid format for Item ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private enum LoadedDataType
        {
            None,
            MenuCategory,
            MenuItems

        }

        private LoadedDataType currentDataType = LoadedDataType.None;
        private void LoadMenuCategories()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                string query = "SELECT * FROM MenuCategory";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                MenuItems_gridView.DataSource = dt;
                currentDataType = LoadedDataType.MenuCategory;

            }
        }

        private void LoadMenuItems()
        {
            using (SqlConnection con = new SqlConnection(ConnnectionString))
            {
                string query = "select * from MenuItem";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                MenuItems_gridView.DataSource = dt;
                currentDataType = LoadedDataType.MenuItems;


            }
        }
        private void ShowControls(string type)
        {

            switch (type)
            {
                case "MenuCategory":
                    txt_categorycmblist.Visible = true;
                    txt_categorycmblist.Focus();
                    break;
                case "MenuItems":
                    break;

            }
        }

        // Highlight the active button
        private void HighlightActiveButton(Button activeButton)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.Name.StartsWith("btn"))
                {
                    btn.BackColor = SystemColors.Control; // default
                }
            }

            activeButton.BackColor = Color.LightBlue; // highlight
        }
        private void btn_btn_categoryclickloaded_Click(object sender, EventArgs e)
        {
            LoadMenuCategories();
            ShowControls("Gender");
            HighlightActiveButton((Button)sender);
        }

        private void btn_btn_menuitems_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
            ShowControls("MenuItems");
            HighlightActiveButton((Button)sender);
        }

        private void btn_clearItems_Click(object sender, EventArgs e)
        {
            // Clear text inputs
            txt_ItemName.Clear();
            txt_Description.Clear();
            txt_price.Clear();
            txt_categorycmblist.Clear();

            // Reset combo box and checkbox
            cmb_Category.SelectedIndex = -1;
            checkBox_AVAILABLITY.Checked = false;

            // Clear image and image path
            picbox_upload.Image = null;
            uploadedImagePath = string.Empty;

            // Reset IDs
            selectedItemId = -1;
            categoryId = 0;
        }

    }

}

