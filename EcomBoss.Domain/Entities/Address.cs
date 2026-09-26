using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace EcomBoss.Domain.Entities;

[Table("user_addresses")]
public class Address: AuditEntity
{
    [Key]
    public int Id {get; set;}

    public int UserId {get; set;}

    [Required]
    [MaxLength(10)]
    public string BuildingNo {get; set;}

    [Required]
    [MaxLength(50)]
    public string Street {get; set;}

    [Required]
    [MaxLength(25)]
    public string City {get; set;}

    [Required]
    [MaxLength(25)]
    public string State {get; set;}

    [Required]
    [MaxLength(6)]
    public string PostalCode {get; set;}

    public bool IsDefault {get; set;}

    public AddressType AddressType {get; set;}

    [ForeignKey(nameof(UserId))]
    public User User {get; set;}
}

public enum AddressType
{
    Home,
    Office
}
