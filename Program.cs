using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebEcommerce.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebEcommerceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebEcommerceContext") ?? throw new InvalidOperationException("Connection string 'WebEcommerceContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
