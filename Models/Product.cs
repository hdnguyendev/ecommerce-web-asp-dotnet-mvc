namespace WebEcommerce.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Khóa ngoại
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
