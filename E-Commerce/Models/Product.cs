using E_Commerce.Data;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageURL { get; set; }
    public ProductColor ProductColor { get; set; }
}
