using System.ComponentModel.DataAnnotations;

namespace ETPrintshopWeb.Data
{
    public class RequisitionItem
    {
        [Key]
        public int? Id { get; set; }
        public string? CTR { get; set; }
        public int? Quantity { get; set; }
        [Required]
        public string? Particular { get; set; }
        public RequisitionForm? RequisitionForm { get; set; }
    }
}
