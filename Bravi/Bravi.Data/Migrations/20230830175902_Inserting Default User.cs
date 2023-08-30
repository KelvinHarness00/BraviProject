using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravi.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertingDefaultUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Telefone" },
                values: new object[] { new Guid("a379c950-a74a-425c-a78c-ffd1f73dce03"), "userdefault@bravi.com", "User Default", "81999999999" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a379c950-a74a-425c-a78c-ffd1f73dce03"));
        }
    }
}
