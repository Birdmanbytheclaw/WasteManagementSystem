using Microsoft.EntityFrameworkCore.Migrations;

namespace WasteManagement.Data.Migrations
{
    public partial class AddEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ae86cf4-537d-48a6-b5a0-5f9b4453f446");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b13f9adc-e87b-492b-ae33-fe854b7afb60", "2ecd0aef-8bcf-49f3-a98e-b8d1eb4bc6e0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93d513a0-22d8-40bd-b345-4bf6b242853e", "4439929f-a2d9-42ac-b553-904ea4afbe00", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4f92967-222a-4774-9443-07d086c50ab7", "ab4f7f5a-c73b-4bbf-a384-8e4a882dce5a", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93d513a0-22d8-40bd-b345-4bf6b242853e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b13f9adc-e87b-492b-ae33-fe854b7afb60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4f92967-222a-4774-9443-07d086c50ab7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ae86cf4-537d-48a6-b5a0-5f9b4453f446", "fa89fb42-84b5-4521-8f8c-553d511a9343", "Admin", "ADMIN" });
        }
    }
}
