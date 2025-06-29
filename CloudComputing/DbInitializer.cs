using CloudComputing.Models;

namespace CloudComputing;

public static class DbInitializer
{
    public static void Seed(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        if (!db.Products.Any())
        {
            db.Products.AddRange(
                new Product { Name = "Azure Mug", Price = 9.99m },
                new Product { Name = "Cloud T-Shirt", Price = 19.90m });
            db.SaveChanges();
        }
    }
}