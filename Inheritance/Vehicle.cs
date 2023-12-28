using System.Threading.Channels;

namespace Inheritance
{
    internal class Vehicle
    {
        private string? color;
        private bool engineRuning;
        private int seats;
        public string? Color { get => color; set => color = value; }
        public int Seats { get => seats; set => seats = value; }
        public bool EngineRuning { get => engineRuning; set => engineRuning = value; }

        public Vehicle()
        {
            
        }

        public Vehicle(string? color, int seats, bool engineRuning = false)
        {
            this.color = color;
            this.engineRuning = engineRuning;
            this.seats = seats;
        }

        public void StartEngine() 
        {
            if (engineRuning == true) Console.WriteLine("The engine is already running.");
            else
            {
                Console.WriteLine("Starting engine...");
                engineRuning = true;
            }
        }

        public void StopEngine() 
        {
            if (engineRuning == false) Console.WriteLine("The engine is not running.");
            else 
            {
                Console.WriteLine("Stopping engine...");
                engineRuning = false;
            }
        }

        public virtual void Drive() 
        {
            if(engineRuning == false) 
            {
                Console.WriteLine("The engine is not running! I can't Drive like that!");
                return;
            }

            Console.WriteLine("I Drive.");
        }
    }
}
