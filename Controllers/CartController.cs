using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System;
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
            var customerId = HttpContext.Session.GetString("CustomerId");
            if (string.IsNullOrEmpty(customerId))
            {
                // Điều hướng tới login
                return RedirectToAction("Login", "Customers");
            }


            // List<Cart> carts = [.. _dbContext.Cart];
            var carts = _dbContext.Cart.Include(c => c.Customer).Include(c => c.Product).Where(c => (c.Customer.CustomerId == int.Parse(customerId)));
            CartViewModel viewModel = new CartViewModel
            {
                Carts = carts.ToList()
            };
            return View(viewModel);
        }
    }
}
