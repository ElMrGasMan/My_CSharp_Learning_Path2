namespace Inheritance
{
    class Mascot : Animal
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

        public override string GetName()
        {
            return $"I'm a mascot and my name is: {name}.";
        }
    }
}
