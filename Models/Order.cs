namespace WebEcommerce.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        // Khóa ngoại
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
