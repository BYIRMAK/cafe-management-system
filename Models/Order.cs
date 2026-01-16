namespace CafeManagementSystem.Models;

public class Order
{
    public int Id { get; set; }
    public int? TableId { get; set; }
    public int? CustomerId { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = "Active"; // Active, Paid, Cancelled
    public string? Notes { get; set; }
}

public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
}
