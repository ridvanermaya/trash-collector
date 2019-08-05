using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Web.Migrations
{
    public partial class AddedNewTablePickups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pickup",
                columns: table => new
                {
                    PickupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PickupDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pickup", x => x.PickupId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pickup");
        }
    }
}
