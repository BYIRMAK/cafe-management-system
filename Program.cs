using CafeManagementSystem.Forms.Auth;
using CafeManagementSystem.Forms.Main;
using CafeManagementSystem.Database;

namespace CafeManagementSystem;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // Initialize database
        _ = DatabaseManager.Instance;

        // Show login form
        using var loginForm = new LoginForm();
        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            // If login successful, show main dashboard
            Application.Run(new MainDashboardForm());
        }
    }    
}