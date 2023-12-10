using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEcommerce.Data;
using WebEcommerce.Models;
using WebEcommerce.ViewModels;

namespace WebEcommerce.Controllers
{
    public class CartController(WebEcommerceContext dbContext) : Controller
    {
        private readonly WebEcommerceContext _dbContext = dbContext;
        public IActionResult Index()
        {
            // List<Cart> carts = [.. _dbContext.Cart];
            var carts = _dbContext.Cart.Include(c => c.Customer).Include(c => c.Product);
            CartViewModel viewModel = new CartViewModel
            {
                Carts = carts.ToList()
            };
            return View(viewModel);
        }
    }
}
