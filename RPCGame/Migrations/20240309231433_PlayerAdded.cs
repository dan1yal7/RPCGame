using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPCGame.Migrations
{
    /// <inheritdoc />
    public partial class PlayerAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Player1ID",
                table: "matches",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Player2ID",
                table: "matches",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Player1ID",
                table: "matches");

            migrationBuilder.DropColumn(
                name: "Player2ID",
                table: "matches");
        }
    }
}
