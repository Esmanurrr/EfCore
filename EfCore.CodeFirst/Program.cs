// See https://aka.ms/new-console-template for more information
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

Initializer.Build();
using (var _context = new AppDbContext())
{
    //category üzerinden getirme
    //var category = _context.Categories.First();
    ////
    ////
    ////
    //if (true)
    //{
    //    _context.Entry(category).Collection(x => x.Products).Load();
    //    category.Products.ForEach(product =>
    //    {
    //        Console.WriteLine(product.Name);
    //    });
    //};

    var product = _context.Products.First();
    //
    //
    //
    if (true)
    {
        _context.Entry(product).Reference(x => x.ProductFeature).Load();
        
    };

    Console.WriteLine("İşlem bitti.");


}
