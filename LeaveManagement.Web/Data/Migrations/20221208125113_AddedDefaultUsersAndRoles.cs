using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "939311bf-35b9-4f32-b19b-098d1b15f313");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "1cd15fd9-0040-44bb-a48f-bf68aa02a9c3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dba90557-45c3-4c8a-ae8c-82ff49129d2d", "AQAAAAEAACcQAAAAEKPecgZtwSzDEWoDKtpAokaol7sh9C8D3DMkWO1vdGFYKMkASpdA08A6PSsckGgKyQ==", "64518627-4de9-4a77-a2d2-3ba8c2fabb93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b778c46-b022-4d5a-9e46-04cfa94fbaa8", "AQAAAAEAACcQAAAAEGfE5GFuXjwxw1fYqsIjEQfPASz001+VUyAQUuadVYtuU6U9reEF2TPf22CSBej3Ug==", "dc1103d7-3323-4437-a4a5-7e92658dfc58" });
        }
    }
}
