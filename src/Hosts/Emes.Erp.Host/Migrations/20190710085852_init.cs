using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Emes.Erp.Host.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "System_Organization",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    OrgId = table.Column<long>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false),
                    CreatedById = table.Column<long>(nullable: false),
                    UpdatedById = table.Column<long>(nullable: false),
                    ParentId = table.Column<long>(nullable: false),
                    No = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    MnemonicCode = table.Column<string>(nullable: true),
                    IsFiliale = table.Column<bool>(nullable: false),
                    IsSubbranch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Organization", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "System_Organization");
        }
    }
}
