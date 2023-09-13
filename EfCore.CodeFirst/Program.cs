// See https://aka.ms/new-console-template for more information
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

Initializer.Build();
using (var _context = new AppDbContext())
{
    
    var category = await _context.Categories.FirstAsync();

    Console.WriteLine("Category çekildi");

    var products = category.Products;

    Console.WriteLine("Products çekildi");

    foreach(var item in products)
    {
        var productFeature = item.ProductFeature;
    };

    Console.WriteLine("İşlem bitti.");


}
