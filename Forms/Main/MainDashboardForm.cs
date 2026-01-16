using CafeManagementSystem.Utils;
using CafeManagementSystem.Forms.Tables;
using CafeManagementSystem.Forms.Products;
using CafeManagementSystem.Forms.Reservations;
using CafeManagementSystem.Forms.Customers;
using CafeManagementSystem.Forms.Settings;
using System.Data.SQLite;
using CafeManagementSystem.Database;

namespace CafeManagementSystem.Forms.Main;

public partial class MainDashboardForm : Form
{
    public MainDashboardForm()
    {
        InitializeComponent();
        LoadDashboardData();
    }

    private void LoadDashboardData()
    {
        lblWelcome.Text = $"Welcome, {AuthService.CurrentUser?.FullName}";
        LoadStatistics();
    }

    private void LoadStatistics()
    {
        using var connection = DatabaseManager.Instance.GetConnection();
        connection.Open();

        // Get today's sales
        string salesQuery = @"
            SELECT COALESCE(SUM(TotalAmount), 0)
            FROM Orders
            WHERE Status = 'Paid' AND DATE(OrderDate) = DATE('now')
        ";
        using var salesCmd = new SQLiteCommand(salesQuery, connection);
        decimal todaySales = Convert.ToDecimal(salesCmd.ExecuteScalar());
        lblTodaySales.Text = $"Today's Sales: ${todaySales:F2}";

        // Get occupied tables
        string tablesQuery = @"
            SELECT 
                COUNT(CASE WHEN Status = 'Occupied' THEN 1 END) as Occupied,
                COUNT(*) as Total
            FROM Tables
        ";
        using var tablesCmd = new SQLiteCommand(tablesQuery, connection);
        using var reader = tablesCmd.ExecuteReader();
        if (reader.Read())
        {
            int occupied = reader.GetInt32(0);
            int total = reader.GetInt32(1);
            lblOccupancy.Text = $"Table Occupancy: {occupied}/{total}";
        }

        // Get active orders
        string ordersQuery = "SELECT COUNT(*) FROM Orders WHERE Status = 'Active'";
        using var ordersCmd = new SQLiteCommand(ordersQuery, connection);
        int activeOrders = Convert.ToInt32(ordersCmd.ExecuteScalar());
        lblActiveOrders.Text = $"Active Orders: {activeOrders}";

        // Get today's reservations
        string reservationsQuery = @"
            SELECT COUNT(*)
            FROM Reservations
            WHERE DATE(ReservationDate) = DATE('now') AND Status != 'Cancelled'
        ";
        using var reservationsCmd = new SQLiteCommand(reservationsQuery, connection);
        int todayReservations = Convert.ToInt32(reservationsCmd.ExecuteScalar());
        lblReservations.Text = $"Today's Reservations: {todayReservations}";
    }

    private void btnTableManagement_Click(object sender, EventArgs e)
    {
        var tableForm = new TableManagementForm();
        tableForm.ShowDialog();
        LoadStatistics(); // Refresh stats after closing
    }

    private void btnProductManagement_Click(object sender, EventArgs e)
    {
        var productForm = new ProductManagementForm();
        productForm.ShowDialog();
        LoadStatistics();
    }

    private void btnQuickSale_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Quick Sale feature coming soon!", "Information", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnReservations_Click(object sender, EventArgs e)
    {
        var reservationForm = new ReservationManagementForm();
        reservationForm.ShowDialog();
        LoadStatistics();
    }

    private void btnCustomers_Click(object sender, EventArgs e)
    {
        var customerForm = new CustomerManagementForm();
        customerForm.ShowDialog();
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
        var settingsForm = new SettingsForm();
        settingsForm.ShowDialog();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
        if (result == DialogResult.Yes)
        {
            AuthService.Logout();
            this.Close();
        }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        LoadStatistics();
    }
}
