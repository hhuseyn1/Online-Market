using Market.Models;
using Market.Repositories;
using Online_Market.User_Control;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Online_Market.Views;
public partial class MainWindow : Window
{
    public ObservableCollection<Product> Products { get; set; } = new();
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
        
    }
}
