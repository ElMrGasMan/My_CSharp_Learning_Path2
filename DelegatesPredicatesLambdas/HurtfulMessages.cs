namespace DelegatesPredicatesLambdas
{
    internal class HurtfulMessages
    {
        public static void NonWelcomingText(string name) => Console.WriteLine($"Oh god {name} why are you here?.");

        public static void GoodByeText(string name) => Console.WriteLine($"Bye {name}, hope to never see you again.");
    }
}
