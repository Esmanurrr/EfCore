// See https://aka.ms/new-console-template for more information

using EfCore.DatabaseFirst.DAL;
using Microsoft.EntityFrameworkCore;

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name}");
    });
    
}
