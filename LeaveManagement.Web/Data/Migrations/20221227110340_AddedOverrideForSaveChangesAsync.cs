using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedOverrideForSaveChangesAsync : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2490e72d-cb98-41eb-b927-788e8e4b5038", "AQAAAAIAAYagAAAAEKlJ05jqYbegQSNstdQb7PSMeCHGoItrhl4NOCUL0BrjJg+ihEkl1quAaKT9DjTRZg==", "c7d9bd00-b567-4aac-897d-f423f81e85b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1ac4ae6-5286-424d-b840-8c805c23b5ce", "AQAAAAIAAYagAAAAEKX95kquAmCsJLWOkO7puxRk5eYuGh7Epa6dudufkZr36VglfrJd1FFLMB2yWKsbtA==", "3dbcb34b-e971-40dd-badc-3afe0f94f4f8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
