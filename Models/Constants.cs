namespace CafeManagementSystem.Models;

/// <summary>
/// Constants for table status values
/// </summary>
public static class TableStatus
{
    public const string Available = "Available";
    public const string Occupied = "Occupied";
    public const string Reserved = "Reserved";
}

/// <summary>
/// Constants for order status values
/// </summary>
public static class OrderStatus
{
    public const string Active = "Active";
    public const string Paid = "Paid";
    public const string Cancelled = "Cancelled";
}

/// <summary>
/// Constants for reservation status values
/// </summary>
public static class ReservationStatus
{
    public const string Pending = "Pending";
    public const string Confirmed = "Confirmed";
    public const string Cancelled = "Cancelled";
    public const string Completed = "Completed";
}
