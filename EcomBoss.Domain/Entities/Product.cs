using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EcomBoss.Domain.Entities;

[Table("products")]
[Index(nameof(Name), IsUnique = true)]
public class Product: AuditEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(2000)]
    public string Description { get; set; } = string.Empty;

    // Tenant Isolation: Links back to the ApplicationUser (Merchant)
    [Required]
    public string MerchantId { get; set; } = string.Empty;

    public bool IsPublished {get; set;}

    public int BasePrice {get; set;}

    public string? ImageUrl {get; set;}

    // Navigation property for EF Core
    public ICollection<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
}
