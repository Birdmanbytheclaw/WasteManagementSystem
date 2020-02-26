using Microsoft.EntityFrameworkCore.Migrations;

namespace WasteManagement.Data.Migrations
{
    public partial class addressModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01ef68e5-92de-431a-922c-c3d3e98e19fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45669682-41c0-431c-85e4-d122a1d59e88");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c7a6a45-a6ae-4d10-b639-2b9c127d26a3");

            migrationBuilder.AddColumn<double>(
                name: "ZipCode",
                table: "Employee",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1b870a3-1c32-493f-bf38-bb098363dd3b", "5deadcda-7ea9-47bf-ba91-b8f0465cd3b1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "624ebff7-393c-453e-a709-8552eb2da7d1", "96705021-82c9-4cfa-8dfd-45994fac1fec", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f66cffc-b1ca-4043-b4ec-76391a4ad1e1", "6f837635-c775-40d7-a493-def9e3977d91", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f66cffc-b1ca-4043-b4ec-76391a4ad1e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "624ebff7-393c-453e-a709-8552eb2da7d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b870a3-1c32-493f-bf38-bb098363dd3b");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Employee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01ef68e5-92de-431a-922c-c3d3e98e19fa", "6b495593-5311-4ce3-8d41-d32d7d32f34b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45669682-41c0-431c-85e4-d122a1d59e88", "404e8463-aa91-4145-a816-d8261103d110", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c7a6a45-a6ae-4d10-b639-2b9c127d26a3", "467e28ef-6132-46bd-a03d-37553d59a38c", "Employee", "EMPLOYEE" });
        }
    }
}
