using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Review = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Location", "Name", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "Oregon", "Crater Lake National Park", 10, "Great" },
                    { 2, "Washington", "Olympic National Park", 8, "Excellent" },
                    { 3, "Washington", "San Juan Island National Historic Park", 7, "Very Good" },
                    { 4, "Florida", "Everglades National Park", 8, "Awesome, but hot" },
                    { 5, "Utah", "Dead Horse Point State Park", 8, "Nice" },
                    { 6, "Alaska", "Chugach State Park", 6, "Pretty" },
                    { 7, "Florida", "Canaveral National Seashore", 6, "Pretty" },
                    { 8, "Nevada", "Valley of Fire State Park", 8, "Gorgeous, but warm during the day and cold at night" },
                    { 9, "Minnesota", "Voyageurs National Park", 6, "Remote and low average visitor count" },
                    { 10, "Utah", "Bryce Canyon National Park", 1, "Too orange, too spiky" },
                    { 11, "Hawaii", "Haleakalā National Park", 10, "Perfect" },
                    { 12, "Wyoming", "Yellowstone National Park", 9, "Great geyser!" },
                    { 13, "Arizona", "Saguaro National Park", 8, "Lots of cacti!" },
                    { 14, "Tennessee", "Great Smoky Mountains National Park", 2, "Nothing specific to do" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
