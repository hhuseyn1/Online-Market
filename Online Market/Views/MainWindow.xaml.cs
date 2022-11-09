using Market.Models;
using Market.Repositories;
using Online_Market.User_Control;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Online_Market.Views;
public partial class MainWindow : Window
{
    public ObservableCollection<Product> Products { get; set; } = new();
    public List<Product> ShopList { get; set; } = new();
    public MainWindow()
    {
        InitializeComponent();

        for (int i = 0; i < FakeRepos.ProductList.Count; i++)
        {
            Products.Add(FakeRepos.ProductList[i]);
        }
        for (int i = 0; i < Products.Count; i++)
        {
            UC_product product = new(Products[i]);
            PrPanel.Children.Add(product);
        }
    }

    private void SearchClick(object sender, MouseButtonEventArgs e)
    {
     PrPanel.Children.Clear();
        if(SearchBox.Text.Length > 0)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Name.Contains(SearchBox.Text))
                {
                    UC_product product = new(Products[i]);
                    PrPanel.Children.Add(product);
                }
            }
        }
    }

    private void ShowList(object sender, MouseButtonEventArgs e)
    {
        for (int i = 0; i < Products.Count; i++)
        {
            if (Products[i].IsAdd == true)
            {
                ShopList.Add(Products[i]);
            }
        }
        ProductsView view = new ProductsView(ShopList);
        view.Show();
    }
}
