using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Repository.Migrations
{
    public partial class UserInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateRegistration = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateLastActivity = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "DateLastActivity", "DateRegistration" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
