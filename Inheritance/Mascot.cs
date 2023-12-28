namespace Inheritance
{
    class Mascot 
    {
        private string? name;
        private string? color;
        private double humanYears;
        public string? Name { get => name; set => name = value; }
        public string? Color { get => color; set => color = value; }
        public double HumanYears { get => humanYears; set => humanYears = value; }

        public Mascot(string name = "Unkown", string color = "Unkown", double humanYears = 1)
        {
            this.name = name;
            this.color = color;
            this.humanYears = humanYears;
        }

        public void Think() => Console.WriteLine("Hmmm, I'm thinking about stuff...");
     
        public virtual void Eat() => Console.WriteLine("Finally some food...");
        //Using the "virtual" keyword means that every subclass should modify this method.
        //Not the same as the "new" keyword, that one is used when we write a new method in the
        //subclass that just so happens to have the same signature as one in the upperclass.
    }
}
