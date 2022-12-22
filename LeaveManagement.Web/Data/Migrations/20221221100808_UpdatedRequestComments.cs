using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cf8b01f-b146-4ebe-b882-bf4263bf8e57", "AQAAAAIAAYagAAAAEFsj7kKkLKDzVC37U1LT9tl7qni03FawbU+ClRbqZW9uG02HjK1gW7E6FvjZuslu8Q==", "0df6e899-f397-4a92-8c81-c9cd6884053f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "459993f1-021c-4236-9ed5-4fcec6075fc7", "AQAAAAIAAYagAAAAEOeEwS30YCMryH1zybgzUA87/HvnRXgLSHOzPTpDqhXXnwqw66rTFi7E1edkLtu0zg==", "9cc12a8b-3625-453e-9d06-bf1a82ec0804" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36879c4f-39ff-48dd-9836-66aac05624ab", "AQAAAAIAAYagAAAAECj5UWGAqA9MQVVOu3JWwxwXn1z7VsWb8Npr6MkwtMhoYqHWgdDq9iVzddLmB68BXQ==", "f7bc9c5c-ac06-4b18-a2f5-083808f4adce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7f7ca1b-01a9-4e44-9b10-f0e425d28237", "AQAAAAIAAYagAAAAEEFmO9bV4swMzv5X0/TlS2GhyMTDYA/YDxUTXdqXKs+Ag1fbFhgdGbV+GywdUGpBMg==", "61bec993-5adc-434f-a4b2-cfc72385e3ef" });
        }
    }
}
