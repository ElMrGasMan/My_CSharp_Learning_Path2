namespace Inheritance
{
    internal class Car : Vehicle
    {
        private string? model;

        public Car(string? color, int seats, string? model, bool engineRuning = false) : base(color, seats, engineRuning)
        {
            this.model = model;
        }

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("Driving cars is my passion.");
        }
    }
}
