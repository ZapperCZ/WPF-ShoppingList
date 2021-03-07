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
    class ShoppingItem
    {
        TextBox Text_ItemDetails;
        CheckBox CheckBox_ItemBought;
        Button Button_RemoveItem;

        public ShoppingItem()
        {
            var mainWindow = Application.Current.Windows
            .Cast<Window>()
            .FirstOrDefault(window => window is MainWindow) as MainWindow;
            //Taken from https://stackoverflow.com/questions/2219097/how-can-i-access-one-windows-control-richtextbox-from-another-window-in-wpf

            Button tempButton = mainWindow.Button_AddItem;

            Text_ItemDetails = new TextBox();
            CheckBox_ItemBought = new CheckBox();
            Button_RemoveItem = new Button();

            Text_ItemDetails.HorizontalAlignment = HorizontalAlignment.Left;
            Text_ItemDetails.VerticalAlignment = VerticalAlignment.Top;
            Text_ItemDetails.Height = 20;
            Text_ItemDetails.Width = 500;
            Text_ItemDetails.Margin = new Thickness(tempButton.Margin.Left+40,tempButton.Margin.Top,0,0);

            CheckBox_ItemBought.HorizontalAlignment = HorizontalAlignment.Left;
            CheckBox_ItemBought.VerticalAlignment = VerticalAlignment.Top;
            CheckBox_ItemBought.Height = 20;
            CheckBox_ItemBought.Width = 20;
            CheckBox_ItemBought.Margin = new Thickness(tempButton.Margin.Left + 580, tempButton.Margin.Top, 0, 0);

            Button_RemoveItem.HorizontalAlignment = HorizontalAlignment.Left;
            Button_RemoveItem.VerticalAlignment = VerticalAlignment.Top;
            Button_RemoveItem.Height = 20;
            Button_RemoveItem.Width = 70;
            Button_RemoveItem.Content = "Smazat";
            Button_RemoveItem.Margin = new Thickness(tempButton.Margin.Left + 660, tempButton.Margin.Top, 0, 0);


            mainWindow.RootGrid.Children.Add(Text_ItemDetails);
            mainWindow.RootGrid.Children.Add(CheckBox_ItemBought);
            mainWindow.RootGrid.Children.Add(Button_RemoveItem);
        }
    }
}
