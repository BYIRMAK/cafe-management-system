using System.Data.SQLite;
using CafeManagementSystem.Database;
using CafeManagementSystem.Models;

namespace CafeManagementSystem.Forms.Products;

public partial class ProductManagementForm : Form
{
    private List<Product> products = new List<Product>();

    public ProductManagementForm()
    {
        InitializeComponent();
        LoadProducts();
    }

    private void LoadProducts()
    {
        products.Clear();
        dataGridViewProducts.Rows.Clear();

        using var connection = DatabaseManager.Instance.GetConnection();
        connection.Open();

        string query = "SELECT * FROM Products WHERE IsActive = 1 ORDER BY Category, Name";
        using var command = new SQLiteCommand(query, connection);
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var product = new Product
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Category = reader.GetString(2),
                Price = reader.GetDecimal(3),
                StockQuantity = reader.GetInt32(4),
                ImagePath = reader.IsDBNull(5) ? null : reader.GetString(5),
                Barcode = reader.IsDBNull(6) ? null : reader.GetString(6),
                IsActive = reader.GetInt32(7) == 1
            };

            products.Add(product);

            dataGridViewProducts.Rows.Add(
                product.Id,
                product.Name,
                product.Category,
                $"${product.Price:F2}",
                product.StockQuantity,
                product.Barcode ?? "N/A"
            );
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        var addForm = new AddEditProductForm();
        if (addForm.ShowDialog() == DialogResult.OK)
        {
            LoadProducts();
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dataGridViewProducts.CurrentRow != null)
        {
            int productId = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value);
            var product = products.FirstOrDefault(p => p.Id == productId);
            
            if (product != null)
            {
                var editForm = new AddEditProductForm(product);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a product to edit.", "No Selection", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewProducts.CurrentRow != null)
        {
            int productId = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value);
            var result = MessageBox.Show("Are you sure you want to delete this product?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using var connection = DatabaseManager.Instance.GetConnection();
                connection.Open();

                // Soft delete - just mark as inactive
                string deleteQuery = "UPDATE Products SET IsActive = 0 WHERE Id = @Id";
                using var command = new SQLiteCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@Id", productId);
                command.ExecuteNonQuery();

                LoadProducts();
                MessageBox.Show("Product deleted successfully.", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            MessageBox.Show("Please select a product to delete.", "No Selection", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
