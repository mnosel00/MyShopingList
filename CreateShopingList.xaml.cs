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
    /// Logika interakcji dla klasy CreateShopingList.xaml
    /// </summary>
    public partial class CreateShopingList : Window
    {
        private readonly ProductRepository _productRepository;
        private readonly ShoppingListRepository _shoppingListRepository;
        List<Product> _products = new List<Product>();

        public CreateShopingList()
        {
            InitializeComponent();
            btnAddList.IsEnabled = false;
            _productRepository = new ProductRepository(new Database.ShoppingDbContext());
            _shoppingListRepository = new ShoppingListRepository(new Database.ShoppingDbContext());
        }

        private void AddProductToList(object sender, RoutedEventArgs e)
        {
            btnAddList.IsEnabled = true;
            string name = txtName.Text;
            string category = txtCategory.Text;
            decimal quantity = decimal.Parse(txtQuantity.Text);
            string unit = txtUnit.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Podaj nazwę produktu.");
                return;
            }
            Product newProduct = new Product(name, category, quantity, unit);

            _products.Add(newProduct);

            
            txtName.Text = "";
            txtCategory.Text = "";
            txtQuantity.Text = "";
            txtUnit.Text = "";


            lstRecentProducts.ItemsSource = null;
            lstRecentProducts.ItemsSource = _products;
            


        }

        private void CreateNewList(object sender, RoutedEventArgs e)
        {
            List<Product> products = _products;
           
            string newListName = Microsoft.VisualBasic.Interaction.InputBox("Enter the name for the new Shopping List:", "New Shopping List");
            ShoppingList newShoppingList = new ShoppingList(newListName);
            newShoppingList.Products = products;
            _shoppingListRepository.AddShoppingList(newShoppingList);
           

            _products.Clear();
            lstRecentProducts.ItemsSource = null;
            btnAddList.IsEnabled = false;
            RefreshShoppingList();
            this.Close();

        }

        private void RefreshShoppingList()
        {
            ShoppingLists shoppingLists = new ShoppingLists();
            shoppingLists.Show();

        }
    }
}
