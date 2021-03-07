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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        List<ShoppingItem> ShoppingItems;
        public MainWindow()
        {
            InitializeComponent();

            ShoppingItems = new List<ShoppingItem>();
        }
        public void AddShoppingItem(object sender, RoutedEventArgs e)
        {
            Button senderButton = (Button)sender;
            ShoppingItem newItem = new ShoppingItem();
            ShoppingItems.Add(newItem);
            senderButton.Margin = new Thickness(senderButton.Margin.Left, senderButton.Margin.Top+30,0,0);
        }
        public void RemoveItem(object sender, RoutedEventArgs e)
        {
            Button senderButton = (Button)sender;
            bool itemRemoved = false;
            ShoppingItem itemToRemove = null;
            foreach(ShoppingItem shoppingItem in ShoppingItems)
            {
                if(shoppingItem.Button_RemoveItem == senderButton)
                {
                    shoppingItem.RemoveControls();
                    itemToRemove = shoppingItem;
                    itemRemoved = true;
                    Button_AddItem.Margin = new Thickness(Button_AddItem.Margin.Left, Button_AddItem.Margin.Top - 30, 0, 0);
                }
                if (itemRemoved)
                    shoppingItem.MoveControls();
            }
            ShoppingItems.Remove(itemToRemove);
        }
    }
}
