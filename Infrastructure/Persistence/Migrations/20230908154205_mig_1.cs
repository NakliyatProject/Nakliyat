using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    UserSurname = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    UserRole = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "UpdatedDate", "UserName", "UserRole", "UserSurname" },
                values: new object[,]
                {
                    { new Guid("11d8550c-c548-4cbc-8519-4ff82dded7bd"), new DateTime(2023, 9, 8, 15, 42, 4, 924, DateTimeKind.Utc).AddTicks(1035), "user1@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User 1", "Company", "Surname" },
                    { new Guid("155635fb-2711-4be9-b76b-c2c07be8fae1"), new DateTime(2023, 9, 8, 15, 42, 4, 924, DateTimeKind.Utc).AddTicks(1049), "user5@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User 5", "Customer", "Surname" },
                    { new Guid("7fd826e9-cc6e-417c-9fb4-2804653645f7"), new DateTime(2023, 9, 8, 15, 42, 4, 924, DateTimeKind.Utc).AddTicks(1046), "user4@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User 4", "Company", "Surname" },
                    { new Guid("a444452c-b0a7-4798-8c46-6775d250dcd4"), new DateTime(2023, 9, 8, 15, 42, 4, 924, DateTimeKind.Utc).AddTicks(1042), "user3@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User 3", "Customer", "Surname" },
                    { new Guid("bc70c1de-0ae8-44ee-990a-8b2ece934063"), new DateTime(2023, 9, 8, 15, 42, 4, 924, DateTimeKind.Utc).AddTicks(1040), "user2@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User 2", "Customer", "Surname" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
