using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class LeaveAllocationsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "fef4db67-d31c-4b7f-86f1-a47aa387cbe5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "49647798-26c6-40dd-b583-8ae376de2ad0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79cc45c9-13de-4020-9970-7443d1db7b0b", "AQAAAAEAACcQAAAAEDVtBsR/x8gYhJUB1Jmh2SDOMwH1+Q2BqrjV5H36kdEiXYJ2L/mPNMY6PaHkNOzMxg==", "35600c1b-fd14-4663-aafd-bd312746a732" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe221637-6114-4ba0-be1a-8c6c675cbaff", "AQAAAAEAACcQAAAAEFAfBctXN4pKRbwja8eJ9HRuA3nBSmrd7Hn2bRCig7THuJe7XLXKELnUUdVhsIqMng==", "161cfeb1-ed67-4ba9-b4ff-3b8e32f52904" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b3e9d388-a5b5-4204-98e4-0eecd88d6760");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "14b911af-a5d0-42a2-9833-1c126ed2da06");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbeacdf2-0ae6-470e-aa25-ba2ee37ac6e6", "AQAAAAEAACcQAAAAEBc71kJlJwALuPEfKuK5SO+Z+Cu+cRH/5ZfE3/13jnkFSDtLl31LyG8403LcPIwl+A==", "166209d1-fe67-4745-bbdf-f21e861080be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "789deb52-fbb0-442d-a566-ace17a32081c", "AQAAAAEAACcQAAAAEB/5xOS50VkZuMR6eJcuWsO1f/60RFTg9s4O1KW6zCuGqE2ShIDqLTjrl6rBtCWHcw==", "5816d11b-e6ac-48b0-907c-8155e7719bfa" });
        }
    }
}
