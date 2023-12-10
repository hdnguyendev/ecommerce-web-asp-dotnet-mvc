using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebEcommerce.Models;

namespace WebEcommerce.Data
{
    public class WebEcommerceContext : DbContext
    {
        public WebEcommerceContext (DbContextOptions<WebEcommerceContext> options)
            : base(options)
        {
        }

        public DbSet<WebEcommerce.Models.Product> Product { get; set; } = default!;
        public DbSet<WebEcommerce.Models.Category> Category { get; set; } = default!;
        public DbSet<WebEcommerce.Models.Cart> Cart { get; set; } = default!;
        public DbSet<WebEcommerce.Models.Customer> Customer { get; set; } = default!;
    }
}
