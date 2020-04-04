using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    class Product
    {
        private string ProductName;
        private int ProductPrice;
        private string Brand;
        private int Stock;

        public Product(string ProductName, int ProductPrice,string Brand,int Stock)
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.Brand = Brand;
            this.Stock = Stock;
        }
        public void RandomProduct()
        {
            Random random77 = new Random();
        }
    }
}
