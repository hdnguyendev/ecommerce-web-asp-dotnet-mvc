using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEcommerce.Data;
using WebEcommerce.Models;
using WebEcommerce.ViewModels;

namespace WebEcommerce.Controllers
{
    public class ShopController(WebEcommerceContext dbContext) : Controller
    {
        private readonly WebEcommerceContext _dbContext = dbContext;

        public IActionResult Index()
        {
            List<Product> products = [.. _dbContext.Product];
            List<Category> categories = [.. _dbContext.Category];
            String customerId = HttpContext.Session.GetString("CustomerId");
            ProductViewModel viewModel = new ProductViewModel
            {
                Products = products,
                Categories = categories,
                CustomerId = customerId
            };

            return View(viewModel);
        }
    }
}
