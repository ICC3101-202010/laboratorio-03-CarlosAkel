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
            Console.WriteLine("Write the new Job");
            string NewJob = Console.ReadLine();
            Job = NewJob;
        }
        public void SalaryChange()
        {
            Console.WriteLine("Write the new Salary");
            int NewSalary = Int32.Parse(Console.ReadLine());
            Salary = NewSalary;

        }
        public void ScheduleChange()
        {
            Console.WriteLine("Write the new Schedule(Exp: 9am-7:30pm)");
            string NewSchedule = Console.ReadLine();
            Schedule = NewSchedule;
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
            string[] Jobs = {"Client","Employee","Boss","Supervisors","Auxiliaries", "Accountant"};
            Job = Jobs[random31.Next(0, 6)];
        }
        public void RandomSalary()//Random
        {
            Random random11 = new Random();
            Salary = random11.Next(320000, 1500000);
        }
        public bool ListOfPr(Ranges Plus)//Random
        {
            //Console.WriteLine("How Many people you want to create?");
            //int Resp = Int32.Parse(Console.ReadLine());
            int Resp = 22;
            int i = 0;
            while (i < Resp)
            {
                Plus.RandomName();
                Plus.RandomBirth();
                Plus.RandomNationality();
                Plus.RandomRut();
                Plus.RandomJob();
                Plus.RandomSalary();
                Plus.RandomSchedule();
                parts.Add(Plus);
                Console.WriteLine(Plus.PrintName());
                i++;
            }
            return true;
        }

        public bool HandMadeList(Ranges Plus2)
        {
            int j = 0;
            while (j < 1)
            {
                Console.WriteLine("How Much People?(Try at least 2 a Client and an Employee)");
                j = Int32.Parse(Console.ReadLine());
                if(j == 0)
                {
                    Console.WriteLine("More people pls");
                }
            }
            int l = 0;
            while (l < j)
            {
                Console.WriteLine("--------------------");
                Plus2.HandMade();
                Console.WriteLine("Hi " + Plus2.PrintName());
                Plus2.JobChange();
                Plus2.SalaryChange();
                Plus2.ScheduleChange();
                parts.Add(Plus2);
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
        public bool showtransaction()
        {
            string a = Buyers[0].PrintName();
            string b = sell[0].PrintName();
            Console.WriteLine("Employee:"+b+"Client:"+a);
            return true;
        }
        public bool AddPeople(Ranges MyPeople)
        {
            parts.Add(MyPeople);
            return true;
        }
    }
}
