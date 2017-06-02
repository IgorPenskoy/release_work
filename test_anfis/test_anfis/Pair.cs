namespace test_anfis
{
    class Pair
    {
        public double x;

        public double y;

        public double value;

        public Pair() { }

        public Pair(double x, double y, double value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }

        public string toString()
        {
            return x.ToString("0.000") + " " + y.ToString("0.000") + " " + value.ToString("0.000");
        }
    }
}
