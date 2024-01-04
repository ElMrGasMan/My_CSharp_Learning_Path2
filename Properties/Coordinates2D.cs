namespace Properties
{
    internal class Coordinates2D
    {
        private int x;
        private int y;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Coordinates2D()
        {
            x = 0;
            y = 0;
        }

        public Coordinates2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    struct Coordinate2D
    {
        private int x;
        private int y;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Coordinate2D()
        {
            x = 0;
            y = 0;
        }

        public Coordinate2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
