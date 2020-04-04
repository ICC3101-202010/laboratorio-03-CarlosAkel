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
        List<Person> parts = new List<Person>();


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
        public void RandomSchedule()
        {
            Random random41 = new Random();
            string[] Chose = { "9am-7:30pm", "8am-8:35pm", "12am-10pm", "10:30am-6:45pm" };
            Schedule = Chose[random41.Next(0, 4)];
        }
        public void RandomJob()
        {
            Random random31 = new Random();
            string[] Jobs = {"Client","employee","Boss","supervisors","auxiliaries", "Accountant", "janitor"};
            Job = Jobs[random31.Next(0, 7)];
        }
        public void RandomSalary()
        {
            Random random11 = new Random();
            Salary = random11.Next(320000, 1500000);
        }
        public bool ListOfPr(Ranges Plus)
        {
            Console.WriteLine("Cuantas personas quieres crear?");
            int Resp = Int32.Parse(Console.ReadLine());
            int i = 0;
            Plus.RandomName();
            Plus.RandomBirth();
            Plus.RandomNationality();
            Plus.RandomRut();
            while (i < Resp)
            {
                Plus.RandomName();
                Plus.RandomBirth();
                Plus.RandomNationality();
                Plus.RandomRut();
                parts.Add(Plus);
                Console.WriteLine("Hi " + Plus.PrintName());
                Plus.RandomJob();
                Plus.RandomSalary();
                Plus.RandomSchedule();
                i++;
            }
            return true;
        }

        public bool HandMadeList(Ranges Plus2)
        {
            Console.WriteLine("How Much People?");
            int j = Int32.Parse(Console.ReadLine());
            int l = 0;
            while (l < j)
            {
                Plus2.HandMade();
                Plus2.JobChange();
                Plus2.SalaryChange();
                Plus2.ScheduleChange();
                parts.Add(Plus2);
            }
            return true;
        }
    }
}
