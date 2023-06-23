using MyShopingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopingList.Repositories.Interfaces
{
    public interface IShoppingListRepository
    {
        void AddShoppingList(ShoppingList shoppingList);
        void UpdateShoppingList(ShoppingList shoppingList);
        void DeleteShoppingList(int shoppingId);
        List<ShoppingList> GetAllShoppingLists();
        ShoppingList GetShoppingList(int shoppingId);
        List<ShoppingList> GetShoppingListsByName(string name);
    }
}
