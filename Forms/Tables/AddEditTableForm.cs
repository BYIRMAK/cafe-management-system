using System.Data.SQLite;
using CafeManagementSystem.Database;
using CafeManagementSystem.Models;

namespace CafeManagementSystem.Forms.Tables;

public partial class AddEditTableForm : Form
{
    private Table? _table;
    private bool _isEditMode;

    public AddEditTableForm(Table? table = null)
    {
        InitializeComponent();
        _table = table;
        _isEditMode = table != null;

        if (_isEditMode)
        {
            LoadTableData();
            this.Text = "Edit Table";
            lblTitle.Text = "Edit Table";
        }
        else
        {
            this.Text = "Add Table";
            lblTitle.Text = "Add New Table";
        }
    }

    private void LoadTableData()
    {
        if (_table != null)
        {
            txtTableNumber.Text = _table.TableNumber;
            numCapacity.Value = _table.Capacity;
            txtRegion.Text = _table.Region;
            cboStatus.SelectedItem = _table.Status;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
            return;

        using var connection = DatabaseManager.Instance.GetConnection();
        connection.Open();

        if (_isEditMode && _table != null)
        {
            string updateQuery = @"
                UPDATE Tables 
                SET TableNumber = @TableNumber, Capacity = @Capacity, 
                    Region = @Region, Status = @Status
                WHERE Id = @Id
            ";
            using var command = new SQLiteCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@Id", _table.Id);
            command.Parameters.AddWithValue("@TableNumber", txtTableNumber.Text.Trim());
            command.Parameters.AddWithValue("@Capacity", (int)numCapacity.Value);
            command.Parameters.AddWithValue("@Region", txtRegion.Text.Trim());
            command.Parameters.AddWithValue("@Status", cboStatus.SelectedItem?.ToString() ?? "Available");
            command.ExecuteNonQuery();

            MessageBox.Show("Table updated successfully.", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            string insertQuery = @"
                INSERT INTO Tables (TableNumber, Capacity, Region, Status)
                VALUES (@TableNumber, @Capacity, @Region, @Status)
            ";
            using var command = new SQLiteCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@TableNumber", txtTableNumber.Text.Trim());
            command.Parameters.AddWithValue("@Capacity", (int)numCapacity.Value);
            command.Parameters.AddWithValue("@Region", txtRegion.Text.Trim());
            command.Parameters.AddWithValue("@Status", cboStatus.SelectedItem?.ToString() ?? "Available");
            command.ExecuteNonQuery();

            MessageBox.Show("Table added successfully.", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtTableNumber.Text))
        {
            MessageBox.Show("Please enter a table number.", "Validation Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTableNumber.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtRegion.Text))
        {
            MessageBox.Show("Please enter a region.", "Validation Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtRegion.Focus();
            return false;
        }

        if (numCapacity.Value <= 0)
        {
            MessageBox.Show("Capacity must be greater than 0.", "Validation Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            numCapacity.Focus();
            return false;
        }

        return true;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
