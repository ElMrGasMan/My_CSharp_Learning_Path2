using Inheritance;
using Inheritance.Interfaces;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thanks to the substitution principle we can do stuff like this:

            IAquatic Ifish1 = new ClownFish();

            // However, this does not let us use the other methods and constants of another
            // interface.
            // Ifish1.MaterialCage(); X not possible X


        }
    }
}
