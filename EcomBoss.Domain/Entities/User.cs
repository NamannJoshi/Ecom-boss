using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EcomBoss.Domain.Entities;

[Table("users")]
[Index(nameof(FullName), IsUnique = true)]
[Index(nameof(Email), IsUnique = true)]
[Index(nameof(ContactNo), IsUnique = true)]
public class User
{
    [Key]
    public int Id {get; set;}

    [Required]
    [MaxLength(150)]
    public string FullName { get; set; } = string.Empty;

    [EmailAddress]
    [MaxLength(250)]
    public string Email {get; set;}

    [MaxLength(100)]
    public string PasswordHash {get; set;}

    [MaxLength(15)]
    public string ContactNo {get; set;}

    public string? ImageUrl {get; set;}

    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;

    public DateTime UpdatedAt {get; set;} = DateTime.UtcNow;

    public int? UpdatedBy {get; set;}

    public ICollection<Address> Addresses {get; set;}
}
