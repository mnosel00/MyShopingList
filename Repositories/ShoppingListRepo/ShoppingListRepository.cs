using MyShopingList.Database;
using MyShopingList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopingList.Repositories.ShoppingListRepo
{
    public class ShoppingListRepository : IShoppingListRepository
    {

        private readonly ShoppingDbContext _context;
        public ShoppingListRepository(ShoppingDbContext shoppingDbContext)
        {
                _context = shoppingDbContext;
        }

        public void AddShoppingList(ShoppingList shoppingList)
         {
            _context.ShoppingLists.Add(shoppingList);
            _context.SaveChanges();
        }

        public void DeleteShoppingList(int shoppingId)
        {
            var shoppingList = _context.ShoppingLists.Find(shoppingId);
            if (shoppingList != null)
            {
                _context.ShoppingLists.Remove(shoppingList);
                _context.SaveChanges();
            }
        }

        public List<ShoppingList> GetAllShoppingLists()
        {
            return _context.ShoppingLists.ToList();
        }

        public ShoppingList GetShoppingList(int shoppingId)
        {
            return _context.ShoppingLists.Find(shoppingId);

        }

        public List<ShoppingList> GetShoppingListsByName(string name)
        {
            return _context.ShoppingLists.Where(sl => sl.Name == name).ToList();

        }

        public void UpdateShoppingList(ShoppingList shoppingList)
        {
            _context.ShoppingLists.Attach(shoppingList);
            _context.Entry(shoppingList).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
