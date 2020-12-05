namespace Plantify.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string ProductCategory { get; set; }

        public Product Product { get; set; }
        public Category() { }

        public Category(int categoryId, string productName)
        {
            CategoryId = categoryId;
            ProductCategory = productName;
        }
    }
}
