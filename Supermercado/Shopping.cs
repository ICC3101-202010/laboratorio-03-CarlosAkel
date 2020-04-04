using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    class Shopping :Product
    {
        private string Date;
        public Shopping(string Date, string ProductName, int ProductPrice, string Brand, int Stock) : base(ProductName, ProductPrice, Brand, Stock)
        {
            this.Date = Date;
        }
    }

}
