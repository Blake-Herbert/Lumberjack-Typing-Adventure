using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumberjack_Typing_Adventure_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HighScores",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    playerName = table.Column<string>(type: "TEXT", nullable: false),
                    score = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HighScores", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HighScores");
        }
    }
}
