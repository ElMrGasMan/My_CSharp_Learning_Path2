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

            Console.WriteLine("---Mono Value Collections---");
            List<int> ints = [];
            //LISTS are mostly used when elements are accessed many times, but otherwise is slow when
            //deleting or adding elements since they are all adyacent to each other.

            ints.AddRange(new int[] { 780, 180, 99 });

            int[] arrInts1 = [5, 78, 100, 20000, 1];
            LinkedList<int> ints2 = new(arrInts1);
            //LINKED LISTS are preferred over LISTS when adding and/or deleting elements a lot since
            //elements are not necessarily adyacent to each other thanks to their links.

            IEnumerable<int> enumerable = ints2.Reverse();

            foreach (int item in enumerable)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---Dictionaries (Key, Value pairs)---");

            Dictionary<string, int> prices = [];

            prices.Add("Mayonnaise", 20); //Either of these two ways to add elements is ok.
            prices["Chesse"] = 550;

            foreach (KeyValuePair<string, int> item in prices) //Instead of KeyValuePair, "var" can also be used
            {
                Console.WriteLine($"Product: {item.Key}. Price: ${item.Value}.");
            }

        }
    }
}
