using System;

namespace test_anfis
{
    class Function
    {
        public virtual double compute(double x, double y, double range)
        {
            return 0;
        }
    }

    class Function_P : Function
    {
        public override double compute(double x, double y, double range)
        {
            return (Math.Abs(x) + Math.Abs(y)) / (range * 2);
        }
    }

    class Function_I : Function
    {
        public override double compute(double x, double y, double range)
        {
            return Math.Abs(x * y) / Math.Pow(range, 2);
        }
    }

    class Function_D : Function
    {
        public override double compute(double x, double y, double range)
        {
            return Math.Abs(y - x) / (range * 2);
        }
    }
}
