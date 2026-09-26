using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomBoss.Domain.Entities;

[Table("product_variants")]
public class ProductVariant: AuditEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Sku { get; set; } = string.Empty;

    [MaxLength(50)]
    public string Color { get; set; } = string.Empty;

    [MaxLength(50)]
    public string Size { get; set; } = string.Empty;

    [Column(TypeName = "numeric(18,2)")]
    public decimal Price { get; set; }

    [Required]
    public int StockQuantity { get; set; }

    public int ProductOverride {get; set;}

    // Concurrency Token: Crucial for Postgres inventory locking during checkout
    [ConcurrencyCheck] 
    public Guid Version { get; set; } 

    [ForeignKey(nameof(ProductId))]
    public Product? Product { get; set; }
}
