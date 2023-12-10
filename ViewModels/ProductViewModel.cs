using WebEcommerce.Models;

namespace WebEcommerce.ViewModels
{
    public class ProductViewModel
    {
        public required List<Product> Products { get; set; }
        public required List<Category> Categories { get; set; }
    }
}
