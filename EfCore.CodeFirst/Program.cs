// See https://aka.ms/new-console-template for more information
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

Initializer.Build();
using (var _context = new AppDbContext())
{
    //var category = new Category()
    //{
    //    Name = "Defterler",
    //    Products = new()
    //    {
    //        new() {Name="Defter 1", Price =100, Stock=200, Barcode = 123},
    //        new() {Name="Defter 2", Price =100, Stock=200, Barcode = 123},
    //        new() {Name="Defter 3", Price =100, Stock=200, Barcode = 123}
    //    }
    //};

    var category = _context.Categories.First();
    _context.Categories.Remove(category);

    _context.SaveChanges();

    Console.WriteLine("İşlem Bitti");

}
