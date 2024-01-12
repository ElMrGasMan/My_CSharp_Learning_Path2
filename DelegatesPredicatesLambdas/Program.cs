using System.Collections.Generic;

namespace DelegatesPredicatesLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Delegates===");
            MessagesDelegate messages = new(GoodMessages.WelcomingText);
            messages("John");

            messages = GoodMessages.SayGoodByeText;
            messages("John");

            //Generic delegates "Func" and "Action" come included in the System namespace for free use.
            //Func takes up to 16 values for parameters and has to return something.
            //Action also takes up to 16 values for parameters but returns "void".

            Action<string> messages2 = HurtfulMessages.NonWelcomingText;
            //The explicit call to the constructor by using "new" is not necessary for delegates.

            messages2.Invoke("Willy"); //The function "Invoke" can also be used to call the method.

            Console.WriteLine("===Predicates===");

            List<int> ints = [2, 9, 18, 994, 1330];
            Predicate<int> predicatePrime = IsPrime;
            List<int> primeInts = ints.FindAll(predicatePrime);

            if (primeInts.Count > 0) Console.WriteLine("There are prime numbers in the list!");
            else Console.WriteLine("The list has no prime numbers to speak of.");

            Console.WriteLine("===Lambdas===");
            //Body: parameters => statement block
            //----- (param1, param2, ..., paramN) => statement block

            IEnumerable<int> evenInts = ints.Where(num => num % 2 == 0);

            foreach (int item in evenInts)
            {
                Console.WriteLine(item);
            }

            //Another way to iterate through a List is using it's own "foreach" method.
            //primeInts.ForEach(num => Console.WriteLine(num + "."));

            //Using delegates and lambdas together:

            messages = new(s => Console.WriteLine("This is your last chance " + s + "."));
            messages("John");

        }

        private static bool IsPrime(int num) 
        {
            if (num == 1) return true;
            else if (num == 2) return true;
            else if (num % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(num); i+= 2)
            {
                if (num % i == 0) return false;
            }

            return true;

        }
    }

    public delegate void MessagesDelegate(string name);
}
