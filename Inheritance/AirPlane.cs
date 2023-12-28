namespace Inheritance
{
    internal class AirPlane : Vehicle
    {
        private int wings;
        public int Wings { get => wings; set => wings = value; }

        public AirPlane(string? color, int seats, int wings , bool engineRuning = false) : base(color, seats, engineRuning)
        {
            this.wings = wings;
        }

        public override void Drive()
        {
            if(EngineRuning == false)
            {
                Console.WriteLine("I can't fly without the engine started!");
                return;
            }
            Console.WriteLine("I Fly.");
            Console.WriteLine("Damn flying a plane is kinda difficult.");
        }
    }
}
