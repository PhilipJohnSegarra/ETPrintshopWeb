using System.ComponentModel.DataAnnotations;

namespace ETPrintshopWeb.Data
{
    public class Product
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? BrandName { get; set; }
        public string? Model { get; set; }
        public double? Stocks { get; set; }
        [Required]
        public double? Price { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
