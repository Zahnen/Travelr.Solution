using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Solution.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "CityName", "Country", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "Bali", "Indonesia", 5, "The best place I've ever been!" },
                    { 2, "Austin, TX", "United States", 4, "Great restaurants and shopping." },
                    { 3, "San Francisco, CA", "United States", 5, "Such a great city!" },
                    { 4, "Seoul", "South Korea", 5, "We had the time of our lives here." },
                    { 5, "Portland, OR", "United States", 5, "Beautiful, but wet." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5);
        }
    }
}
