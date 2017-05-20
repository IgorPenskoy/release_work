using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
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
