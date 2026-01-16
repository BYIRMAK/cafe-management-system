using System.Data.SQLite;
using CafeManagementSystem.Models;

namespace CafeManagementSystem.Database;

public class DatabaseManager
{
    private static DatabaseManager? _instance;
    private readonly string _connectionString;
    private const string DbFileName = "CafeManagement.db";

    private DatabaseManager()
    {
        string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DbFileName);
        _connectionString = $"Data Source={dbPath};Version=3;";
        InitializeDatabase();
    }

    public static DatabaseManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new DatabaseManager();
            }
            return _instance;
        }
    }

    public SQLiteConnection GetConnection()
    {
        return new SQLiteConnection(_connectionString);
    }

    private void InitializeDatabase()
    {
        using var connection = GetConnection();
        connection.Open();

        string createTablesScript = @"
            -- Users table
            CREATE TABLE IF NOT EXISTS Users (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL UNIQUE,
                Password TEXT NOT NULL,
                FullName TEXT NOT NULL,
                Role TEXT NOT NULL,
                IsActive INTEGER DEFAULT 1,
                CreatedAt TEXT NOT NULL
            );

            -- Tables table
            CREATE TABLE IF NOT EXISTS Tables (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                TableNumber TEXT NOT NULL,
                Capacity INTEGER NOT NULL,
                Region TEXT NOT NULL,
                Status TEXT NOT NULL DEFAULT 'Available',
                CurrentOrderId INTEGER,
                ReservationId INTEGER
            );

            -- Products table
            CREATE TABLE IF NOT EXISTS Products (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Category TEXT NOT NULL,
                Price REAL NOT NULL,
                StockQuantity INTEGER NOT NULL DEFAULT 0,
                ImagePath TEXT,
                Barcode TEXT,
                IsActive INTEGER DEFAULT 1
            );

            -- Orders table
            CREATE TABLE IF NOT EXISTS Orders (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                TableId INTEGER,
                CustomerId INTEGER,
                OrderDate TEXT NOT NULL,
                TotalAmount REAL NOT NULL DEFAULT 0,
                Status TEXT NOT NULL DEFAULT 'Active',
                Notes TEXT
            );

            -- OrderItems table
            CREATE TABLE IF NOT EXISTS OrderItems (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                OrderId INTEGER NOT NULL,
                ProductId INTEGER NOT NULL,
                Quantity INTEGER NOT NULL,
                UnitPrice REAL NOT NULL,
                TotalPrice REAL NOT NULL,
                FOREIGN KEY (OrderId) REFERENCES Orders(Id),
                FOREIGN KEY (ProductId) REFERENCES Products(Id)
            );

            -- Reservations table
            CREATE TABLE IF NOT EXISTS Reservations (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                TableId INTEGER NOT NULL,
                CustomerId INTEGER,
                CustomerName TEXT NOT NULL,
                CustomerPhone TEXT NOT NULL,
                ReservationDate TEXT NOT NULL,
                ReservationTime TEXT NOT NULL,
                NumberOfGuests INTEGER NOT NULL,
                Status TEXT NOT NULL DEFAULT 'Pending',
                Notes TEXT,
                FOREIGN KEY (TableId) REFERENCES Tables(Id)
            );

            -- Customers table
            CREATE TABLE IF NOT EXISTS Customers (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Phone TEXT NOT NULL,
                Email TEXT,
                Address TEXT,
                CreditBalance REAL DEFAULT 0,
                CreatedAt TEXT NOT NULL
            );

            -- Settings table
            CREATE TABLE IF NOT EXISTS Settings (
                Key TEXT PRIMARY KEY,
                Value TEXT NOT NULL
            );
        ";

        using var command = new SQLiteCommand(createTablesScript, connection);
        command.ExecuteNonQuery();

        // Create default admin user if not exists
        CreateDefaultUser(connection);
    }

    private void CreateDefaultUser(SQLiteConnection connection)
    {
        string checkUserSql = "SELECT COUNT(*) FROM Users WHERE Username = 'admin'";
        using var checkCommand = new SQLiteCommand(checkUserSql, connection);
        long userCount = (long)checkCommand.ExecuteScalar()!;

        if (userCount == 0)
        {
            string insertUserSql = @"
                INSERT INTO Users (Username, Password, FullName, Role, CreatedAt)
                VALUES ('admin', 'admin123', 'Administrator', 'Admin', @CreatedAt)
            ";
            using var insertCommand = new SQLiteCommand(insertUserSql, connection);
            insertCommand.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            insertCommand.ExecuteNonQuery();
        }
    }
}
