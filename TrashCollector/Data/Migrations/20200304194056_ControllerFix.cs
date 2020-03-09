using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class ControllerFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "187dcf7b-df9b-4e3e-9455-4de0b09e93b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7885aae2-f463-4451-8ce3-05a31708201c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9037c2c4-ce20-4293-a144-4e26394560ea", "f66e4cf1-851c-4da1-b71f-d559c624e6b4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aff6530c-9fe9-4091-8309-fef6344fa755", "0f060c36-e791-44ce-a29f-bf5fa8b6225d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9037c2c4-ce20-4293-a144-4e26394560ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aff6530c-9fe9-4091-8309-fef6344fa755");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7885aae2-f463-4451-8ce3-05a31708201c", "e7109fd5-a0a1-4570-af26-4bd597cc27ab", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "187dcf7b-df9b-4e3e-9455-4de0b09e93b2", "cbe02a97-3ed9-458c-8573-ca24009f5027", "Employee", "EMPLOYEE" });
        }
    }
}
