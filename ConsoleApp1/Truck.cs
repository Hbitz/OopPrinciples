using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Truck : Vehicle
    {
        // I teorin så har även bilar en maxvikt, men för enkelhetens skull säger vi maxvikt för bilar är irrelevant medans vi gärna vill veta det på våra lastbilar
        private string maxLoad = "1000kg"; // Vi bestämmer att alla lastbillar som standard kan lasta en vikt på 1000kg
        public string MaxLoad
        {
            get { return maxLoad; } 
            set { maxLoad = value; }
        }
        
        
        // Det här är konstruktorn för våran klass.
        // Detta komme§r köra varje gång vi instantierar klassen.
        // Det betyder att alla truckar kommer ha 200 horsePower och en maxvikt på 1000kg om vi inte sätter något annat
        public Truck()
        {
            horsePower = "200";
        }

        // TotalWheels är en abstract metod från Vehicle som måste implementeras av alla subclasses.
        // Det är väldigt möjligt att detta skulle kunna vara attribut eller liknande och inte en metod, men för exemplets skull så är det detta som gäller :)
        public override void TotalWheels()
        {
            Console.WriteLine("This truck has 8 wheels");
        }

        public override void StartEngine()
        {
            base.StartEngine(); // Unlike our car class, we don't have a customized message with info relevant to our vehicle, we're only using the base funktion. Pff, what a lazy dev~
        }


        public void getMaxLoad()
        {
            Console.WriteLine($"This truck has a max load of {maxLoad}");
        }
    }
}
