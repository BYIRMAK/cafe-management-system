namespace CafeManagementSystem.Models;

public class Table
{
    public int Id { get; set; }
    public string TableNumber { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public string Region { get; set; } = string.Empty;
    public string Status { get; set; } = "Available"; // Available, Occupied, Reserved
    public int? CurrentOrderId { get; set; }
    public int? ReservationId { get; set; }
}
