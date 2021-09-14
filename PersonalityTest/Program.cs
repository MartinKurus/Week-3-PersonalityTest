using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajat sisestada oma lemmikvärv
            //kui kasutaja sisestab punane konsool kuvab oled romantiline
            //kui kasutaja sisestab roheline konsool kuvab oled looduse sober
            //kui kasutaja sisestab midaii muud konsool kuvab oled ukssarvik

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string UserColor = Console.ReadLine();

            if (UserColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if (UserColor == "sinine")
            {
                Console.WriteLine("Oled töökas");
            }
            else if (UserColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else
            {
                Console.WriteLine("Oled ükssarvik.");
            }
        }
    }
}
