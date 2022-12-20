using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "099c1478-53e8-4c59-bfb1-cabbc625c8fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "89ee8d36-de3d-4d99-8101-94539c6c313d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "febf16be-99a0-4e08-b47a-97b765d51e78", "AQAAAAEAACcQAAAAEFtTOX8js1Nht29dEWhtn2s85KBo5tqWdzsSERyj4y3zquKpBHPHoZltfzxaeEg3RA==", "cf98a23e-00cf-4ef2-8e7c-64b3bf62b215" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f48d6109-8168-45b6-8e39-85f13a428554", "AQAAAAEAACcQAAAAECdJK2LuRPPwUp2fbWh+p4Up/1MaAc7cv6800Wxo//W9uwmyOC4Y6sx7SipSzcbXRQ==", "c81368f2-d384-4f39-a8db-3ef0bc1b142f" });
        }
    }
}
