using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Web.Migrations
{
    public partial class AddedSuspensionServiceStartandEndDatePropertyCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendPickupsEnd",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendPickupsStart",
                table: "Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuspendPickupsEnd",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SuspendPickupsStart",
                table: "Customer");
        }
    }
}
