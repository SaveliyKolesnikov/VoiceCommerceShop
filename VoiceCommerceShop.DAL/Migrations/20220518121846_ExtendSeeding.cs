using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoiceCommerceShop.DAL.Migrations
{
    public partial class ExtendSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("006efc50-b50d-4b90-8652-e1d8b37a044e"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("57968317-8e9d-40db-a15c-82456b9d3e7c"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("582085c8-00dc-496f-b8df-1cfbf4777b40"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("7fa5d45f-fef0-4559-ad42-e83257ad57e5"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("8a436108-ad33-465a-8543-c1a512e39eff"));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarKey", "Brand", "Color", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("081c5566-4d82-4503-be35-6abe74ca466f"), "Mazda", "Black", "3", 6300.0 },
                    { new Guid("1a62c66a-bd85-4b58-b397-1fc88ee56303"), "Mitsubishi", "Blue", "Lancer", 8500.0 },
                    { new Guid("20403308-2a1d-4032-9843-14b526a03dfa"), "Mazda", "Red", "6", 12000.0 },
                    { new Guid("41d1a18e-c8eb-4dfc-b92a-ba50f389a463"), "Volkswagen", "Yellow", "Beattle", 15000.0 },
                    { new Guid("9f319617-78c0-44c0-9f14-9066a74b8cde"), "Audi", "Silver", "A6", 20000.0 },
                    { new Guid("b4d30da1-0297-4ca7-92d6-ea8799ade947"), "Volkswagen", "Black", "Passat", 12000.0 },
                    { new Guid("b6ea5624-87b2-4aa9-b3c0-e78e66bc5fc7"), "Volkswagen", "Silver", "Passat", 13000.0 },
                    { new Guid("bb640d19-77e4-4015-9286-d83eb4024736"), "Toyota", "White", "Auris", 15000.0 },
                    { new Guid("d6dab40a-4568-4558-b41c-4fbfc0463fc4"), "Volkswagen", "Red", "Passat", 15000.0 },
                    { new Guid("d80d7b12-be9b-4c81-aefb-ee66448413ba"), "Volkswagen", "Grey", "Polo", 6500.0 },
                    { new Guid("eacd9d70-c505-4fb7-8667-75b67870ac39"), "Mitsubishi", "Black", "Lancer", 9000.0 },
                    { new Guid("f7d9620b-52e0-4966-bf93-a86440cb6d67"), "Audi", "Blue", "Q7", 40000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("081c5566-4d82-4503-be35-6abe74ca466f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("1a62c66a-bd85-4b58-b397-1fc88ee56303"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("20403308-2a1d-4032-9843-14b526a03dfa"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("41d1a18e-c8eb-4dfc-b92a-ba50f389a463"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("9f319617-78c0-44c0-9f14-9066a74b8cde"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("b4d30da1-0297-4ca7-92d6-ea8799ade947"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("b6ea5624-87b2-4aa9-b3c0-e78e66bc5fc7"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("bb640d19-77e4-4015-9286-d83eb4024736"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("d6dab40a-4568-4558-b41c-4fbfc0463fc4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("d80d7b12-be9b-4c81-aefb-ee66448413ba"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("eacd9d70-c505-4fb7-8667-75b67870ac39"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarKey",
                keyValue: new Guid("f7d9620b-52e0-4966-bf93-a86440cb6d67"));

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
    }
}
