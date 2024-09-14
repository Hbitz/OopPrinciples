// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings, friends");
            Console.WriteLine("");

            // Instantiera ett objekt av klassen Car.
            Car bil = new();
            bil.SetHorsePower("200");
            bil.StartEngine();
            bil.TotalWheels();
            bil.GetHorsePower();
            Console.WriteLine("");

            // Vi hade kunnat köra mer extensive testning där vi interagerar med alla attribut, egenskaper och metoder, men vi kör bara ett fåtal antal kommandon
            Truck lastbil = new();
            lastbil.getMaxLoad();
            lastbil.StartEngine();
            lastbil.TotalWheels();
            lastbil.GetHorsePower();
            // Säg att vi byter ut delar och uppgraderar motorn.
            lastbil.SetHorsePower("700");
            lastbil.GetHorsePower();
            

            // I Flera av dessa exempel skulle vi kunna ha fler standardvärden eller implmentera constructors för klasserna så vi kan instantiera klassen med alla värden vi vill på en och samma gång.
            // Men det skulle vara ett framtida steg.

            Console.ReadLine();
        }
    }

}

