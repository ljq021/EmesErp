using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Emes.Erp.Host.Migrations
{
    public partial class initdata1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "EffectiveDate",
                table: "System_User",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<bool>(
                name: "IsLimitDuplicateLogin",
                table: "System_User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLock",
                table: "System_User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSystemAccount",
                table: "System_User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "System_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "System_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "System_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemName",
                table: "System_User",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSystemRole",
                table: "System_Role",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "System_Role",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "System_Role",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EffectiveDate",
                table: "System_User");

            migrationBuilder.DropColumn(
                name: "IsLimitDuplicateLogin",
                table: "System_User");

            migrationBuilder.DropColumn(
                name: "IsLock",
                table: "System_User");

            migrationBuilder.DropColumn(
                name: "IsSystemAccount",
                table: "System_User");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "System_User");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "System_User");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "System_User");

            migrationBuilder.DropColumn(
                name: "SystemName",
                table: "System_User");

            migrationBuilder.DropColumn(
                name: "IsSystemRole",
                table: "System_Role");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "System_Role");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "System_Role");
        }
    }
}
