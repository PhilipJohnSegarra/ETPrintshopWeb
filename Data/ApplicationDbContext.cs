using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ETPrintshopWeb.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<PurchaseOrder> PurchaseOrders { get; set;} = default!;
        public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; } = default!;
        public DbSet<RequisitionForm> RequisitionForms { get; set; } = default!;
        public DbSet<RequisitionItem> RequisitionItems { get; set; } = default!;
        public DbSet<Supplier> Suppliers { get; set; } = default!;
        public DbSet<Sale> Sales { get; set; } = default!;
    }
}
