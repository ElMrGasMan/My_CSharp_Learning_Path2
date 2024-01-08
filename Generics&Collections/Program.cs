namespace Generics_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Container<string> stringContainer = new(3);

            stringContainer.AddValue("Bismarck class");
            stringContainer.AddValue("Yamato class");
            stringContainer.AddValue("North Carolina class");

            Console.WriteLine("My 3 favorite classes of battleships are: ");

            for (int i = 0; i < stringContainer.GetLength(); i++)
            {
                Console.WriteLine(stringContainer.ObtainValue(i) + ".");
            }
            
        }
    }
}
