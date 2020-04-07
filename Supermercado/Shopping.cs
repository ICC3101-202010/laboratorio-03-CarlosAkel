using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Supermercado
{
    class Shopping :Product
    {
        List<Shopping> ListP = new List<Shopping>();
        List<Shopping> Mybuy = new List<Shopping>();
        private System.DateTime Date;
        public Shopping(System.DateTime Date, string ProductName, int ProductPrice, string Brand, int Stock) : base(ProductName, ProductPrice, Brand, Stock)
        {
            this.Date = Date;
        }
        public void HandDate()
        {
            Console.WriteLine("Chose a Date(Exp:July-24-9:30am )");
            //Date = Console.ReadLine();
        }
        public bool ProductListRandom(Shopping items)
        {
            DateTime localDate = DateTime.Now;
            int numbers = 30;
            int i = 0;
            while (i < numbers)
            {
                int a = 0;
                items.RandomProduct();
                //Console.WriteLine(items.ProductName);
                items.Date = localDate;
                a = 0;
                foreach (Shopping thing in ListP)
                {
                    if(thing.ProductName != items.ProductName && thing.Brand != items.Brand)
                    {
                        a = 0;
                        Console.WriteLine("ok");
                    }
                    else
                    {
                        a = 1;
                        
                        Console.WriteLine("What");
                    }
                    //ListP.Add(items);
                    //Console.WriteLine(items.ProductName + " Brand: " + items.Brand);
                    //i++;
                }
                if (a == 0)
                {
                    ListP.Add(items);
                    Console.WriteLine(items.ProductName + " Brand: " + items.Brand);
                    i++;
                }

            }
            return true;
        }
        public bool ProductListH(Shopping items)
        {
            Console.WriteLine("How Many Products?");
            int o = Int32.Parse(Console.ReadLine());
            int h = 0;
            while(h <= 0)
            {
                items.HandMadeProduct();
                h++;
            }

            ListP.Add(items);
            Console.WriteLine( "ok");
            return true;
        }
        public bool Purchase()//Registro de la compra
        {
            DateTime localDate = DateTime.Now;
            string uses = "July - 24 - 9:30am";
            List<int> need = new List<int>();
            int amount = 0;
            //Console.WriteLine("Selec what you want to buy");
            int p = 0;
            string u = "y";
            while(u == "y")
            {
                //Console.WriteLine("Selec what you want to buy");
                //Console.WriteLine(ListP[0].ProductName);
                foreach (Shopping item in ListP)
                {
                    Console.WriteLine("Selec what you want to buy");
                    Console.WriteLine(item.ProductName + " Brand: " + item.Brand + " Price: " + item.ProductPrice + "[" + p + "]");
                    p++;
                }
                int answ = Int32.Parse(Console.ReadLine());
                if (amount < 1)//pido solo una vez la fecha
                {
                    Console.WriteLine("Recording your purchase");
                    //Console.WriteLine("Chose a Date(Exp:July-24-9:30am )");
                    //uses = Console.ReadLine();
                    //ListP[answ].Date = uses;
                    //DateTime localDate = DateTime.Now;
                    Console.WriteLine(localDate);
                    ListP[answ].Date = localDate;
                }
                //else
                //{
                //    ListP[answ].Date = localDate;
                //}
                need.Add(answ);
                amount++;
                Console.WriteLine("How many?");
                int answ2 = Int32.Parse(Console.ReadLine());

                if( answ2 > ListP[answ].Stock)
                {
                    Console.WriteLine("We don't have enough, Try less");
                    Console.WriteLine("How many?");
                    answ2 = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("There is "+ ListP[answ].Stock+ "in stock");
                ListP[answ].Stock -= answ2;
                Console.WriteLine("Now " + ListP[answ].Stock + "in stock");
                Mybuy.Add(ListP[answ]);


                Console.WriteLine("Do you want another one produc?(y/n) ");
                u = Console.ReadLine();
            }


            return true;
        }
    }

}
