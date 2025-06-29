using System.ComponentModel.DataAnnotations;

namespace CloudComputing.Models;
public class Product
{
    public int Id { get; set; }
    [Required, StringLength(100)]
    public string Name { get; set; } = string.Empty;
    [Range(0.01, 9999)]
    public decimal Price { get; set; }
}