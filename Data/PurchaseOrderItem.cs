using System.ComponentModel.DataAnnotations;

namespace ETPrintshopWeb.Data
{
    public class PurchaseOrderItem
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string? Item {  get; set; }
        public int? Quantity { get; set; }
        public string? Unit {  get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }
        public PurchaseOrder? PurchaseOrder { get; set; }
    }
}
