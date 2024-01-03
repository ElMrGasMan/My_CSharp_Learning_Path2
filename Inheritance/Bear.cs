namespace Inheritance
{
    internal class Bear : Animal
    {
        private string? name;
        public string? Name { get => name; set => name = value; }

        public sealed override string GetName()
        {
            return $"I'm a big dangerous bear and my name is: {name}.";
        }

        public new void Think() => Console.WriteLine("Hmmm, I'm thinking about scraching my back...");
    }
}
