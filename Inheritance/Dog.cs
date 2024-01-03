namespace Inheritance
{
    class Dog : Mascot
    {
        private string? breed;
        public string? Breed { get => breed; set => breed = value; }

        public Dog(string name = "Unkown", string color = "Unkown", double humanYears = 1, string? breed = "Unkown")
            : base(name, color, humanYears)
        {
            this.breed = breed;
        }

        public void Bark() => Console.WriteLine($"BARK BARK I'M A DOGGY {Name} DOG BARK BARK.");

        new public void Think() => Console.WriteLine("Hmm, I'm thinking about going to the park...");

        //Virtual methods must include the "override" in the subclass.
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("This dog food is really good!");
        }
    }
}
