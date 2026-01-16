# Quick Start Guide

## For End Users

### Installation
1. Download `CafeManagementSystem.exe`
2. Double-click to run (no installation required)
3. The application will create a database file automatically

### First Login
- **Username**: `admin`
- **Password**: `admin123`

### Basic Usage

#### Dashboard
After login, you'll see the main dashboard showing:
- Today's sales total
- Table occupancy status
- Active orders count
- Today's reservations

#### Managing Tables
1. Click **Table Management** in the side menu
2. Click **Add Table** to create a new table
3. Enter table number, capacity, and region
4. Select status (Available, Occupied, or Reserved)
5. Click **Save**

**Table Status Colors:**
- 🟢 Green = Available
- 🔴 Red = Occupied
- 🟡 Yellow = Reserved

#### Managing Products
1. Click **Product Management** in the side menu
2. Click **Add Product** to add a new item
3. Enter product details:
   - Name
   - Category
   - Price
   - Stock quantity
   - Barcode (optional)
4. Click **Save**

#### Navigation
Use the side menu to access:
- Table Management
- Product Management
- Quick Sale (coming soon)
- Reservations (coming soon)
- Customers (coming soon)
- Settings (coming soon)

#### Logging Out
Click the **Logout** button in the top-right corner.

---

## For Developers

### Prerequisites
- .NET 10.0 SDK
- Windows OS or Linux with EnableWindowsTargeting

### Quick Build
```bash
# Clone the repository
git clone https://github.com/BYIRMAK/cafe-management-system.git
cd cafe-management-system

# Restore and build
dotnet restore
dotnet build

# Run
dotnet run
```

### Project Structure
```
CafeManagementSystem/
├── Models/              # Data models
├── Database/           # SQLite database manager
├── Forms/              # UI forms
│   ├── Auth/          # Login
│   ├── Main/          # Dashboard
│   ├── Tables/        # Table management
│   ├── Products/      # Product management
│   ├── Reservations/  # Reservations (stub)
│   ├── Customers/     # Customers (stub)
│   └── Settings/      # Settings (stub)
└── Utils/             # Utilities (AuthService)
```

### Building for Distribution
```bash
# Single-file executable (recommended)
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true

# Output location
bin/Release/net10.0-windows/win-x64/publish/CafeManagementSystem.exe
```

### Running Tests
Currently no automated tests. Manual testing:
1. Login functionality
2. Dashboard statistics
3. Table CRUD operations
4. Product CRUD operations

### Contributing
See [DEVELOPMENT.md](DEVELOPMENT.md) for detailed development guidelines.

---

## Common Tasks

### Adding a New Table
1. Login → Table Management
2. Add Table button
3. Fill in: Table #, Capacity, Region, Status
4. Save

### Adding a New Product
1. Login → Product Management
2. Add Product button
3. Fill in: Name, Category, Price, Stock, Barcode
4. Save

### Viewing Statistics
- Dashboard shows real-time stats
- Click **Refresh** to update
- Stats include sales, occupancy, orders, reservations

### Backing Up Data
The database file is located in the same folder as the exe:
- File name: `CafeManagement.db`
- Simply copy this file to backup

### Restoring Data
1. Close the application
2. Replace `CafeManagement.db` with your backup
3. Restart the application

---

## Troubleshooting

### Problem: "Cannot open database"
**Solution**: Check that the application has write permissions in its directory.

### Problem: "Login failed"
**Solution**: Use the default credentials (admin/admin123) or check with your administrator.

### Problem: Application won't start
**Solution**: 
- Ensure .NET 10.0 runtime is installed (for framework-dependent builds)
- Try the self-contained version instead

### Problem: Database is locked
**Solution**: Close all other instances of the application.

---

## Support & Documentation

- **README.md** - Overview and features
- **FEATURES.md** - Detailed feature list
- **DEVELOPMENT.md** - Development guide
- **DEPLOYMENT.md** - Deployment instructions

## License

Open source - see repository for details.

## Version

Current Version: 1.0.0
- Initial release with core functionality
- Login system
- Table management
- Product management
- Dashboard with statistics
