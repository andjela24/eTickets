using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS322eTickets.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePrices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Movies SET Price = 1000 WHERE id = 1");
            migrationBuilder.Sql("UPDATE Movies SET Price = 1150 WHERE id = 2");
            migrationBuilder.Sql("UPDATE Movies SET Price = 950 WHERE id = 3");
            migrationBuilder.Sql("UPDATE Movies SET Price = 1000 WHERE id = 4");
            migrationBuilder.Sql("UPDATE Movies SET Price = 850 WHERE id = 5");
            migrationBuilder.Sql("UPDATE Movies SET Price = 1150 WHERE id = 6");
            migrationBuilder.Sql("UPDATE Movies SET Price = 1000 WHERE id = 7");
            migrationBuilder.Sql("UPDATE Movies SET Price = 1200 WHERE id = 8");
            migrationBuilder.Sql("UPDATE Movies SET Price = 750 WHERE id = 9");
            migrationBuilder.Sql("UPDATE Movies SET Price = 1000 WHERE id = 10");
            migrationBuilder.Sql("UPDATE Movies SET Price = 1150 WHERE id = 11");
            migrationBuilder.Sql("UPDATE Movies SET Price = 850 WHERE id = 12");
            migrationBuilder.Sql("UPDATE Movies SET Price = 950 WHERE id = 13");
            migrationBuilder.Sql("UPDATE Movies SET Price = 1000 WHERE id = 14");
            migrationBuilder.Sql("UPDATE Movies SET Price = 1000 WHERE id = 15");
            migrationBuilder.Sql("UPDATE Movies SET Price = 750 WHERE id = 16");
            migrationBuilder.Sql("UPDATE Movies SET Price = 950 WHERE id = 17");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
