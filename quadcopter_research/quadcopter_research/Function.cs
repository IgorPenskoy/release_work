using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class Function
    {
        public double compute(double x, double y)
        {
            return ((x - 1) * (x - 1) + (y + 2) * (y + 2) - 5 * x * y + 3) * Math.Cos(x / 5) * Math.Cos(x / 5);
        }
    }
}
