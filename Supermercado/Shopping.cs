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
        public bool ProductListRandom()
        {
            DateTime localDate = DateTime.Now;
            int numbers = 30;
            int i = 0;
            while (i < numbers)
            {
                Shopping tryn5 = new Shopping(localDate, " ", 0, " ", 0);
                int a = 0;
                tryn5.RandomProduct();
                //Console.WriteLine(items.ProductName);
                tryn5.Date = localDate;
                a = 0;
                foreach (Shopping thing in ListP)
                {
                    if(thing.ProductName == tryn5.ProductName && thing.Brand == tryn5.Brand)//previene a que se repitan mismos tipos de productos
                    {
                        a = 1;
                        //Console.WriteLine("bad");
                    }
                    //else
                    //{
                     //   a = 0;
                        
                      //  Console.WriteLine("ok");
                    //}
                    //ListP.Add(items);
                    //Console.WriteLine(items.ProductName + " Brand: " + items.Brand);
                    //i++;
                }
                if (a == 0)
                {
                    ListP.Add(tryn5);
                    Console.WriteLine("Product Name: " + tryn5.ProductName + " Brand: " + tryn5.Brand + " Price: " + tryn5.ProductPrice + "$ Stock " + tryn5.Stock);
                    i++;
                }

            }
            return true;
        }
        public bool ProductListH()
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine("How Many Products?");
            int o = Int32.Parse(Console.ReadLine());
            int h = 0;
            while(h < o)
            {
                Shopping tryn2 = new Shopping(localDate, " ", 0, " ", 0);
                tryn2.HandMadeProduct();
                ListP.Add(tryn2);
                h++;
            }

            //ListP.Add(tryn2);
            Console.WriteLine( "ok");
            return true;
        }
        public bool Purchase()//Registro de la compra
        {
            DateTime localDate = DateTime.Now;
            string uses = "July - 24 - 9:30am";
            List<int> need = new List<int>();
            int amount = 0;

            string u = "y";
            while(u == "y")
            {
                Console.WriteLine("Selec what you want to buy");
                int p = 0;
                foreach (Shopping item in ListP)
                {

                    Console.WriteLine(item.ProductName + " Brand: " + item.Brand + " Price: " + item.ProductPrice + "[" + p + "]");
                    p++;
                }
                int answ = Int32.Parse(Console.ReadLine());
                if (amount < 1)//pido solo una vez la fecha
                {
                    Console.WriteLine("Recording your purchase");
                    Console.WriteLine(localDate);
                    ListP[answ].Date = localDate;
                    int lol = answ;
                }

                need.Add(answ);
                amount++;
                Console.WriteLine("How Many of this Product?");
                int answ2 = Int32.Parse(Console.ReadLine());

                if( answ2 > ListP[answ].Stock)
                {
                    Console.WriteLine("We don't have enough, Try less");
                    Console.WriteLine("How many of this product?");
                    answ2 = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("There was "+ ListP[answ].Stock+ " in stock");
                ListP[answ].Stock -= answ2;
                Console.WriteLine("Now " + ListP[answ].Stock + " in stock");
                Mybuy.Add(ListP[answ]);


                Console.WriteLine("Do you want another one produc?(y/n) ");
                u = Console.ReadLine();
            }


            return true;
        }
        public bool AutoPurchase()
        {
            DateTime localDate = DateTime.Now;
            Random random = new Random();
            int numeroC = random.Next(1, 6);
            int i = 0;
            Console.WriteLine("STARTING NEW TRANSACTION");
            while (i < numeroC){
                int rasss = random.Next(0, 30);
                int lose = random.Next(1, 15);
                Console.WriteLine("The client item that wants to buy is " + ListP[rasss].ProductName);
                Console.WriteLine("There was " + ListP[rasss].Stock + " in stock");
                ListP[rasss].Date = localDate;
                ListP[rasss].Stock -= lose;
                Console.WriteLine("Now " + ListP[rasss].Stock + " in stock");
                i++;
            }
            Console.WriteLine("Transaction Finished");
            Console.WriteLine("--------------------");

            return true;
        }
    }

}
