using Market.Models;
using System.Windows;
using System.Windows.Controls;

namespace Online_Market.User_Control;

public partial class UC_productList : UserControl
{
    public float CountPrice { get; set; }
    public Product? CurrentProduct { get; set; }

    public UC_productList(Product product)
    {
        InitializeComponent();
        DataContext= this;
        CurrentProduct = product;
        CountPrice +=(float)CurrentProduct.Price;
    }

    private void AddRemove(object sender, RoutedEventArgs e)
    {
        if(sender is Button btn)
        {
            if (btn.Name == "Add")
            {
                CountPrice += (float)CurrentProduct.Price;
            }
            else if (btn.Name == "Remove")
            {
                CountPrice -= (float)CurrentProduct.Price;
            }
        }
    }
}
