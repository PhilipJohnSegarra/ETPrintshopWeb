using System.ComponentModel.DataAnnotations;

namespace ETPrintshopWeb.Data
{
    public class Supplier
    {
        [Key]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? ContactPerson {  get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }
        public string? Status { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? DateAdded { get; set; } = DateTime.Now.Date;
        public bool? IsDeleted { get; set; }

    }
}
