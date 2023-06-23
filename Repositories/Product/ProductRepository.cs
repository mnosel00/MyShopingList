using MyShopingList.Models;
using MyShopingList.Repositories.Interfaces.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopingList.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void addProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void deleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public void updateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
