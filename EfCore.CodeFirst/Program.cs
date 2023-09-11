// See https://aka.ms/new-console-template for more information
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

Initializer.Build();
using (var _context = new AppDbContext())
{
    //Product => Parent 
    //ProductFeature => Child
    //1. yöntem
    var category = _context.Categories.First(x => x.Name == "Silgiler");
    var product = new Product { Name = "Silgi", Price = 100, Stock = 200, Barcode = 321, Category = category };

    ProductFeature productFeature = new () { Color = "Blue", Height=200, Width=200, Product=product};

    _context.Add(productFeature);
    _context.SaveChanges(); 
    Console.WriteLine("Kaydedildi");

}
