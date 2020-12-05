
using Plantify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plantify.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();


        static Repository()
        {

            // Products
            // create a new Product objects
            Product product1 = new Product(1, "Mega Grande Ecosystem", 1390.95M, "image1.jpg", "Ecospheres", 15, "The Mega Grande Ecosystem is an elegant glass flask filled with a self-sufficient plants that require no watering or up-keep.");
            Products.Add(product1);

            Product product2 = new Product(2, "Secret Garden Ecosystem", 1240.95M, "image2.jpg", "Ecospheres", 3, "Our bestselling Ecosphere of 2020! The airtight spherical flask is made from recycled glass and is sealed with a cork lid. This popular globe shape is a unique design and is limited edition. It is filled with three stunning tropical plants, including a tree, in a green moss base, all of which have been specially selected by our botanical experts making the perfect bottle garden. Please note plants may vary. It’s the ideal gift for someone who loves the idea of keeping real plants inside their home or office space, but doesn’t have the time to keep them well-maintained. The whole ecosystem is completely self - sufficient, perfect for those that love the addition of greenery in the home but do not have the spare time to maintain the plants. Not only can you enhance any indoor space with a splash of colour, the air-purifying houseplants can rid it of harmful toxins too. This item is available as a fully assembed item or a DIY ecosystem.In our DIY version, all the plants, moss and soil are individually wrapped for the receipient to create their own ecosystem, perfect for the more creative and green fingered! Personalisation and fairy lights are available with the product, making the ideal gift for a loved one.");
            Products.Add(product2);

            Product product3 = new Product(3, "Biome Ecosystem", 990.95M, "image3.jpg", "Ecospheres", 7, "The Limited Edition Biome Ecosystem is an elegant flask made from recycled glass. It is sealed with a cork lid containing self-sufficient plants that require no upkeep or watering. This indoor garden is a great gift for those who like the look of real plants but lack the time or desire to spend on maintenance. The sealed flask allows the process of photosynthesis, keeping the contents fresh and healthy. The self-sustaining plants are chosen by botanical experts. This product comes fully assembled, a DIY option is also available.");
            Products.Add(product3);

            Product product4 = new Product(4, "Aranica Ecojar", 590.95M, "image4.jpg", "Ecospheres", 23, "If you’re looking for the ideal little gift for any plant lover, our Arabica Ecojar can provide a unique display of eye-catching greenery just for them. The self-sufficient ecojar houses a stunning, hand-picked coffea arabica plant, which requires absolutely no maintenance whatsoever. This stress - free, air - purifying houseplant plant is perfect for those with a little green - fingered passion, but who simply don’t have the time to constantly maintain it with a busy schedule.Plus, it makes a great gift if they happen to love coffee too.It sits on a beautiful moss base, within the sealed airtight kilner jar. And if you wanted to give it that extra special touch, you can even add some fairy lights to it, to transform this piece into an even more eye-catching statement for the home, office or retail space.Plant care instructions are included, but the beauty of this ecojar is that it is completely self-sufficient, and works wonders for your wellbeing.This product is now available as a DIY kit!");
          Products.Add(product4);

            Product product5 = new Product(5, "Duo Small Ecosystem", 1640.95M, "image5.jpg", "Ecospheres", 11, "An elegant ecosystem can be the ideal gift for any plant-lover, and with our Duo Baby & Petite Ecosystem set, you can get double the green-fingered goodness. Both of the airtight flasks are made from recycled glass with a cork stopper, and contain a selection of three tropical plants and French natural ball moss. The plants are seasonal and hand-picked by our botanical experts. The self - sufficient ecosystems require no care, making it the perfect present for those with an eye for interiors.A bed of hydro grains stores excess water that is released when the plants need it, keeping the contents hydrated but without any need to water them. Not only can you enhance any indoor space with these beautiful tropical plants, but their air - purifying qualities can rid it of any harmful toxins too.");
            Products.Add(product5);

            Product product6 = new Product(6, "Duo Grande Ecosystem", 2140.95M, "image6.jpg", "Ecospheres", 0, "Choose the perfect green-fingered gift with our ultimate ecosystem set for plant-lovers. The Grande & Mega Grande Ecosystem Duo set includes two elegant glass flasks made from recycled glass. They are filled with self-sufficient hand-picked plants that require no upkeep or watering. Acting as a maintenance - free indoor garden, this set makes a great gift for those who like the look of real plants but lack the time or desire to constantly maintenance them, alongside a busy schedule. Plus, the sealed flask allows the process of photosynthesis to take place, keeping the contents fresh and healthy.The seasonal tropical plants are specially selected by our botanical experts. This item arrives fully assembed, we also offer a DIY set for the more creative!");

              Products.Add(product6);

            Product product7 = new Product(7, "Teardrop Ecosystem", 1240.95M, "image7.jpg", "Ecospheres", 4, "The airtight flask is made from recycled glass and is sealed with a cork lid. This elegent teardrop shape is a unique design and is limited edition. It is filled with three stunning tropical plants on a green moss base, all of which have been specially selected by our botanical experts making the perfect bottle garden. Please note plants may vary. It’s the ideal gift for someone who loves the idea of keeping real plants inside their home or office space, but doesn’t have the time to keep them well-maintained. The whole ecosystem is completely self - sufficient, perfect for those that love the addition of greenery in the home but do not have the spare time to maintain the plants. Not only can you enhance any indoor space with a splash of colour, the air-purifying houseplants can rid it of harmful toxins too. This item is available as a fully assembed item or a DIY ecosystem.In our DIY version, all the plants, moss and soil are individually wrapped for the receipient to create their own ecosystem, perfect for the more creative and green fingered! Personalisation and fairy lights are available with the product, making the ideal gift for a loved one.");
            Products.Add(product7);

            Product product8 = new Product(8, "Petite Ecosystem", 890.95M, "image8.jpg", "Ecospheres", 3, "The airtight flask is made from recycled glass and is sealed with a cork lid. It is filled with three stunning tropical plants on a natural French ball moss base, all of which have been specially selected by our botanical experts. It’s the ideal gift for someone who loves the idea of keeping real plants inside their home or office space, but doesn’t have the time to keep them well-maintained. The whole ecosystem is completely self - sufficient, perfect for those that love the addition of greenery in the home but do not have the spare time to maintain the plants. Not only can you enhance any indoor space with a splash of colour, the air-purifying houseplants can rid it of harmful toxins too. This item arrives fully assembled, we also have a DIY option available and our Duo sets are the perfect gift!");
            Products.Add(product8);

            Product product9 = new Product(9, "Grande Mosarium", 1290.95M, "image9.jpg", "Ecospheres", 0, "Our DIY Grande Mossarium is one of our exciting recently launched products! The product arrives as a DIY kit with vibrant green ball moss, gravel, decorative pebbles, compost and charcoal, complete with an elegant large glass sphere vase with lid. The mossarium makes a unique and stirking focal point in any interior and does not require any watering or upkeep! This indoor botanical product is a great gift for those who like the look of real plants but lack the time or desire to spend on maintenance.Our on trend Mossarium is easy to assemble, layering the gravel, compost, moss balls and decoartive stones.This mossarium makes the perfect gift and can be personalised and fairy lights can be added for that extra wow factor!");
            Products.Add(product9);

            //Customer c1 = new Customer(1, "Tina", "Petterson", "Irisdahlsvej 32", "8200", "Århus N");
            //Customer c2 = new Customer(2, "Thomas", "Larsson", "Solsikkevej 32", "8000", "Århus C");

            //Invoice i1 = new Invoice(1, new DateTime(2016, 9, 12), c1);
            //Invoice i2 = new Invoice(2, new DateTime(2016, 9, 24), c2);

            //i1.AddOrderItem(movie3, 1);
            //i1.AddOrderItem(myBook2, 1);

            //i2.AddOrderItem(myBook, 1);
            //i2.AddOrderItem(myCD2, 1);

            //Invoices.Add(i1);
            //Invoices.Add(i2);
        }

    }
}