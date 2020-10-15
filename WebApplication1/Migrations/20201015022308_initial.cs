using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("12345678-1234-1234-1234-123456123456"), new DateTime(1969, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", "Penduko", "734-867-5309" });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("87654321-4321-4321-4321-654321654321"), new DateTime(1971, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julian", "Talisman", "734-112-2334" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
