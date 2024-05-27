using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETPrintshopWeb.Migrations
{
    /// <inheritdoc />
    public partial class rfJo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JONumber",
                table: "RequisitionForms",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JONumber",
                table: "RequisitionForms");
        }
    }
}
