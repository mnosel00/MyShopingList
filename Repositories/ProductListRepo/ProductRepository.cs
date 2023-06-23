using MyShopingList.Database;
using MyShopingList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopingList.Repositories.ProductListRepo
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShoppingDbContext _dbContext;

        public ProductRepository(ShoppingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetProductById(int productId)
        {
            return _dbContext.Products.Find(productId);
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Products.Attach(product);
            _dbContext.Entry(product).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
