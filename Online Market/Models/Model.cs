using System;

namespace Market.Models;
public class Product
{
    public string? Name { get; set; }
    public int Count { get; set; }
    public string? ImageUrl { get; set; }
    public double Price { get; set; }

    public override string ToString() =>
$@"{Name}
{Price}$
{Count} left";


}