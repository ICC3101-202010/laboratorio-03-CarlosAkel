using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    class Product
    {
        protected string ProductName;
        protected int ProductPrice;
        protected string Brand;
        protected int Stock;

        public Product(string ProductName, int ProductPrice,string Brand,int Stock)
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.Brand = Brand;
            this.Stock = Stock;
        }
        public void RandomProduct()//Random
        {
            Random random77 = new Random();
            string[] RanProd = { "Pollo","Toothpaste","Cafe","Mayo", "Bread", "Sausage", "Butter", "Ice-Cream", "Cockies", "Coca-Cola","Flour","Sugar","Salt","Peper","Eggs","Mustard","Milk","Rice","Water","Apples","Potatoes","Carrots","Cheese","Lemons","Snickers","Chips" };
            ProductName = RanProd[random77.Next(0,26)];
            ProductPrice = random77.Next(1000, 8000);
            string[] RanBrands = {"Milo","Super Pollo","Soprole","Colgate","Oreo","Lay's","KitKat","7up","Hellmann's","Nestle" };
            Brand = RanBrands[random77.Next(0, 10)];
            Stock = random77.Next(200, 1000);
            //Console.WriteLine(ProductName +" "+ Brand);
        }
        public void HandMadeProduct()
        {
            Console.WriteLine("ProductName");
            ProductName = Console.ReadLine();
            Console.WriteLine("Price");
            ProductPrice = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Brand");
            Brand = Console.ReadLine();
            Console.WriteLine("Stock");
            Stock = Int32.Parse(Console.ReadLine());
        }
        public string ShowProducts()
        {
            return "";
        }
    }
}
