// See https://aka.ms/new-console-template for more information
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

Initializer.Build();
using (var _context = new AppDbContext())
{
    //1. yöntem - student üzerinden ekleme
    //var student = new Student() { Name = "Ahmet", Age = 20 };
    //student.Teachers.Add(new() { Name = "Mehmet Öğretmen" });
    //student.Teachers.Add(new() { Name = "Murat Öğretmen" });

    //2. yöntem - teacher üzerinden ekleme
    //var teacher = new Teacher()
    //{
    //    Name = "Hasan Öğretmen",
    //    Students = new()//list<student> için new
    //    {
    //        //her bir yeni öğrenci için new
    //        new(){Name="Ali", Age=20},
    //        new(){Name="Selin", Age=20},
    //        new(){Name="Ayşe", Age = 20},


    //    }
    //};

    //3. yöntem - var olan teacher'a student ekleme
    var teacher = _context.Teachers.First(x=>x.Name=="Hasan Öğretmen");
    teacher.Students.AddRange(new List<Student>
    {
        new (){Name="Selma", Age=20},
        new (){Name="Yaren", Age=20},
    });

    //_context.Add(teacher); --> zaten track edildiği için gerek yok 
    _context.SaveChanges();

    Console.WriteLine("Kaydedildi");

}
