using System.ComponentModel.DataAnnotations.Schema;

namespace WebEcommerce.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int Quantity { get; set; }

        // Khóa ngoại
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; } 
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
