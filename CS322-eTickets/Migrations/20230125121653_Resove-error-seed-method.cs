using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS322eTickets.Migrations
{
    /// <inheritdoc />
    public partial class Resoveerrorseedmethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5d33480-3178-48e4-bf71-b9566cde8387", "2", "User", "User" },
                    { "b6b2c6ba-1144-46a2-8caf-ddf4f0864113", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d33480-3178-48e4-bf71-b9566cde8387");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6b2c6ba-1144-46a2-8caf-ddf4f0864113");
        }
    }
}
