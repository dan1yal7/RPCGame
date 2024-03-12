using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPCGame.Migrations
{
    /// <inheritdoc />
    public partial class Waitingplayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_mathceshistory",
                table: "mathceshistory");

            migrationBuilder.RenameTable(
                name: "mathceshistory",
                newName: "matchesHistory");

            migrationBuilder.AddColumn<bool>(
                name: "IsWaitingPlayer",
                table: "matches",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsWaitingPlayer",
                table: "matchesHistory",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_matchesHistory",
                table: "matchesHistory",
                column: "MatchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_matchesHistory",
                table: "matchesHistory");

            migrationBuilder.DropColumn(
                name: "IsWaitingPlayer",
                table: "matches");

            migrationBuilder.DropColumn(
                name: "IsWaitingPlayer",
                table: "matchesHistory");

            migrationBuilder.RenameTable(
                name: "matchesHistory",
                newName: "mathceshistory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mathceshistory",
                table: "mathceshistory",
                column: "MatchId");
        }
    }
}
