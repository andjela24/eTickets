using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS322eTickets.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCinemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Cinemas SET Logo = 'https://i.ibb.co/FW0ZsMr/cinema5.jpg' WHERE id = 1");
            migrationBuilder.Sql("UPDATE Cinemas SET Logo = 'https://i.ibb.co/YdX8GMJ/cinema4.jpg' WHERE id = 2");
            migrationBuilder.Sql("UPDATE Cinemas SET Logo = 'https://i.ibb.co/4Z4zXMC/cinema3.jpg' WHERE id = 3");
            migrationBuilder.Sql("UPDATE Cinemas SET Logo = 'https://i.ibb.co/yqkbpg8/cinema2.jpg' WHERE id = 4");
            migrationBuilder.Sql("UPDATE Cinemas SET Logo = 'https://i.ibb.co/4fCBW4k/cinema.jpg' WHERE id = 5");

            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/CJJVb2d/aleksandar-bercek.jpg' WHERE id = 31");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
