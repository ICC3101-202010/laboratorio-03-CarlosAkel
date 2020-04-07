using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    public class Ranges : Person
    {
        private string Job;
        private int Salary;
        private string Schedule;
        List<Ranges> parts = new List<Ranges>();
        List<Ranges> Buyers = new List<Ranges>();
        List<Ranges> sell = new List<Ranges>();


        public Ranges(string Job, int Salary, string Schedule, int Rut, string Name, string LastName, string Birth, string Nationality) : base(Rut, Name, LastName, Birth, Nationality)
        {
            this.Job = Job;
            this.Salary = Salary;
            this.Schedule = Schedule;
        }

        public void JobChange()
        {
            Console.WriteLine("Select a job Client[0], Employee[1], Boss[2], supervisor[3], auxiliar[4]");//Client, Employee, Boss, supervisors, auxiliares
            int NewJob = Int32.Parse(Console.ReadLine());
            if(NewJob == 0)
            {
                Job = "Client";
            }
            else if(NewJob == 1)
            {
                Job = "Employee";
            }
            else if (NewJob == 2)
            {
                Job = "Boss";
            }
            else if (NewJob == 3)
            {
                Job = "supervisors";
            }
            else if (NewJob == 4)
            {
                Job = "auxiliares";
            }
        }
        public void SalaryChange()
        {
            Console.WriteLine("Write the new Salary(try to be reasonable and for clients think like it's the money you carry on you )");
            int NewSalary = Int32.Parse(Console.ReadLine());
            Salary = NewSalary;

        }
        public void ScheduleChange()
        {
            Console.WriteLine("Chose a Schedule 9am-7:30pm[0] 8:30am-6:30pm[1] 7:30am-5pm[2] 10am-9pm[3] 7am-5:30pm[4] none(for clients)[5]");
            int NewSchedule = Int32.Parse(Console.ReadLine());
            if(NewSchedule == 0)
            {
                Schedule = "9am-7:30pm";
            }
            else if(NewSchedule == 1)
            {
                Schedule = "8:30am-6:30pm";
            }
            else if (NewSchedule == 2)
            {
                Schedule = "7:30am-5pm";
            }
            else if (NewSchedule == 3)
            {
                Schedule = "10am-9pm";
            }
            else if (NewSchedule == 4)
            {
                Schedule = "7am-5:30pm";
            }
            else if (NewSchedule == 5)
            {
                Schedule = "none";
            }
        }
        public void RandomSchedule()//Random
        {
            Random random41 = new Random();
            string[] Chose = { "9am-7:30pm", "8am-8:35pm", "12am-10pm", "10:30am-6:45pm" };
            Schedule = Chose[random41.Next(0, 4)];
        }
        public void RandomJob()//Random
        {
            Random random31 = new Random();
            string[] Jobs = {"Client","Employee"};
            Job = Jobs[random31.Next(0, 2)];
        }
        public void RandomSalary()//Random
        {
            Random random11 = new Random();
            Salary = random11.Next(320000, 1500000);
        }
        public bool ListOfPr()//Random
        {
            //Console.WriteLine("How Many people you want to create?");
            //int Resp = Int32.Parse(Console.ReadLine());
            int Resp = 22;
            int i = 0;
            while (i < Resp)
            {
                Ranges tryn3 = new Ranges(" ", 0, "none", 0, " ", " ", " ", " ");
                tryn3.RandomName();
                tryn3.RandomBirth();
                tryn3.RandomNationality();
                tryn3.RandomRut();
                if(i <= 14)
                {
                    tryn3.Job = "Client";
                }
                else
                {
                    tryn3.Job = "Employee";
                }
                //tryn3.RandomJob();
                tryn3.RandomSalary();
                tryn3.RandomSchedule();
                //Console.WriteLine("Name: " + tryn3.PrintName() + "Rut: " + tryn3.PrintRut() + "Birth: " + tryn3.Printbirth() + "Nationality: " + tryn3.PrintNationality());
                parts.Add(tryn3);
                //Console.WriteLine(tryn3.PrintName());
                i++;
            }
            foreach(Ranges items in parts)
            {
                Console.WriteLine("Name: " + items.PrintName() + " Rut: " + items.PrintRut() + " Birth: " + items.Printbirth() + " Nationality: " + items.PrintNationality());
            }
            return true;
        }

        public bool HandMadeList()
        {
            int j = 0;
            while (j < 1)
            {
                Console.WriteLine("How Much People?(Try at least 1  Client or Employee)");
                j = Int32.Parse(Console.ReadLine());
                if(j == 0)
                {
                    Console.WriteLine("More people pls");
                }
            }
            int l = 0;
            while (l < j)
            {
                Ranges tryn = new Ranges(" ", 0, "none", 0, " ", " ", " ", " ");
                Console.WriteLine("--------------------");
                tryn.HandMade();
                Console.WriteLine("Hi " + tryn.PrintName());
                tryn.JobChange();
                Console.WriteLine("Your job is " + tryn.Job);
                tryn.SalaryChange();
                tryn.ScheduleChange();
                parts.Add(tryn);
                l++;
            }
            return true;
        }
        public string People()
        {
            return $"a";
        }
        public bool PeoplePurchase()//comprador
        {
            Console.WriteLine("Which one are you? (Select the number)");
            int t = 0; 
            foreach (Ranges people in parts)
            {
                if (people.Job == "Client")
                {
                    Console.WriteLine(people.PrintName() + "[" + t + "]");
                }
                t++;
            }
            int answ = Int32.Parse(Console.ReadLine());
            Buyers.Add(parts[answ]);
            return true;
        }
        public bool RandomPurchase()
        {

            foreach(Ranges people in parts)
            {
                if(people.Job == "Client")
                {
                    Buyers.Add(people);
                }
            }
            return true;
        }
        public void RandomPurchaseV2()
        {
            RandomPurchase();
            RandomSeller();
            Random random68 = new Random();
            int ran = random68.Next(0, 14);
            int ran2 = random68.Next(0, 4);
            Console.WriteLine("Employee: " + sell[ran2].PrintName() + " Client: " + Buyers[ran].PrintName() );
        }
        public bool PeopleSeller()//vendedor
        {
            Console.WriteLine("which is the employee that attends you? (Select the number)");
            int t = 0;
            foreach (Ranges people in parts)
            {
                if (people.Job == "Employee")
                {
                    Console.WriteLine(people.PrintName() + "[" + t + "]");
                }
                t++;
            }
            int answ = Int32.Parse(Console.ReadLine());
            sell.Add(parts[answ]);
            return true;
        }
        public bool RandomSeller()
        {
            foreach (Ranges people in parts)
            {
                if (people.Job == "Employee")
                {
                    sell.Add(people);
                }
            }
                return true;
        }
        public void showtransaction(int i)
        {
            string a = Buyers[i].PrintName();
            string b = sell[i].PrintName();
            Console.WriteLine("Employee: "+b+" Client: "+a);
           
        }
        public bool AddPeople(Ranges MyPeople)
        {
            parts.Add(MyPeople);
            return true;
        }
        public void waht()
        {
            int o = 0;
            foreach(Ranges items in parts)
            {
                Console.WriteLine("Name: " + items.PrintName() + " Job: " + items.Job + " Salary: " + items.Salary + " Schedule:"+items.Schedule+ " ["+ o + "]" );
                o++;
            }
            Console.WriteLine("Select witch one you want to change");
            int h = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ChangeJob[0] ChangeSalary[1]  ChangeSchedule[2]");
            int answ2 = Int32.Parse(Console.ReadLine());
            if (answ2 == 0)
            {
                parts[h].JobChange();
            }
            else if (answ2 == 1)
            {
                parts[h].SalaryChange();
            }
            else if (answ2 == 2)
            {
                parts[h].ScheduleChange();
            }
        }
    }
}
