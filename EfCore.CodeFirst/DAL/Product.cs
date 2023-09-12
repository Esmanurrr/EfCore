using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.DAL
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Kdv { get; set; }
        public int Stock { get; set; }
        public int Barcode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal PriceKdv { get; set; }
        //public int? CategoryId { get; set; }
        //public Category? Category { get; set; }
        //public ProductFeature ProductFeature { get; set; }

    }
}
