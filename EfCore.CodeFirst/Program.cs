// See https://aka.ms/new-console-template for more information
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

Initializer.Build();
using (var _context = new AppDbContext())
{
    //_context.Products.Add(new Product() { Name = "Kalem 43", Price = 100, Stock = 300, Barcode = 123 });
    //_context.Products.Add(new Product() { Name = "Kalem 57", Price = 100, Stock = 300, Barcode = 123 });
    //_context.Products.Add(new Product() { Name = "Kalem 62", Price = 100, Stock = 300, Barcode = 123 });

    //_context.ChangeTracker.Entries().ToList().ForEach(e =>
    //{
    //    if (e.Entity is Product p)
    //    {
    //        if(e.State == EntityState.Added)
    //        {
    //            p.CreatedDate = DateTime.Now;
    //        }
    //    }
    //}); madem ki bu metodu savechangesten hemen önce track edilen entityler için kullanmam gerek, o zaman ben savechanges metodunu override edebilirim --> dbcontextte


    Console.WriteLine($"Context Id : {_context.ContextId}");


    //_context.SaveChanges();

    //var product = await _context.Products.AsNoTracking().ToListAsync();
    //Klasik yöntem
    //product.ForEach(p =>
    //{

    //    Console.WriteLine($"{p.Id} : {p.Name} - {p.Price} - {p.Stock}");
    //});


}
