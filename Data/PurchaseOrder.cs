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
        public string? SupplierName { get; set; }
        public Supplier? Supplier { get; set; }
        public string? RequesterName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? DeliverySchedule { get; set; }
        public string? PaymentType { get; set; }
        public string? Notes { get; set; }
    }
}
