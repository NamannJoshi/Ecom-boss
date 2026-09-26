using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomBoss.Domain.Entities;

public enum PaymentStatus
{
    Pending,
    Succeeded,
    Failed
}

[Table("payments")]
public class Payment
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid OrderId { get; set; }

    [Required]
    [MaxLength(255)]
    public string StripeSessionId { get; set; } = string.Empty;

    [Column(TypeName = "numeric(18,2)")]
    public decimal Amount { get; set; }

    [Required]
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
