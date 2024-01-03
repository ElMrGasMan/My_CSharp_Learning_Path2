using Inheritance.Interfaces;

namespace Inheritance
{
    internal class ClownFish : Mascot, IAquatic, ICagedMascot
    {
        public void Swim() 
        {
            Console.WriteLine("GLOB GLOB I'm a clown fish but I'm boring as hell... glob glob...");
        }

        public int Fins() 
        {
            return 4;
        }

        public double SpaceSquareMet()
        {
            return 2.45;
        }

        public string MaterialCage()
        {
            return "Glass";
        }
    }
}
