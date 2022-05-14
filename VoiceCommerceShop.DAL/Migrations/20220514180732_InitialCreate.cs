using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoiceCommerceShop.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarKey);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarKey", "Brand", "Color", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("006efc50-b50d-4b90-8652-e1d8b37a044e"), "Mazda", "Black", "3", 6300.0 },
                    { new Guid("57968317-8e9d-40db-a15c-82456b9d3e7c"), "Toyota", "White", "Auris", 15000.0 },
                    { new Guid("582085c8-00dc-496f-b8df-1cfbf4777b40"), "Mitsubishi", "Blue", "Lancer", 8500.0 },
                    { new Guid("7fa5d45f-fef0-4559-ad42-e83257ad57e5"), "Volkswagen", "Grey", "Polo", 6500.0 },
                    { new Guid("8a436108-ad33-465a-8543-c1a512e39eff"), "Volkswagen", "Black", "Passat", 12000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
