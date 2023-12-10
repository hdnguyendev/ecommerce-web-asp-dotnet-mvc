namespace WebEcommerce.Models
{
    public class Shipment
    {
        public int ShipmentId { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string Address { get; set; }

        // Khóa ngoại
        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
