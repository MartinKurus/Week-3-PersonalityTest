using System;

namespace PersonalityTestSwitch
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
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                        Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                        Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
