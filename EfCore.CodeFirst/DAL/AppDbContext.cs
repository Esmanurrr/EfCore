﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //with fluent API - one-to-many
            //modelBuilder.Entity<Category>().HasMany(x=>x.Products).WithOne(p => p.Category).HasForeignKey(x=>x.Category_Id);
            //one-to-one
            //modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(x => x.Product).HasForeignKey<ProductFeature>(x => x.ProductId);
            //bire çok ilişkide nereye foreign key konulacağı belliydi ama birebir ilişkide belli olmadığı için entity ile belirtiyoruz burada
            //one-to-one 2. yöntem, child classın Id'sini hem primary hem de foreign key olarak  kullanmak
            //modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(x => x.Product).HasForeignKey<ProductFeature>(x => x.Id);

            modelBuilder.Entity<Student>()
                .HasMany(x => x.Teachers)
                .WithMany(x => x.Students)
                .UsingEntity<Dictionary<string, object>>(
                "StudentTeacherManyToMany",
                x => x.HasOne<Teacher>().WithMany().HasForeignKey("Teacher_Id").HasConstraintName("FK__TeacherId"),
                x => x.HasOne<Student>().WithMany().HasForeignKey("Student_Id").HasConstraintName("FK__StudentId")
                );
                

            base.OnModelCreating(modelBuilder);
        }
    }
}
