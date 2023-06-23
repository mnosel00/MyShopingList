using MyShopingList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopingList.Database
{
    public class ShoppingDbContext: DbContext
    {
        public ShoppingDbContext() : base(GetConnectionString())
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }

        private static string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-B8S1CNR";
            builder.InitialCatalog = "ShopingDb";

            return builder.ToString();
        }
    }
}
