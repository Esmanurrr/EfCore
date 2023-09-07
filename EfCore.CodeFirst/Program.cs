// See https://aka.ms/new-console-template for more information
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

Initializer.Build();
using (var _context = new AppDbContext())
{
    var product = await _context.Products.FirstAsync();

    Console.WriteLine($"Nesneyi çektiğimizdeki state : {_context.Entry(product).State}"); // --> unchanged

    _context.Remove(product);

    Console.WriteLine($"Nesneyi sildikten sonraki state : {_context.Entry(product).State}"); // --> deleted

    _context.SaveChanges();

    Console.WriteLine($"Veri tabanına yansıtıldığındaki state : {_context.Entry(product).State}"); // --> detached

    /*
    Çağırdığımız nesne üzerinde değişiklik yapıldığında

    var product = await _context.Products.FirstAsync();

    Console.WriteLine($"Nesneyi çektiğimizdeki state : {_context.Entry(product).State}"); --> unchanged

    product.Stock = 1000;

    Console.WriteLine($"Nesnenin property'sinde değişiklik yapıldıktan sonraki state : {_context.Entry(product).State}"); --> modified

    _context.SaveChanges();

    Console.WriteLine($"Veri tabanına yansıtıldığındaki state : {_context.Entry(product).State}"); --> unchanged
    */


    /*
     Yeni nesneyi veri tabanına eklerken

    var newProduct = new Product() { Name = "Kalem 200", Price = 120, Stock = 100, Barcode = 333 };

    Console.WriteLine($"Nesne oluşturulduğundaki state : {_context.Entry(newProduct).State}"); --> detached

    _context.Add(newProduct);

    Console.WriteLine($"Memory'e eklendiğindeki state : {_context.Entry(newProduct).State}"); --> added

    _context.SaveChanges();

    Console.WriteLine($"Veri tabanına yansıtıldığındaki state : {_context.Entry(newProduct).State}"); --> unchanged
    */

    //products.ForEach(p =>
    //{
    //    var state = _context.Entry(p).State;

    //    Console.WriteLine($"{p.Id} : {p.Name} - {p.Price} - {p.Stock} state : {state}");
    //});

}
