namespace WebEcommerce.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }

        // Khóa ngoại
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
