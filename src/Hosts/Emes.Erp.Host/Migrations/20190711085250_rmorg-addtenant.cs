using Microsoft.EntityFrameworkCore.Migrations;

namespace Emes.Erp.Host.Migrations
{
    public partial class rmorgaddtenant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrgId",
                table: "System_Organization",
                newName: "TenantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "System_Organization",
                newName: "OrgId");
        }
    }
}
