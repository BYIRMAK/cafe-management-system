# Deployment Guide

## Building for Production

### Option 1: Single-File Executable (Recommended)

Create a single executable file that includes all dependencies:

```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true
```

The output will be in: `bin/Release/net10.0-windows/win-x64/publish/CafeManagementSystem.exe`

### Option 2: Framework-Dependent Deployment

Smaller file size but requires .NET runtime installed on target machine:

```bash
dotnet publish -c Release -r win-x64 --self-contained false
```

### Option 3: Trimmed Self-Contained

Reduce file size with trimming (may require testing):

```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:PublishTrimmed=true
```

## Distribution

1. Copy the executable from the publish folder
2. The database file will be automatically created on first run
3. Distribute with the default login credentials documented in README

## System Requirements

- Windows 7 SP1 or later (64-bit)
- 100 MB disk space
- 512 MB RAM (minimum)

## Installation Steps for End Users

1. Download `CafeManagementSystem.exe`
2. Run the executable
3. Login with default credentials:
   - Username: `admin`
   - Password: `admin123`
4. Change the default password after first login (feature to be implemented)

## Database Location

The SQLite database (`CafeManagement.db`) is created in the same directory as the executable.

## Backup Recommendations

- Regularly backup the `CafeManagement.db` file
- Store backups in a separate location
- Test backup restoration periodically

## License Information

To be implemented in Settings > Subscription/License section.
