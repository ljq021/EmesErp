using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Emes.Erp.Host.Migrations
{
    public partial class sys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "System_Post",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false),
                    CreatedById = table.Column<long>(nullable: false),
                    UpdatedById = table.Column<long>(nullable: false),
                    OrgId = table.Column<long>(nullable: false),
                    No = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    MnemonicCode = table.Column<string>(nullable: true),
                    IsKey = table.Column<bool>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Responsibility = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Post", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "System_Role",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false),
                    CreatedById = table.Column<long>(nullable: false),
                    UpdatedById = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "System_User",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    TenantId = table.Column<long>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false),
                    CreatedById = table.Column<long>(nullable: false),
                    UpdatedById = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "System_Post");

            migrationBuilder.DropTable(
                name: "System_Role");

            migrationBuilder.DropTable(
                name: "System_User");
        }
    }
}
