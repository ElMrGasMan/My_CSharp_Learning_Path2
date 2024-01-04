namespace Properties
{
    enum Seasons
    {
        Spring, Summer, Fall, Winter
    }

    enum Voltage 
    {
        Low = 20, Medium = 30, High = 50, VeryHigh = 90;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new("John", -2500);

            //The actual object when we call the constructors is stored in the "heap" 
            //the variable "coordinates1" gets stored in the stack and itself stores 
            //a pointer to that object in the heap. 

            //This means that asigning this pointer variable to another one "coordinates2",
            //in this case, what happens is that this last one stores the POINTER, which means
            //that both variables point to the same object.

            Console.WriteLine("===Classes:===");

            Coordinates2D coordinates1 = new(5, 8);
            Coordinates2D coordinates2 = coordinates1;

            Console.WriteLine("Unchanged X: " + coordinates1.X);
            coordinates2.X = 15;
            Console.WriteLine("Changed X: " + coordinates1.X);

            //This doesn't happen with structs, since they are stored in the stack (if they are
            //not very big, otherwise they get stored in the heap anyway).

            Console.WriteLine("===Structs===");

            Coordinate2D coordinate1S = new(3, 17);
            Coordinate2D coordinate2S = coordinate1S;

            Console.WriteLine("Unchanged X: " + coordinate1S.X);
            coordinate2S.X = 15;
            Console.WriteLine("Changed X: " + coordinate1S.X);

            Seasons bestSeason = Seasons.Fall; //We get the name of the value
            Console.WriteLine("The best season is: " + bestSeason);

            int seasonNumber = (int)Seasons.Fall; //Casting is necessary to get the value
            string seasonString = Seasons.Winter.ToString(); //ToString method necessary to store as a string
        }
    }
}
