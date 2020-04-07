using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    public class Person
    {
        
        private int Rut;
        private string Name;
        private string LastName;
        private string Birth;
        private string Nationality;

        public Person(int Rut, string Name, string LastName, string Birth,string Nationality )
        {
            this.Rut = Rut;
            this.Name = Name;
            this.LastName = LastName;
            this.Birth = Birth;
            this.Nationality = Nationality;

        }

        public string Datos()
        {
            return $"{Rut}-{Name}-{LastName}-{Birth}-{Nationality}";
        }
        public void HandMade()
        {
            Console.WriteLine("Choose Rut(Nine digits(194327548))(int)");
            Rut = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Choose name");
            Name = Console.ReadLine();
            Console.WriteLine("Choose LastName");
            LastName = Console.ReadLine();
            Console.WriteLine("Choose Birth(Exp: 04-27-1996)Length = 10");
            string BirthAns = Console.ReadLine();
            while(BirthAns.Length != 10 )
            {
                Console.WriteLine("Choose Birth again pls(Exp: 04-27-1996)");
                BirthAns = Console.ReadLine();
            }
            Birth = BirthAns;
            Console.WriteLine("Choose Nationality");
            Nationality = Console.ReadLine();

                    
        }

        public void RandomName()//Random
        {
            string[] NameNew = { "Isabella", "Mateo", "Agustina", "Agustín", "Sofía", "Santiago", "Emilia", "Tomás", "Josefa", "Lucas", "Isidora", "Benjamín", "Emma", "Gaspar", "Florencia", "Matías", "Trinidad", "Alonso", "Maite", "Vicente", "Julieta", "Joaquín" };
            string[] LastNameNew = { "Gonzales", "Muños", "Rojas", "Diaz", "Perez", "Soto", "Silva", "Contreras", "Lopez", "Rodriguez", "Morales", "Martinez", "Fuentes", "Valenzuela", "Araya", "Sepulveda", "Espinoza" };
            Random random = new Random();
            Name = NameNew[random.Next(0, 22)];
            LastName = LastNameNew[random.Next(0, 17)];
        }
        public void RandomRut()
        {
            Random random2 = new Random();
            Rut = random2.Next(100000000, 300000000);

        }
        public void RandomBirth()
        {
            Random random4 = new Random();
            int a = random4.Next(1, 13);
            int b = random4.Next(1, 30);
            int c = random4.Next(1970, 2005);
            string d = a + "-" + b;
            string f = d + "-" + c;
            Birth = f ;
        }
        public void RandomNationality()
        {
            Random random3 = new Random();
            string[] Natio = { "Chilean", "Australian", "Bolivian", "Costa Rican","English", "French", "Honduran", "Irish", "Italian", "Jamaican", "Japanese", "Malaysian", "Mexican", "Russian","Swedish", "American" };
            Nationality = Natio[random3.Next(0, 16)];
        }
        public string PrintName()
        {
            return $"{Name} {LastName}";
        }
        public int PrintRut()
        {
            return Rut;
        }
        public string Printbirth()
        {
            return Birth;
        }
        public string PrintNationality()
        {
            return Nationality;
        }
    }
}
