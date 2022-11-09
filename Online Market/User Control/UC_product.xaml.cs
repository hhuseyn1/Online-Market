using Market.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Online_Market.User_Control;

public partial class UC_product : UserControl
{
    public Product? CurrentProduct { get; set; }
    public UC_product(Product? product)
    {
    InitializeComponent();
        DataContext = this;
        CurrentProduct = product;
    }

    private void AddRemove(object sender, RoutedEventArgs e)
    {
        if(sender is Button btn)
        {
            if (btn.Name == "Add")
            {
                if(CurrentProduct?.BuyCount < 99)
                {
                CurrentProduct.BuyCount++;
                    CurrentProduct.IsAdd= true;
                }
            }
            else if (btn.Name == "Remove")
            {
                if (CurrentProduct?.BuyCount > 0)
                {
                    CurrentProduct.BuyCount--;
                    CurrentProduct.IsAdd = false;
                }
            }
        }
    }
}
