namespace Generics_Collections
{
    internal class Container<T>
    {
        private T[] values;
        private int count = 0;

        public int GetLength() => values.Length;

        public Container(int size)
        {
            values = new T[size];
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
}
