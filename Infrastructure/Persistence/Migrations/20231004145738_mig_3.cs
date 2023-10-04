using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30b8ca64-17e2-49ed-8a4f-70a2f1412b70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f9f9c0f-f0e9-48c0-9b5c-35859ab1d678");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb983aac-8f9f-4436-8bcb-d9b3cd3a74c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6cff14c-1cde-458b-a2b5-5880570d1fe8");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4cb71b96-06d0-4e89-ad19-8e57e841294c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a1903ec3-9b8c-4255-a250-7003756c02e0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("aa8473f3-5d5a-4b15-ae8b-1d90cf80f31a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("bc735ee9-9c69-429d-b8be-475ea0cbb4c0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("da6b744d-45af-407b-b4a5-15b85f074bf5"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("132074d1-ad2b-43c3-a224-85acbaad8aaa"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("254ea49f-421d-422f-a792-5d11c077b070"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("440b2f77-61ec-447a-934e-ed34c4ae479c"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("5688bb8f-2260-4289-8cf2-158d1457c600"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("e26779cc-3224-4af5-9549-2137005bba23"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b2548a0-7df9-4f77-b8ac-649a6eeaafa2", "dff694bd-8b74-46a4-a18e-86fec91eba1f", "User", "USER" },
                    { "a9dea9cb-c482-4030-8bf8-024c216e4cbb", "65926663-618b-4ea1-b7ca-9f684be00cee", "Company", "COMPANY" },
                    { "aae1f252-ca00-408e-b2fa-cfba2b7d2c76", "db9fb211-02ff-45a1-90ba-0302b3f3854a", "Admin", "ADMIN" },
                    { "ffbd7256-2e04-477b-afb5-6a0030145bfe", "ddb91232-6a95-402d-a402-d85a1dc455e5", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "CustomerName", "CustomerSurname", "Email", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("34385d9b-3007-4495-9844-09bd81e79ad6"), new DateTime(2023, 10, 4, 14, 57, 37, 859, DateTimeKind.Utc).AddTicks(2896), "Customer1", "Surname", "user1@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67cf3bbf-1527-4148-87c8-69e52d73782b"), new DateTime(2023, 10, 4, 14, 57, 37, 859, DateTimeKind.Utc).AddTicks(2902), "Customer3", "Surname", "user3@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e0e4943-5289-4349-b6dc-0986852ff466"), new DateTime(2023, 10, 4, 14, 57, 37, 859, DateTimeKind.Utc).AddTicks(2920), "Customer4", "Surname", "user4@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c08a3f28-96ae-4537-b0c2-bec1c2749dab"), new DateTime(2023, 10, 4, 14, 57, 37, 859, DateTimeKind.Utc).AddTicks(2900), "Customer2", "Surname", "user2@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf8605e4-b807-451f-9f4e-99f4693e779d"), new DateTime(2023, 10, 4, 14, 57, 37, 859, DateTimeKind.Utc).AddTicks(2921), "Customer5", "Surname", "user5@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TasimaTalebleri",
                columns: new[] { "Id", "Aciklama", "Baslangic", "Bitis", "CreatedDate", "EsyaImgUrl", "Mesafe", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("07ae3a52-f1f8-4414-afe9-200c93639b53"), "tasimatalebi5", "istanbul", "van", new DateTime(2023, 10, 4, 14, 57, 37, 859, DateTimeKind.Utc).AddTicks(3419), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f5dbaae-bf3e-46fd-a74f-d304c536cfc7"), "tasimatalebi3", "istanbul", "igdir", new DateTime(2023, 10, 4, 14, 57, 37, 859, DateTimeKind.Utc).AddTicks(3416), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba71d5e4-50a8-48bb-ae1d-5659534cfb10"), "tasimatalebi2", "istanbul", "ardahan", new DateTime(2023, 10, 4, 14, 57, 37, 859, DateTimeKind.Utc).AddTicks(3415), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c57ebd04-c36d-478b-b565-d98d4f556f6c"), "tasimatalebi4", "istanbul", "agri", new DateTime(2023, 10, 4, 14, 57, 37, 859, DateTimeKind.Utc).AddTicks(3418), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd0a0866-3548-4623-9a55-48e4eee962fb"), "tasimatalebi1", "istanbul", "kars", new DateTime(2023, 10, 4, 14, 57, 37, 859, DateTimeKind.Utc).AddTicks(3412), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b2548a0-7df9-4f77-b8ac-649a6eeaafa2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9dea9cb-c482-4030-8bf8-024c216e4cbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aae1f252-ca00-408e-b2fa-cfba2b7d2c76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffbd7256-2e04-477b-afb5-6a0030145bfe");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("34385d9b-3007-4495-9844-09bd81e79ad6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("67cf3bbf-1527-4148-87c8-69e52d73782b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("9e0e4943-5289-4349-b6dc-0986852ff466"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c08a3f28-96ae-4537-b0c2-bec1c2749dab"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("cf8605e4-b807-451f-9f4e-99f4693e779d"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("07ae3a52-f1f8-4414-afe9-200c93639b53"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("7f5dbaae-bf3e-46fd-a74f-d304c536cfc7"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("ba71d5e4-50a8-48bb-ae1d-5659534cfb10"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("c57ebd04-c36d-478b-b565-d98d4f556f6c"));

            migrationBuilder.DeleteData(
                table: "TasimaTalebleri",
                keyColumn: "Id",
                keyValue: new Guid("fd0a0866-3548-4623-9a55-48e4eee962fb"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "30b8ca64-17e2-49ed-8a4f-70a2f1412b70", "e5cacc1c-ebb7-478c-8bd9-7fc7ca8e6721", "Company", "COMPANY" },
                    { "4f9f9c0f-f0e9-48c0-9b5c-35859ab1d678", "ed4336e7-fa1c-4bac-867f-067f99173ecc", "User", "USER" },
                    { "cb983aac-8f9f-4436-8bcb-d9b3cd3a74c8", "0b5b6db0-9de7-40e7-a1cb-fbf94f1a2786", "Admin", "ADMIN" },
                    { "f6cff14c-1cde-458b-a2b5-5880570d1fe8", "e6248ba6-3abf-4697-b7fd-6eec79609c1c", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "CustomerName", "CustomerSurname", "Email", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("4cb71b96-06d0-4e89-ad19-8e57e841294c"), new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7188), "Customer3", "Surname", "user3@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a1903ec3-9b8c-4255-a250-7003756c02e0"), new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7186), "Customer2", "Surname", "user2@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa8473f3-5d5a-4b15-ae8b-1d90cf80f31a"), new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7192), "Customer5", "Surname", "user5@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc735ee9-9c69-429d-b8be-475ea0cbb4c0"), new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7190), "Customer4", "Surname", "user4@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da6b744d-45af-407b-b4a5-15b85f074bf5"), new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7183), "Customer1", "Surname", "user1@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TasimaTalebleri",
                columns: new[] { "Id", "Aciklama", "Baslangic", "Bitis", "CreatedDate", "EsyaImgUrl", "Mesafe", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("132074d1-ad2b-43c3-a224-85acbaad8aaa"), "tasimatalebi5", "istanbul", "van", new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7736), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("254ea49f-421d-422f-a792-5d11c077b070"), "tasimatalebi4", "istanbul", "agri", new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7735), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("440b2f77-61ec-447a-934e-ed34c4ae479c"), "tasimatalebi1", "istanbul", "kars", new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7729), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5688bb8f-2260-4289-8cf2-158d1457c600"), "tasimatalebi3", "istanbul", "igdir", new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7733), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e26779cc-3224-4af5-9549-2137005bba23"), "tasimatalebi2", "istanbul", "ardahan", new DateTime(2023, 9, 17, 16, 8, 45, 906, DateTimeKind.Utc).AddTicks(7731), "laptop.jpeg", 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
