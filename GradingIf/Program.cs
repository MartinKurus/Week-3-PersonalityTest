using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde said?");
            string UserGrade = Console.ReadLine();

            if (UserGrade == "5")
            {
                Console.WriteLine("Suurepärane");
            }
            else if (UserGrade == "4")
            {
                Console.WriteLine("Väga hea");
            }
            else if (UserGrade == "3")
            {
                Console.WriteLine("Hea");
            }
            else if (UserGrade == "2")
            {
                Console.WriteLine("Rahuldav");
            }
            else if (UserGrade ==  "1")
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("Puudulik");
            }
        }
    }
}
