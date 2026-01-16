using System.Data.SQLite;
using CafeManagementSystem.Database;
using CafeManagementSystem.Models;

namespace CafeManagementSystem.Forms.Products;

public partial class AddEditProductForm : Form
{
    private Product? _product;
    private bool _isEditMode;

    public AddEditProductForm(Product? product = null)
    {
        InitializeComponent();
        _product = product;
        _isEditMode = product != null;

        if (_isEditMode)
        {
            LoadProductData();
            this.Text = "Edit Product";
            lblTitle.Text = "Edit Product";
        }
    }

    private void LoadProductData()
    {
        if (_product != null)
        {
            txtName.Text = _product.Name;
            txtCategory.Text = _product.Category;
            numPrice.Value = _product.Price;
            numStock.Value = _product.StockQuantity;
            txtBarcode.Text = _product.Barcode ?? "";
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;

        using var connection = DatabaseManager.Instance.GetConnection();
        connection.Open();

        if (_isEditMode && _product != null)
        {
            string updateQuery = @"
                UPDATE Products 
                SET Name = @Name, Category = @Category, Price = @Price, 
                    StockQuantity = @Stock, Barcode = @Barcode
                WHERE Id = @Id";
            using var cmd = new SQLiteCommand(updateQuery, connection);
            cmd.Parameters.AddWithValue("@Id", _product.Id);
            cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
            cmd.Parameters.AddWithValue("@Price", numPrice.Value);
            cmd.Parameters.AddWithValue("@Stock", (int)numStock.Value);
            cmd.Parameters.AddWithValue("@Barcode", string.IsNullOrWhiteSpace(txtBarcode.Text) ? DBNull.Value : txtBarcode.Text.Trim());
            cmd.ExecuteNonQuery();
        }
        else
        {
            string insertQuery = @"
                INSERT INTO Products (Name, Category, Price, StockQuantity, Barcode, IsActive)
                VALUES (@Name, @Category, @Price, @Stock, @Barcode, 1)";
            using var cmd = new SQLiteCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
            cmd.Parameters.AddWithValue("@Price", numPrice.Value);
            cmd.Parameters.AddWithValue("@Stock", (int)numStock.Value);
            cmd.Parameters.AddWithValue("@Barcode", string.IsNullOrWhiteSpace(txtBarcode.Text) ? DBNull.Value : txtBarcode.Text.Trim());
            cmd.ExecuteNonQuery();
        }

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Please enter product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        if (string.IsNullOrWhiteSpace(txtCategory.Text))
        {
            MessageBox.Show("Please enter category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
