using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopingList.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get ; set; }

        public Product()
        {
            
        }
        public string DisplayText => $"{Name} - {Quantity} {Unit}";


        public Product(string name, string category, decimal quantity, string unit)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            Unit = unit;
            
        }
    }
}
