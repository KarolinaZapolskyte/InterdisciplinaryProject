using Microsoft.EntityFrameworkCore.Migrations;

namespace Plantify.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Description",
                value: "The Mega Grande Ecosystem is an elegant flask made from recycled glass and is sealed with a cork lid. It is filled with self-sufficient plants that require no watering or up-keep. The sealed flask allows the process of photosynthesis, keeping the contents fresh and healthy.This indoor garden is a great gift for those who like the look of real plants but lack the time or desire to spend on maintenance.The self-sustaining plants are careflly selected by botanical experts. This item arrives fully assembled, it is also available as a DIY kit for the more green fingered!");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Description",
                value: "The Mega Grande Ecosystem is an elegant glass flask filled with a self-sufficient plants that require no watering or up-keep.");
        }
    }
}
