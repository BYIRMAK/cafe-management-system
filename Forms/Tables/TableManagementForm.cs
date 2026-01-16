using System.Data.SQLite;
using CafeManagementSystem.Database;
using CafeManagementSystem.Models;

namespace CafeManagementSystem.Forms.Tables;

public partial class TableManagementForm : Form
{
    private List<Table> tables = new List<Table>();

    public TableManagementForm()
    {
        InitializeComponent();
        LoadTables();
    }

    private void LoadTables()
    {
        tables.Clear();
        dataGridViewTables.Rows.Clear();

        using var connection = DatabaseManager.Instance.GetConnection();
        connection.Open();

        string query = "SELECT * FROM Tables ORDER BY Region, TableNumber";
        using var command = new SQLiteCommand(query, connection);
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var table = new Table
            {
                Id = reader.GetInt32(0),
                TableNumber = reader.GetString(1),
                Capacity = reader.GetInt32(2),
                Region = reader.GetString(3),
                Status = reader.GetString(4),
                CurrentOrderId = reader.IsDBNull(5) ? null : reader.GetInt32(5),
                ReservationId = reader.IsDBNull(6) ? null : reader.GetInt32(6)
            };

            tables.Add(table);

            int rowIndex = dataGridViewTables.Rows.Add(
                table.Id,
                table.TableNumber,
                table.Capacity,
                table.Region,
                table.Status
            );

            // Color code based on status
            var row = dataGridViewTables.Rows[rowIndex];
            if (table.Status == TableStatus.Reserved)
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
            }
            else if (table.Status == TableStatus.Occupied)
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            }
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        var addForm = new AddEditTableForm();
        if (addForm.ShowDialog() == DialogResult.OK)
        {
            LoadTables();
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dataGridViewTables.CurrentRow != null)
        {
            int tableId = Convert.ToInt32(dataGridViewTables.CurrentRow.Cells[0].Value);
            var table = tables.FirstOrDefault(t => t.Id == tableId);
            
            if (table != null)
            {
                var editForm = new AddEditTableForm(table);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTables();
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a table to edit.", "No Selection", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewTables.CurrentRow != null)
        {
            int tableId = Convert.ToInt32(dataGridViewTables.CurrentRow.Cells[0].Value);
            var result = MessageBox.Show("Are you sure you want to delete this table?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using var connection = DatabaseManager.Instance.GetConnection();
                connection.Open();

                string deleteQuery = "DELETE FROM Tables WHERE Id = @Id";
                using var command = new SQLiteCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@Id", tableId);
                command.ExecuteNonQuery();

                LoadTables();
                MessageBox.Show("Table deleted successfully.", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            MessageBox.Show("Please select a table to delete.", "No Selection", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
