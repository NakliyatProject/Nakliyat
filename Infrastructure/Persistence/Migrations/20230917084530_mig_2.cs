using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "324e7991-bd38-4643-a965-1a8148d23596");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "977e9007-0998-43d1-bc46-2c843c5790fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e1e8a14-b594-4dfe-8c16-ab0593868240");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e35cd3bf-c049-439c-866e-a2c35f604a95");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1c60a8ef-16b3-499c-9b6f-7f45c92514d0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1f1dcf50-69fa-4067-aef4-eeb169e21643"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("420d83ab-63fc-40fc-9b36-82bb90a40442"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("849e2c53-de7f-449c-8320-e78787f8b2f5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("e72a4f18-02c6-4487-9726-39b3e1c79370"));

            migrationBuilder.AlterColumn<string>(
                name: "EsyaImgUrl",
                table: "TasimaTalebleri",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21eb7b00-244e-44b2-9308-cac8fd81ea0b", "9bc464fb-fa21-487c-9f30-e00945c7fef9", "User", "USER" },
                    { "95234b8e-cef3-4d31-889f-157786829974", "6dc4be18-ec3e-45da-8caf-043570a28742", "Company", "Company" },
                    { "b9728508-bb4a-4163-ad64-d91f3b57b536", "dedf3024-aa41-4058-b7f0-934e5d6f03ed", "Customer", "CUSTOMER" },
                    { "cc56de89-988c-4b9d-b2af-0bf1ccb1f44b", "ceaebe6f-4130-4802-bf2c-3d666ec84bc5", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "CustomerName", "CustomerSurname", "Email", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("4206a69e-8580-44a6-a32a-405677d0b8c0"), new DateTime(2023, 9, 17, 8, 45, 29, 998, DateTimeKind.Utc).AddTicks(4511), "Customer4", "Surname", "user4@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5a3020a9-9666-4210-81e2-a88414cba11f"), new DateTime(2023, 9, 17, 8, 45, 29, 998, DateTimeKind.Utc).AddTicks(4505), "Customer1", "Surname", "user1@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6cf714db-7235-4da6-8878-a564b4fa3111"), new DateTime(2023, 9, 17, 8, 45, 29, 998, DateTimeKind.Utc).AddTicks(4508), "Customer2", "Surname", "user2@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c56fd58b-eda7-4870-a271-c07c101a3e8c"), new DateTime(2023, 9, 17, 8, 45, 29, 998, DateTimeKind.Utc).AddTicks(4513), "Customer5", "Surname", "user5@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc223b67-0570-4613-aedc-6e2ffe63b7d6"), new DateTime(2023, 9, 17, 8, 45, 29, 998, DateTimeKind.Utc).AddTicks(4510), "Customer3", "Surname", "user3@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TasimaTalebleri",
                columns: new[] { "Id", "Aciklama", "Baslangic", "Bitis", "CreatedDate", "EsyaImgUrl", "Mesafe", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("03eacc1e-5fad-4bfb-a1c4-9e3de713fd6e"), "tasimatalebi3", "istanbul", "igdir", new DateTime(2023, 9, 17, 8, 45, 29, 998, DateTimeKind.Utc).AddTicks(4961), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39bae7d0-e7dd-49c5-a76d-7f89725a481a"), "tasimatalebi4", "istanbul", "agri", new DateTime(2023, 9, 17, 8, 45, 29, 998, DateTimeKind.Utc).AddTicks(4963), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b9c37eb-aece-4538-9417-d87d01f9f040"), "tasimatalebi1", "istanbul", "kars", new DateTime(2023, 9, 17, 8, 45, 29, 998, DateTimeKind.Utc).AddTicks(4955), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73a280be-2177-4bca-9068-ff5fb563d11c"), "tasimatalebi5", "istanbul", "van", new DateTime(2023, 9, 17, 8, 45, 29, 998, DateTimeKind.Utc).AddTicks(4964), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9084b3f1-7100-41f1-a16d-1c7619eff551"), "tasimatalebi2", "istanbul", "ardahan", new DateTime(2023, 9, 17, 8, 45, 29, 998, DateTimeKind.Utc).AddTicks(4960), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21eb7b00-244e-44b2-9308-cac8fd81ea0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95234b8e-cef3-4d31-889f-157786829974");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9728508-bb4a-4163-ad64-d91f3b57b536");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc56de89-988c-4b9d-b2af-0bf1ccb1f44b");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4206a69e-8580-44a6-a32a-405677d0b8c0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5a3020a9-9666-4210-81e2-a88414cba11f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6cf714db-7235-4da6-8878-a564b4fa3111"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c56fd58b-eda7-4870-a271-c07c101a3e8c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("cc223b67-0570-4613-aedc-6e2ffe63b7d6"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("03eacc1e-5fad-4bfb-a1c4-9e3de713fd6e"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("39bae7d0-e7dd-49c5-a76d-7f89725a481a"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("3b9c37eb-aece-4538-9417-d87d01f9f040"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("73a280be-2177-4bca-9068-ff5fb563d11c"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("9084b3f1-7100-41f1-a16d-1c7619eff551"));

            migrationBuilder.AlterColumn<string>(
                name: "EsyaImgUrl",
                table: "TasimaTalebleri",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "324e7991-bd38-4643-a965-1a8148d23596", "072cbbcc-e436-4643-842d-ade4383a87c7", "Company", "Company" },
                    { "977e9007-0998-43d1-bc46-2c843c5790fb", "36156bec-b3f3-4a79-befe-d5086b7b35c1", "User", "USER" },
                    { "9e1e8a14-b594-4dfe-8c16-ab0593868240", "73d51167-e3b3-4677-825a-83237fb8820f", "Customer", "CUSTOMER" },
                    { "e35cd3bf-c049-439c-866e-a2c35f604a95", "e1667afe-65e4-461a-9d45-af166cb7faa7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "CustomerName", "CustomerSurname", "Email", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1c60a8ef-16b3-499c-9b6f-7f45c92514d0"), new DateTime(2023, 9, 16, 15, 24, 9, 315, DateTimeKind.Utc).AddTicks(9222), "Customer3", "Surname", "user3@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f1dcf50-69fa-4067-aef4-eeb169e21643"), new DateTime(2023, 9, 16, 15, 24, 9, 315, DateTimeKind.Utc).AddTicks(9219), "Customer2", "Surname", "user2@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("420d83ab-63fc-40fc-9b36-82bb90a40442"), new DateTime(2023, 9, 16, 15, 24, 9, 315, DateTimeKind.Utc).AddTicks(9224), "Customer4", "Surname", "user4@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("849e2c53-de7f-449c-8320-e78787f8b2f5"), new DateTime(2023, 9, 16, 15, 24, 9, 315, DateTimeKind.Utc).AddTicks(9225), "Customer5", "Surname", "user5@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e72a4f18-02c6-4487-9726-39b3e1c79370"), new DateTime(2023, 9, 16, 15, 24, 9, 315, DateTimeKind.Utc).AddTicks(9213), "Customer1", "Surname", "user1@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
