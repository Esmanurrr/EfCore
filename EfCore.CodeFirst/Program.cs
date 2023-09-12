// See https://aka.ms/new-console-template for more information
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

Initializer.Build();
using (var _context = new AppDbContext())
{
    //var category = new Category() { Name = "Kalemler" };
    //category.Products.Add(new Product() { Name = "Kalem 1", Price = 100, Stock = 200, Barcode = 123, ProductFeature = new() { Color = "Red", Height = 100, Width = 200 } });
    //category.Products.Add(new Product() { Name = "Kalem 2", Price = 100, Stock = 200, Barcode = 123, ProductFeature = new() { Color = "Blue", Height = 100, Width = 200 } });

    //_context.Add(category);
    //category üzerinden ekleme
    //var categoryWithProducts = _context.Categories.Include(c => c.Products).ThenInclude(p => p.ProductFeature).First();

    //product feature üzerinden ekleme
    //var productFeature = _context.ProductFeatures.Include(x => x.Product).ThenInclude(c=>c.Category).First();

    //product üzerinden ekleme
    //var product = _context.Products.Include(x => x.ProductFeature).Include(y => y.Category).First(); --> iki tane navigation propertysi var o yüzden then kullanmadık


    Console.WriteLine("İşlem bitti.");


}
