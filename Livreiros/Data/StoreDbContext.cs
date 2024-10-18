using Livreiros.Models;
using Microsoft.EntityFrameworkCore;

namespace Livreiros.Data;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<StoreModel> Stores { get; set; }
}