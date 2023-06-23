using MyShopingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopingList.Repositories.Interfaces
{
    public interface IProductRepository
    {
        void addProduct(Product product);
        void updateProduct(Product product);
        void deleteProduct(int productId);
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
    }
}
