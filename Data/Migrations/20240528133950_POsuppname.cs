using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETPrintshopWeb.Migrations
{
    /// <inheritdoc />
    public partial class POsuppname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SupplierName",
                table: "PurchaseOrders",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierName",
                table: "PurchaseOrders");
        }
    }
}
