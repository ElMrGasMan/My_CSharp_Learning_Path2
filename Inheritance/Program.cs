using System.Threading.Channels;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new();
            Cat cat2 = new("8.8cm Flak", "Grey", 3);
            Dog dog1 = new("Dexter", "White", 4, "Poodle");
            Mascot mascot3 = new("Manstein");
            Mascot mascot1 = new(name: "SCP-003", humanYears: 3);
            //To use optional parameters, C# lets us provide the specific name of each parameter.

            cat1.Meow();
            cat2.Meow();
            dog1.Bark();

            //SUBSTITUTION PRINCIPLE----------------------------------------------------------------------

            Mascot mascot2 = new Dog("Kirov", "Brown", 2, "German Sheperd");
            //also: 
            mascot1 = cat2; //Because cats are always mascots
            //This principle let's us do stuff like this:
            Mascot[] mascots = [cat1, dog1, mascot3];
            //However, the limitation is that we can only use methods and properties from the super class

            Console.WriteLine("New methods================================================================");
            foreach (var item in mascots)
            {
                item.Think();
            }
            //Basically they don't get called because the array is of "Mascot", and as such it always calls 
            //the original "Think" method.

            Console.WriteLine("Override methods===========================================================");
            foreach (var item in mascots)
            {
                item.Eat();
            }
            //In this case, because "Eat" is overwriten, every time that we call the method it doesn't matter
            //that the array is of "Mascot", we call the method from the subclass.
        }
    }
}
