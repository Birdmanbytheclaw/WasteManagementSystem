using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Serviceinfoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ce9598b-5cfc-498f-95d3-8d279bbf0669");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee61b503-f806-44e6-9cd0-4f0c327e3fd6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7885aae2-f463-4451-8ce3-05a31708201c", "e7109fd5-a0a1-4570-af26-4bd597cc27ab", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "187dcf7b-df9b-4e3e-9455-4de0b09e93b2", "cbe02a97-3ed9-458c-8573-ca24009f5027", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ee61b503-f806-44e6-9cd0-4f0c327e3fd6", "80d8ad8b-bf14-409c-bfdc-cb106d8743cd", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ce9598b-5cfc-498f-95d3-8d279bbf0669", "b23dcac4-1ea2-4036-8f52-1a4af1b4384a", "Employee", "EMPLOYEE" });
        }
    }
}
