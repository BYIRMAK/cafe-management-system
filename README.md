# Cafe Management System

A comprehensive offline desktop application for managing cafes and restaurants, built with Windows Forms and SQLite.

## Features

### Core Functionality
- **User Authentication**: Secure login system with username and password
  - Default credentials: Username: `admin`, Password: `admin123`
- **Dashboard**: Main control panel with real-time statistics
  - Today's sales overview
  - Table occupancy rates
  - Active orders tracking
  - Reservation monitoring

### Table Management
- Add, edit, and delete tables
- Organize tables by regions
- Track table status (Available, Occupied, Reserved)
- Visual color-coding for quick status identification
- Capacity management

### Product Management
- Add, edit, and delete products
- Category organization
- Price management
- Stock tracking
- Barcode support
- Soft delete functionality (marks as inactive)

### Reservations
- Reservation management system (placeholder - ready for implementation)
- Reserved table indicators
- Reservation alerts

### Customer Management
- Customer information tracking (placeholder - ready for implementation)
- Credit account management
- Payment history

### Settings & Configuration
- Printer configuration (placeholder - ready for implementation)
- Personnel management
- Reports and cash register
- Supplier settings
- License/subscription tracking
- General business settings

## Technology Stack

- **.NET 10.0** with Windows Forms
- **SQLite** for offline database storage
- **C#** programming language

## Project Structure

```
CafeManagementSystem/
├── Models/              # Data models (User, Table, Product, Order, etc.)
├── Database/           # Database manager and initialization
├── Forms/              # All UI forms
│   ├── Auth/          # Login form
│   ├── Main/          # Main dashboard
│   ├── Tables/        # Table management forms
│   ├── Products/      # Product management forms
│   ├── Reservations/  # Reservation forms
│   ├── Customers/     # Customer management forms
│   └── Settings/      # Settings forms
└── Utils/             # Utility classes (AuthService, etc.)
```

## Database Schema

The application uses SQLite with the following tables:
- **Users**: User authentication and roles
- **Tables**: Restaurant table information
- **Products**: Product catalog with pricing and stock
- **Orders**: Order tracking
- **OrderItems**: Individual items in orders
- **Reservations**: Table reservation management
- **Customers**: Customer information and credit tracking
- **Settings**: Application configuration

## Getting Started

### Prerequisites
- .NET 10.0 SDK or later
- Windows operating system (or Linux with EnableWindowsTargeting)

### Building the Application

```bash
# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run
```

### Creating an EXE for Deployment

```bash
# Publish as a self-contained executable
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

The executable will be located in `bin/Release/net10.0-windows/win-x64/publish/`

## Default Login Credentials

- **Username**: admin
- **Password**: admin123

## Future Enhancements

The following features are planned for future implementation:
- Quick sale menu with product images and barcode scanning
- Complete reservation management with alerts
- Full customer management with credit tracking
- Order management and bill processing
- Payment processing integration
- Printer configuration and receipt printing
- Personnel management and permissions
- Comprehensive reporting system
- Cash register functionality
- Supplier management
- License validation system

## License

This project is open source and available for cafe and restaurant management.

## Notes

- The database file (`CafeManagement.db`) is automatically created on first run
- All data is stored locally in SQLite
- The application is designed to work offline
- Some features are currently placeholders for future development