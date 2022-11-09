using Market.Models;
using System.Collections.Generic;

namespace Market.Repositories;

public class FakeRepos
{
    public static List<Product> ProductList = new()
    {
        new Product()
        {
            Name ="Iphone 14 Pro 128GB",
            Price=1099,
            ImageUrl="https://kontakt.az/wp-content/uploads/2022/09/WWEN_iPhone14ProMax_Q422_Deep-Purple_PDP-IMAGES_Position-1a_png.webp",
            Count=99,
            BuyCount=0
        },
        new Product()
        {
            Name ="MacBook Air 13\"M1 256Gb",
            Price=2490,
            ImageUrl="https://cdn1.it4profit.com/AfrOrF3gWeDA6VOlDG4TzxMv39O7MXnF4CXpKUwGqRM/q:100/plain/s3://catalog-products/201111082124339889/201210170018916895.png@jpeg",
            Count=99,
            BuyCount=0
        },
        new Product()
        {
            Name ="Apple watch7 45mm Blue",
            Price=400,
            ImageUrl="https://smarton.az/storage/products/47126/mkuw3-vw-34frwatch-45-alum-blue-nc-7s-vw-34fr-wf-co.jpg",
            Count=99,
            BuyCount=0
        },
        new Product()
        {
            Name ="Airpods Pro 2nd Gen",
            Price=249,
            ImageUrl="https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/MQD83?wid=1144&hei=1144&fmt=jpeg&qlt=90&.v=1660803972361",
            Count=99,
            BuyCount=0

        },
        new Product()
        {
            Name ="Tesla Model 3",
            Price=55990,
            ImageUrl="https://tesla-cdn.thron.com/delivery/public/image/tesla/c82315a6-ac99-464a-a753-c26bc0fb647d/bvlatuR/std/1200x628/lhd-model-3-social",
            Count=99,
            BuyCount=0
        },
        new Product()
        {
            Name ="Tesla Model X",
            Price=120000,
            ImageUrl="https://tesla-cdn.thron.com/delivery/public/image/tesla/8c26f779-11e5-4cfc-bd7c-dcd03b18ff88/bvlatuR/std/4096x2561/Model-X-Main-Hero-Desktop-LHD",
            Count=99,
            BuyCount=0
        },
    };
}