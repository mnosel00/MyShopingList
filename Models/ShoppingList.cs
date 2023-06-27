using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopingList.Models
{
    public class ShoppingList
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsObsolate { get; set; }
        public List<Product> Products { get; set; }

        public ShoppingList()
        {
            Products = new List<Product>();
        }

        // Konstruktor z parametrami
        public ShoppingList(string name)
        {
            Name = name;
            Products = new List<Product>();
        }
    }
}
