# Development Guide

## Prerequisites

- .NET 10.0 SDK or later
- Visual Studio 2022 (recommended) or VS Code
- Windows OS or Linux with EnableWindowsTargeting

## Building the Project

```bash
# Restore NuGet packages
dotnet restore

# Build the solution
dotnet build

# Run the application
dotnet run
```

## Project Architecture

### Models
- **User.cs**: User authentication and role management
- **Table.cs**: Restaurant table information
- **Product.cs**: Product catalog with inventory
- **Order.cs** & **OrderItem.cs**: Order processing
- **Reservation.cs**: Table reservation system
- **Customer.cs**: Customer information and credit tracking

### Database Layer
- **DatabaseManager.cs**: Singleton pattern for SQLite connection management
- Automatic schema creation on first run
- Includes seed data for default admin user

### Forms Structure

#### Authentication
- **LoginForm**: User authentication with credential validation

#### Main Dashboard
- **MainDashboardForm**: Central navigation hub with real-time statistics

#### Table Management
- **TableManagementForm**: CRUD operations for tables
- **AddEditTableForm**: Form for adding/editing individual tables

#### Product Management
- **ProductManagementForm**: CRUD operations for products
- **AddEditProductForm**: Form for adding/editing individual products

#### Future Forms (Placeholders)
- Reservation management
- Customer management
- Settings and configuration

## Database Schema

```sql
-- Users table
CREATE TABLE Users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT NOT NULL UNIQUE,
    Password TEXT NOT NULL,
    FullName TEXT NOT NULL,
    Role TEXT NOT NULL,
    IsActive INTEGER DEFAULT 1,
    CreatedAt TEXT NOT NULL
);

-- Tables table
CREATE TABLE Tables (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    TableNumber TEXT NOT NULL,
    Capacity INTEGER NOT NULL,
    Region TEXT NOT NULL,
    Status TEXT NOT NULL DEFAULT 'Available',
    CurrentOrderId INTEGER,
    ReservationId INTEGER
);

-- Products table
CREATE TABLE Products (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Category TEXT NOT NULL,
    Price REAL NOT NULL,
    StockQuantity INTEGER NOT NULL DEFAULT 0,
    ImagePath TEXT,
    Barcode TEXT,
    IsActive INTEGER DEFAULT 1
);

-- Additional tables: Orders, OrderItems, Reservations, Customers, Settings
```

## Coding Standards

- Follow C# naming conventions
- Use nullable reference types where appropriate
- Implement proper error handling
- Use `using` statements for IDisposable resources
- Keep forms focused on UI, logic in separate classes

## Testing

Currently no automated tests. Manual testing checklist:

1. Login with correct/incorrect credentials
2. Dashboard statistics refresh
3. Table CRUD operations
4. Product CRUD operations
5. Form validation
6. Database persistence

## Future Development Tasks

### High Priority
1. Implement order management
2. Complete reservation system with visual indicators
3. Customer management with credit tracking
4. Bill generation and payment processing

### Medium Priority
1. Quick sale menu with product images
2. Barcode scanning integration
3. Printer configuration
4. Reports generation

### Low Priority
1. Personnel management
2. Supplier tracking
3. License validation system
4. Advanced analytics dashboard

## Contributing

1. Create a feature branch
2. Implement changes with proper error handling
3. Test thoroughly
4. Update documentation
5. Submit pull request

## Troubleshooting

### Database locked error
- Ensure only one instance of the application is running
- Check file permissions on the database file

### Build errors on Linux
- Verify `EnableWindowsTargeting` is set to `true` in .csproj
- Install required .NET workloads

### SQLite package issues
- Ensure System.Data.SQLite.Core package is properly installed
- Check NuGet package restore

## Performance Considerations

- SQLite connections are properly disposed
- DataGridView uses virtual mode for large datasets (to be implemented)
- Database queries use parameterized commands to prevent SQL injection
- Index frequently queried columns (to be added)
