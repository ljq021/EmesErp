using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Emes.Erp.Host.Migrations
{
    public partial class userguid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserGuid",
                table: "System_User",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserGuid",
                table: "System_User");
        }
    }
}
