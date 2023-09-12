using Microsoft.EntityFrameworkCore;
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
        public DbSet<Product> Products { get; set; }
        //public DbSet<ProductFeature> ProductFeatures { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.PriceKdv).HasComputedColumnSql("[Price]*[Kdv]");

            modelBuilder.Entity<Product>().Property(x => x.PriceKdv).ValueGeneratedOnAddOrUpdate(); // computed in fluent api
            modelBuilder.Entity<Product>().Property(x => x.PriceKdv).ValueGeneratedOnAdd(); // identity in fluent api
            modelBuilder.Entity<Product>().Property(x => x.PriceKdv).ValueGeneratedNever(); // none in fluent api

            base.OnModelCreating(modelBuilder);
        }
    }
}
