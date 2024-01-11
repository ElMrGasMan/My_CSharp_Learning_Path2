using System.Collections.Generic;

namespace Generics_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FooContainer<Foo> stringContainer = new(3);

            //stringContainer.AddValue(new Foo(25));
            //stringContainer.AddValue(new Foos(45));
            //stringContainer.AddValue(new Foouk(69));
            ////stringContainer.AddValue(new Doos(67)); <--- Not possible since Doos does not inherit Foo

            //Console.WriteLine("The three foo classes are: ");

            //for (int i = 0; i < stringContainer.GetLength(); i++)
            //{
            //    Console.WriteLine(stringContainer.ObtainValue(i) + ".");
            //}

            //Console.WriteLine("The last value of the container is: ");
            //Console.WriteLine(stringContainer.ObtainValue() + ".");

            Console.WriteLine("===Collections===");

            List<int> ints = [];
            //LISTS are mostly used when elements are accessed many times, but otherwise is slow when
            //deleting or adding elements since they are all adyacent to each other.

            ints.Add(780);
            ints.Add(180);
            ints.Add(99);

            int[] arrInts1 = [5, 78, 100, 20000, 1];
            LinkedList<int> ints2 = new(arrInts1);
            //LINKED LISTS are preferred over LISTS when adding and/or deleting elements a lot since
            //elements are not necessarily adyacent to each other thanks to their links.

            IEnumerable<int> enumerable = ints2.Reverse();

            foreach (int item in ints2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
