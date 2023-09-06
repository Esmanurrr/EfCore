// See https://aka.ms/new-console-template for more information
using EfCore.DatabaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using (var _context = new EfCoreDatabaseFirstDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name} - {p.Price} - {p.Stock}");
    });
}