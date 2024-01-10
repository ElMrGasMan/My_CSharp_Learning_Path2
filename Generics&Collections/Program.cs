namespace Generics_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FooContainer<Foo> stringContainer = new(3);

            stringContainer.AddValue(new Foo(25));
            stringContainer.AddValue(new Foos(45));
            stringContainer.AddValue(new Foouk(69));
            //stringContainer.AddValue(new Doos(67)); <--- Not possible since Doos does not inherit Foo

            Console.WriteLine("The three foo classes are: ");

            for (int i = 0; i < stringContainer.GetLength(); i++)
            {
                Console.WriteLine(stringContainer.ObtainValue(i) + ".");
            }

            Console.WriteLine("The last value of the container is: ");
            Console.WriteLine(stringContainer.ObtainValue() + ".");

        }
    }
}
