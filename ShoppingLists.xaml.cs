using MyShopingList.Models;
using MyShopingList.Repositories.ProductListRepo;
using MyShopingList.Repositories.ShoppingListRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyShopingList
{
    /// <summary>
    /// Logika interakcji dla klasy ShoppingLists.xaml
    /// </summary>
    public partial class ShoppingLists : Window
    {
        private readonly ShoppingListRepository _shoppingListRepository;
        private readonly ProductRepository _productRepository;
        List<ShoppingList> _shoppingLists = new List<ShoppingList>();
        public ShoppingLists()
        {
            InitializeComponent();
            _productRepository = new ProductRepository(new Database.ShoppingDbContext());
            _shoppingListRepository = new ShoppingListRepository(new Database.ShoppingDbContext());

            _shoppingLists = _shoppingListRepository.GetAllShoppingLists();

            listOfShoppingLists.ItemsSource = _shoppingLists;

        }
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if(listOfShoppingLists.SelectedItem is ShoppingList selectedList)
            {
                if(obsoleteCheckBox.IsChecked==true)
                {
                    selectedList.IsObsolate = true;
                }
                else
                {
                    _shoppingListRepository.DeleteShoppingList(selectedList.Id);
                    _shoppingLists.Remove(selectedList);
                    listOfShoppingLists.ItemsSource = null;
                    listOfShoppingLists.ItemsSource = _shoppingLists;
                }
            }
        }
    }
}
