using Market.Models;
using Online_Market.User_Control;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace Online_Market.Views;

public partial class ProductsView : Window
{
    public float TotalPrice { get; set; } = 0;
    public ProductsView(List<Product> ShopList)
    {
        InitializeComponent();
        DataContext= this;
        foreach (Product item in ShopList)
        {
            UC_productList productList=new UC_productList(item);
            PrListPanel.Children.Add(productList);
            TotalPrice += (float)item.Price;
        }

    }
}
