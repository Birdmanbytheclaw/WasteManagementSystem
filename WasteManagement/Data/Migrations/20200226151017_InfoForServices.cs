using Microsoft.EntityFrameworkCore.Migrations;

namespace WasteManagement.Data.Migrations
{
    public partial class InfoForServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87148fd6-34ac-4121-a22a-5810375f34ac", "44b4aeec-36ec-49cd-a5e1-e61cbc4c5ca0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7396ccba-515c-49f5-84dd-7f2ef533b28b", "62722462-0a10-4d61-afd1-06dd98409952", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "815b237a-ddc6-40cc-b383-65933b0ace89", "3481940a-dc17-4e01-beb7-aa8c005183a3", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7396ccba-515c-49f5-84dd-7f2ef533b28b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "815b237a-ddc6-40cc-b383-65933b0ace89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87148fd6-34ac-4121-a22a-5810375f34ac");

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
    }
}
