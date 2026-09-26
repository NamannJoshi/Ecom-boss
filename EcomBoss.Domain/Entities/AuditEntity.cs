namespace EcomBoss.Domain.Entities;

public class AuditEntity
{
    public int CreatedBy {get; set;}

    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;

    public int? UpdatedBy {get; set;}

    public DateTime? UpdatedAt {get; set;}
}