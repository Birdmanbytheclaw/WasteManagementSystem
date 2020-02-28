using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a1bec21-4445-4502-ad9f-ff9bfcc84abe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aecd5bd0-10e9-4360-8357-f7abbfc5e6ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a5a99ad-f553-4a82-9b8a-db5e8dd0ba5a", "27cf1701-6ab7-4ad3-8058-54c7b539e6b6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd6bd89b-ad59-48ac-adf1-370a8c6a16a4", "f0773c5f-18ea-4ef2-82d8-b12f4f2b0347", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4a1bec21-4445-4502-ad9f-ff9bfcc84abe", "00ad2cc1-60cd-491d-baef-fb499fb793a0", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aecd5bd0-10e9-4360-8357-f7abbfc5e6ea", "25f97ae3-ca3d-4310-9350-4958eb4fb73d", "Employee", "EMPLOYEE" });
        }
    }
}
