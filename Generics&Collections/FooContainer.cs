using System.Collections.Generic;


namespace Generics_Collections
{
    internal class FooContainer<T> where T : Foo
    {
        private T[] values;
        private int count = 0;

        public int GetLength() => values.Length;

        public FooContainer(int maxSize)
        {
            values = new T[maxSize];
        }

        public void AddValue(T value) 
        {
            values[count++] = value;
        }

        public void InsertValue(int index, T value)
        {
            if (index < 0 || index >= values.Length) throw new IndexOutOfRangeException();
            else values[index] = value;
        }

        public T ObtainValue(int index) => values[index];
        public T ObtainValue() => values[count-1];

    }

    class Foo 
    {
        private int magicNumber;

        public int MagicNumber { get => magicNumber; set => magicNumber = value; }

        public Foo(int magicNumber)
        {
            this.magicNumber = magicNumber;
        }

        public override string? ToString()
        {
            return $"The magic number is... {magicNumber}.";
        }
    }

    class Foos : Foo
    {
        public Foos(int magicNumber) : base(magicNumber)
        {
        }
    }

    class Foouk : Foo
    {
        public Foouk(int magicNumber) : base(magicNumber)
        {
        }
    }

    class Doos 
    {
        private int normalNumber;

        public int NormalNumber { get => normalNumber; set => normalNumber = value; }

        public Doos(int normalNumber)
        {
            this.normalNumber = normalNumber;
        }
    }
}
