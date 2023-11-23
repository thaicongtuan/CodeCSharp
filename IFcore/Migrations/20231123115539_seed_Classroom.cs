using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreTutorial.Migrations
{
    /// <inheritdoc />
    public partial class seed_Classroom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classroom",
                columns: new[] { "Id", "Name", "Room", "Teacher" },
                values: new object[,]
                {
                    { 1L, "ThaiCongTuan", "Lab1", "Nguyễn Dũng" },
                    { 2L, "ThaiCongTuan1", "Lab2", "Bảo Dũng" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classroom",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Classroom",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
