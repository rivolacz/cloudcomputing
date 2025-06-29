using CloudComputing.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudComputing;

public class AppDbContext(DbContextOptions<AppDbContext> opts) : DbContext(opts)
{
    public DbSet<Product> Products { get; set; }
}
