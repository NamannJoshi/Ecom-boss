using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomBoss.Domain.Entities;

public enum OrderStatus
{
    Pending,
    Paid,
    Shipped,
    Cancelled
}

[Table("orders")]
public class Order
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string UserId { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string OrderNumber { get; set; } = string.Empty;

    [Required]
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    [Column(TypeName = "numeric(18,2)")]
    public decimal TotalAmount { get; set; }

    [Required]
    public OrderStatus Status { get; set; } = OrderStatus.Pending;

    [Required]
    public Guid ShippingAddressId { get; set; }

    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
}