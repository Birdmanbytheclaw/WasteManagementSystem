using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class RoleFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5a99ad-f553-4a82-9b8a-db5e8dd0ba5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd6bd89b-ad59-48ac-adf1-370a8c6a16a4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee61b503-f806-44e6-9cd0-4f0c327e3fd6", "80d8ad8b-bf14-409c-bfdc-cb106d8743cd", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ce9598b-5cfc-498f-95d3-8d279bbf0669", "b23dcac4-1ea2-4036-8f52-1a4af1b4384a", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7a5a99ad-f553-4a82-9b8a-db5e8dd0ba5a", "27cf1701-6ab7-4ad3-8058-54c7b539e6b6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd6bd89b-ad59-48ac-adf1-370a8c6a16a4", "f0773c5f-18ea-4ef2-82d8-b12f4f2b0347", "Employee", "EMPLOYEE" });
        }
    }
}
