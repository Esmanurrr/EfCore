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
    //    Name = "Kalemler",
    //    Products = new()
    //    {
    //        new() {Name="Kalem 1", Price =100, Stock=200, Barcode = 123},
    //        new() {Name="Kalem 2", Price =100, Stock=200, Barcode = 123},
    //        new() {Name="Kalem 3", Price =100, Stock=200, Barcode = 123}
    //    }
    //};
    //_context.Add(category);

    var category = _context.Categories.First();

    _context.Categories.Remove(category);


    _context.SaveChanges();

    Console.WriteLine("İşlem Bitti");

}
