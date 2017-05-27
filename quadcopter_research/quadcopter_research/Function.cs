using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class Function
    {
        public double range = 45.0;

        public double compute(double x, double y)
        {

            return Math.Abs(x) / range * Math.Abs(y) / range;
        }
    }
}
