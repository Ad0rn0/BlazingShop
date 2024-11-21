using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models;

public class Product
{
    [Key]
    [Required(ErrorMessage = "Product Id is required")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Product Name is required")]
    [MaxLength(50, ErrorMessage = "Product Name cannot be longer than 50 characters")]
    [MinLength(5, ErrorMessage = "Product Name cannot be less than 5 characters")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Product Description is required")]
    [DataType(DataType.Currency)]
    [Range(0, 9999, ErrorMessage = "Product Price must be between 0 and 9999")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Category is required")]
    [Range(1, 9999, ErrorMessage = "Category must be between 1 and 9999")]
    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;
}