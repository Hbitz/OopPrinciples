using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     abstract class Vehicle
    {
        /* Det här är vår basklass och kommer innehålla olika typer av värden och metoder som alla våra fordon kommer ha
         * 
         */
        protected string modelName;
        protected string horsePower;

        public string GetModel
        {
            get { return modelName; }
            set { modelName = value; }
        }

        public void SetHorsePower(string HorsePower)
        {
            horsePower = HorsePower;
        }

        public void GetHorsePower()
        {
            Console.WriteLine($"This vehicle has a horsepower of {horsePower}");
            //return horsePower;
        }

        // Måste implementeras av alla klasses som ärver av denna
        public abstract void TotalWheels();



        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle goes vroom");
        }
    }
}
