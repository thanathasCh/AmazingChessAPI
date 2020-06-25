using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmazingCheeAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameHistories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player1Id = table.Column<long>(nullable: false),
                    Player2Id = table.Column<long>(nullable: false),
                    Winner = table.Column<decimal>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EndedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameHistories_Users_Player1Id",
                        column: x => x.Player1Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameHistories_Users_Player2Id",
                        column: x => x.Player2Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserScores",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(nullable: false),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserScores_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameHistories_Player1Id",
                table: "GameHistories",
                column: "Player1Id");

            migrationBuilder.CreateIndex(
                name: "IX_GameHistories_Player2Id",
                table: "GameHistories",
                column: "Player2Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserScores_UserId",
                table: "UserScores",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameHistories");

            migrationBuilder.DropTable(
                name: "UserScores");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
