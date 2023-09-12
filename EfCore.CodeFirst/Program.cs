// See https://aka.ms/new-console-template for more information
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

Initializer.Build();
using (var _context = new AppDbContext())
{
    _context.Products.Add(new() { Name = "Kalem 1", Price = 100, Stock = 200, Barcode = 123, Kdv = 18 });
    _context.SaveChanges();
    Console.WriteLine("İşlem Bitti");
}
