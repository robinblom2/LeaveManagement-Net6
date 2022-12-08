using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dba90557-45c3-4c8a-ae8c-82ff49129d2d", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKPecgZtwSzDEWoDKtpAokaol7sh9C8D3DMkWO1vdGFYKMkASpdA08A6PSsckGgKyQ==", "64518627-4de9-4a77-a2d2-3ba8c2fabb93", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0b778c46-b022-4d5a-9e46-04cfa94fbaa8", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGfE5GFuXjwxw1fYqsIjEQfPASz001+VUyAQUuadVYtuU6U9reEF2TPf22CSBej3Ug==", "dc1103d7-3323-4437-a4a5-7e92658dfc58", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "7576d31a-a67f-4589-944b-f032d066d2aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "9866cabe-0687-4820-bd69-3e730e01f9e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "224a0f9c-f161-4fd1-ad36-1c01963d104c", false, null, "AQAAAAEAACcQAAAAEAFet5RCtVp9i3v+zK2ebwsNcF+4xxcI7qHRZr3g2jMZWyPp9VlkVbWT0wPW83O9VQ==", "e3532e53-57ca-4d6f-9164-11dd3b564dd4", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c66f1021-a982-4dc9-a550-bdfd10f21f4f", false, null, "AQAAAAEAACcQAAAAEPeXPUEiZn7SQKmHXRoNSvnOpkM37tkxBwOGrwIalAJmKWi91CdIx/Rb5TTwiCpOkQ==", "349a0f61-e2ed-4c87-af32-22152cb0a543", null });
        }
    }
}
