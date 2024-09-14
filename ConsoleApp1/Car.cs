using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     internal class Car : Vehicle
    {
        public override void TotalWheels() // I detta fall så är värdet och metoden hårdkodad bara för att minimalt klara uppgiften.
                                           // I andra/riktiga fall så hade det varit mer praktiskt att ha en bättre struktur med attribut, getter och setters som vi kan redigera och snyggare använda våra värden.
        {
            Console.WriteLine("This car has 4 wheels");
        }
        // Det här gör så att varje gång ett object av Cars instantieras(skapas) så sätter vi horsePower till 130
        public Car() 
        {
            horsePower = "130";
        }

        public override void StartEngine()
        {
            Console.WriteLine("You start the engine and it goes \"brrum\"");
        }
    }
}
