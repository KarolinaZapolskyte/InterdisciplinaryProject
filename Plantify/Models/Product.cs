using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plantify.Models {

    public class Product {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public string Category { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Category> CategoryNames { get; set; } = new List<Category>();

        // constructor
        public Product() { }

        // constructor
        public Product(int productID, string productName, decimal price, string imageUrl, string category, int stock, string description) {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            ImageUrl = imageUrl;
            Category = category;
            Stock = stock;
            Description = description;
        }

        // method
        public void AddCategory(Category category)
        {
            CategoryNames.Add(category);
        }
    }
}