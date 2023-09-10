// See https://aka.ms/new-console-template for more information
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

Initializer.Build();
using (var _context = new AppDbContext())
{
    var category = new Category { Name = "Defterler" };

    //product üzerinden category ekleme :
    //var product = new Product { Name = "Kalem 1", Price = 100, Stock = 200, Barcode = 123, Category = category };

    //category üzerinden product ekleme :
    category.Products.Add(new() { Name = "Defter 1", Price = 100, Stock = 200, Barcode = 123 });
    category.Products.Add(new() { Name = "Defter 2", Price = 100, Stock = 200, Barcode = 123 });

    /* Category varsa ekle yoksa hata fırlat
     * var category = _context.Categories.First(x => x.Name = "Defterler");
     * 
     * var product = new Product { Name = "Kalem 1", Price = 100, Stock = 200, Barcode = 123, CategoryId = category.Id };
     * 
     * _context.Add(category);
    */

    _context.Categories.Add(category);
    _context.SaveChanges();

}
