using MyShopingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopingList.Repositories.ProductListRepo
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
    }
}
