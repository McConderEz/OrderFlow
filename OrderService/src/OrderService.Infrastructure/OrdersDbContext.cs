using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderService.Domain.CustomerManagement.Aggregate;
using OrderService.Domain.OrderManagement.Aggregate;

namespace OrderService.Infrastructure;

public sealed class OrdersDbContext: DbContext
{
    private readonly IConfiguration _configuration;

    public OrdersDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
        
        if(Database.GetPendingMigrations().Any())
            Database.Migrate();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
    }

    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
}