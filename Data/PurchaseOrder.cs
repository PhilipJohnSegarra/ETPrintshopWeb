using System.ComponentModel.DataAnnotations;

namespace ETPrintshopWeb.Data
{
    public class PurchaseOrder
    {
        [Key]
        public int? Id { get; set; }
        public string? Status { get; set; } = "Pending";
        [DataType(DataType.DateTime), Required]
        public DateTime? DateCreated { get; set; } = DateTime.Now.Date;
        public ApplicationUser? User { get; set; }
    }
}
