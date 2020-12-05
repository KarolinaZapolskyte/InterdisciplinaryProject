using Microsoft.EntityFrameworkCore.Migrations;

namespace Plantify.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "Category", "Description", "ImageUrl", "Price", "ProductName", "Stock" },
                values: new object[,]
                {
                    { 1, "Grande", "The Mega Grande Ecosystem is an elegant glass flask filled with a self-sufficient plants that require no watering or up-keep.", "mega-grande-ecosystem.png", 1390.95m, "Mega Grande Ecosystem", 15 },
                    { 2, "Ecospheres", "Our bestselling Ecosphere of 2020! The airtight spherical flask is made from recycled glass and is sealed with a cork lid. This popular globe shape is a unique design and is limited edition. It is filled with three stunning tropical plants, including a tree, in a green moss base, all of which have been specially selected by our botanical experts making the perfect bottle garden. Please note plants may vary. It’s the ideal gift for someone who loves the idea of keeping real plants inside their home or office space, but doesn’t have the time to keep them well-maintained. The whole ecosystem is completely self - sufficient, perfect for those that love the addition of greenery in the home but do not have the spare time to maintain the plants. Not only can you enhance any indoor space with a splash of colour, the air-purifying houseplants can rid it of harmful toxins too. This item is available as a fully assembed item or a DIY ecosystem.In our DIY version, all the plants, moss and soil are individually wrapped for the receipient to create their own ecosystem, perfect for the more creative and green fingered! Personalisation and fairy lights are available with the product, making the ideal gift for a loved one.", "secret-garden-ecosystem.png", 1240.95m, "Secret Garden Ecosystem", 3 },
                    { 3, "Ecospheres", "The Limited Edition Biome Ecosystem is an elegant flask made from recycled glass. It is sealed with a cork lid containing self-sufficient plants that require no upkeep or watering. This indoor garden is a great gift for those who like the look of real plants but lack the time or desire to spend on maintenance. The sealed flask allows the process of photosynthesis, keeping the contents fresh and healthy. The self-sustaining plants are chosen by botanical experts. This product comes fully assembled, a DIY option is also available.", "biome-ecosystem.png", 990.95m, "Biome Ecosystem", 7 },
                    { 4, "Ecospheres", "If you’re looking for the ideal little gift for any plant lover, our Arabica Ecojar can provide a unique display of eye-catching greenery just for them. The self-sufficient ecojar houses a stunning, hand-picked coffea arabica plant, which requires absolutely no maintenance whatsoever. This stress - free, air - purifying houseplant plant is perfect for those with a little green - fingered passion, but who simply don’t have the time to constantly maintain it with a busy schedule.Plus, it makes a great gift if they happen to love coffee too.It sits on a beautiful moss base, within the sealed airtight kilner jar. And if you wanted to give it that extra special touch, you can even add some fairy lights to it, to transform this piece into an even more eye-catching statement for the home, office or retail space.Plant care instructions are included, but the beauty of this ecojar is that it is completely self-sufficient, and works wonders for your wellbeing.This product is now available as a DIY kit!", "aranica-ecojar.png", 590.95m, "Aranica Ecojar", 23 },
                    { 5, "Ecospheres", "An elegant ecosystem can be the ideal gift for any plant-lover, and with our Duo Baby & Petite Ecosystem set, you can get double the green-fingered goodness. Both of the airtight flasks are made from recycled glass with a cork stopper, and contain a selection of three tropical plants and French natural ball moss. The plants are seasonal and hand-picked by our botanical experts. The self - sufficient ecosystems require no care, making it the perfect present for those with an eye for interiors.A bed of hydro grains stores excess water that is released when the plants need it, keeping the contents hydrated but without any need to water them. Not only can you enhance any indoor space with these beautiful tropical plants, but their air - purifying qualities can rid it of any harmful toxins too.", "duo-small-ecosystem.png", 1640.95m, "Duo Small Ecosystem", 11 },
                    { 6, "Grande", "Choose the perfect green-fingered gift with our ultimate ecosystem set for plant-lovers. The Grande & Mega Grande Ecosystem Duo set includes two elegant glass flasks made from recycled glass. They are filled with self-sufficient hand-picked plants that require no upkeep or watering. Acting as a maintenance - free indoor garden, this set makes a great gift for those who like the look of real plants but lack the time or desire to constantly maintenance them, alongside a busy schedule. Plus, the sealed flask allows the process of photosynthesis to take place, keeping the contents fresh and healthy.The seasonal tropical plants are specially selected by our botanical experts. This item arrives fully assembed, we also offer a DIY set for the more creative!", "duo-grande-ecosystem.png", 2140.95m, "Duo Grande Ecosystem", 0 },
                    { 7, "Ecospheres", "The airtight flask is made from recycled glass and is sealed with a cork lid. This elegent teardrop shape is a unique design and is limited edition. It is filled with three stunning tropical plants on a green moss base, all of which have been specially selected by our botanical experts making the perfect bottle garden. Please note plants may vary. It’s the ideal gift for someone who loves the idea of keeping real plants inside their home or office space, but doesn’t have the time to keep them well-maintained. The whole ecosystem is completely self - sufficient, perfect for those that love the addition of greenery in the home but do not have the spare time to maintain the plants. Not only can you enhance any indoor space with a splash of colour, the air-purifying houseplants can rid it of harmful toxins too. This item is available as a fully assembed item or a DIY ecosystem.In our DIY version, all the plants, moss and soil are individually wrapped for the receipient to create their own ecosystem, perfect for the more creative and green fingered! Personalisation and fairy lights are available with the product, making the ideal gift for a loved one.", "teardrop-ecosystem.png", 1240.95m, "Teardrop Ecosystem", 4 },
                    { 8, "Ecospheres", "The airtight flask is made from recycled glass and is sealed with a cork lid. It is filled with three stunning tropical plants on a natural French ball moss base, all of which have been specially selected by our botanical experts. It’s the ideal gift for someone who loves the idea of keeping real plants inside their home or office space, but doesn’t have the time to keep them well-maintained. The whole ecosystem is completely self - sufficient, perfect for those that love the addition of greenery in the home but do not have the spare time to maintain the plants. Not only can you enhance any indoor space with a splash of colour, the air-purifying houseplants can rid it of harmful toxins too. This item arrives fully assembled, we also have a DIY option available and our Duo sets are the perfect gift!", "petite-ecosystem.png", 890.95m, "Petite Ecosystem", 3 },
                    { 9, "Grande", "Our DIY Grande Mossarium is one of our exciting recently launched products! The product arrives as a DIY kit with vibrant green ball moss, gravel, decorative pebbles, compost and charcoal, complete with an elegant large glass sphere vase with lid. The mossarium makes a unique and stirking focal point in any interior and does not require any watering or upkeep! This indoor botanical product is a great gift for those who like the look of real plants but lack the time or desire to spend on maintenance.Our on trend Mossarium is easy to assemble, layering the gravel, compost, moss balls and decoartive stones.This mossarium makes the perfect gift and can be personalised and fairy lights can be added for that extra wow factor!", "grande-mosarium.png", 1290.95m, "Grande Mosarium", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Product");
        }
    }
}
