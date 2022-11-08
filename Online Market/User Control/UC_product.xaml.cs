using Market.Models;
using System.Windows.Controls;

namespace Online_Market.User_Control;

public partial class UC_product : UserControl
{
    public Product? CurrentProduct { get; set; }
    public UC_product(Product product)
    {
    InitializeComponent();
        DataContext = this;
        CurrentProduct = product;
    }
}
