using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ETPrintshopWeb.Data
{
    public class RequisitionForm
    {
        [Key]
        public int? Id { get; set; }
        public string? JONumber { get; set; }
        [DataType(DataType.DateTime),Required]
        public DateTime? DateRequested { get; set; } = DateTime.Now.Date;
        public DateTime? DeliveryDate { get; set; }
        public string? Status { get; set; } = "Pending";
        public string? PreparedBy { get; set; }
        public string? ReceivedBy { get; set; }
        public string? ApprovedBy { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
