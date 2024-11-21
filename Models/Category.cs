using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models;

public class Category
{
    [Key]
    [Required(ErrorMessage = "Category Id is required")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Category Title is required")]
    [MaxLength(50, ErrorMessage = "Category Title cannot be longer than 50 characters")]
    [MinLength(5, ErrorMessage = "Category Title cannot be smaller than 5 characters")]
    public string Title { get; set; } = string.Empty;

    public List<Product> Products { get; set; }
}