using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelrApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Review = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

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
            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
