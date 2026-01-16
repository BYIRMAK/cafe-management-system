using System.Data.SQLite;
using CafeManagementSystem.Database;
using CafeManagementSystem.Models;

namespace CafeManagementSystem.Utils;

public class AuthService
{
    private static User? _currentUser;

    public static User? CurrentUser
    {
        get => _currentUser;
        private set => _currentUser = value;
    }

    public static bool IsAuthenticated => _currentUser != null;

    public static bool Login(string username, string password)
    {
        using var connection = DatabaseManager.Instance.GetConnection();
        connection.Open();

        // NOTE: In production, password should be hashed and compared with stored hash
        // TODO: Implement password hashing (bcrypt, PBKDF2, or Argon2) before production
        string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password AND IsActive = 1";
        using var command = new SQLiteCommand(query, connection);
        command.Parameters.AddWithValue("@Username", username);
        command.Parameters.AddWithValue("@Password", password);

        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            // Don't store the password in memory
            CurrentUser = new User
            {
                Id = reader.GetInt32(0),
                Username = reader.GetString(1),
                Password = string.Empty, // Don't keep password in memory
                FullName = reader.GetString(3),
                Role = reader.GetString(4),
                IsActive = reader.GetInt32(5) == 1,
                CreatedAt = DateTime.Parse(reader.GetString(6))
            };
            return true;
        }

        return false;
    }

    public static void Logout()
    {
        CurrentUser = null;
    }
}
