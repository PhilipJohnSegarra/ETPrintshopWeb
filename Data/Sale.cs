using System.ComponentModel.DataAnnotations;

namespace ETPrintshopWeb.Data
{
    public class Sale
    {
        [Key]
        public int? Id { get; set; }
        [DataType(DataType.DateTime),Required]
        public DateTime? Date { get; set; } = DateTime.Now.Date;
        [Required]
        public int? Quantity { get; set; }
        [Required]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        public double? TotalAmount { get; set; }

    }
}
