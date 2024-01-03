namespace Inheritance
{
    internal abstract class Animal
    {
        public abstract string GetName();

        //Abstract methods are ones that are implemented on the class that inherits the abstract
        //class. 

        public virtual void Eat() => Console.WriteLine("Yes! Food!...");

        //Using the "virtual" keyword means that every subclass should modify this method.
        //Not the same as the "new" keyword, that one is used when we write a new method in the
        //subclass that just so happens to have the same signature as one in the upperclass.

        public void Think() => Console.WriteLine("Hmmm, I'm thinking...");
    }
}
