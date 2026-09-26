using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomBoss.Domain.Entities;

[Table("order_items")]
public class OrderItem
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid OrderId { get; set; }

    [Required]
    public Guid ProductVariantId { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Column(TypeName = "numeric(18,2)")]
    public decimal UnitPrice { get; set; }

    [ForeignKey(nameof(OrderId))]
    public Order? Order { get; set; }
}
