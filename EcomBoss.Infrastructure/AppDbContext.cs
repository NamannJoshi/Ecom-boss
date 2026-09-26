using EcomBoss.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcomBoss.Infrastructure;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

    public DbSet<Address> Addresses {get; set;}

    public DbSet<Order> Orders {get; set;}

    public DbSet<OrderItem> OrderItems {get; set;}

    public DbSet<Payment> Payments {get; set;}

    public DbSet<Product> Products {get; set;}

    public DbSet<ProductVariant> ProductVariants {get; set;}

    public DbSet<User> Users {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
}
