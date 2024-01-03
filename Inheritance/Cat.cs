namespace Inheritance
{
    sealed class Cat : Mascot 
    {
        public Cat(string name = "Unkown", string color = "Unkown", double humanYears = 1) 
            : base(name, color, humanYears)
        {
        }

        public void Meow() => Console.WriteLine($"I'm {Name}, a cat!... I mean.. *meow mew meow*");

        new public void Think() => Console.WriteLine("Hmm, I'm thinking about jumping over the ceilings...");

        //Virtual methods must include the "override" in the subclass.
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("This is some good cat food...");
        }
    }
}
