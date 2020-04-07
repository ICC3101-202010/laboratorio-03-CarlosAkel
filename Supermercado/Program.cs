using System;
using System.Globalization;
namespace Supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            Ranges uwu = new Ranges("Client",500000,"None",202977448, "Carlos", "Akel", "08-31-1999", "Chilean");// primero salario segundo rut
            Ranges yes = new Ranges("Employee", 320000, "None", 192453678, "Francisco", "Montes","04-27-1990","Chilean");
            Ranges uso = new Ranges(" ", 0, "none", 0, " ", " ", " ", " ");
            Shopping owo = new Shopping(localDate, "Mayo", 3000, "Hellmman's", 300);
            Shopping uso2 = new Shopping(localDate, " ", 0, " ", 0);
            Console.WriteLine("Manual Simulation or Automatic Simulation? (0/1)");
            int top = Int32.Parse(Console.ReadLine());
            if (top == 0)
            {
                uso.AddPeople(uwu);//añado por defecto
                uso.AddPeople(yes);//añado por defecto
                Console.WriteLine("Now we are gonna create people for our supermarket(There are 2 default people)");
                yes.HandMadeList(uso);
                owo.ProductListH(uso2);
                Console.WriteLine("Now its time to stat the simulation");
                uso.PeoplePurchase();
                uso.PeopleSeller();
                owo.Purchase();
            }
            else
            {
                Console.WriteLine("Starting automatic simulation");
                //yes.ListOfPr(uso);
                owo.ProductListRandom(uso2);

            }

            //Console.WriteLine(utcDate);


        }
    }
}
