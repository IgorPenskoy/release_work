using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class Conclusion
    {
        public double p;

        public double q;

        public double r;

        public double p_d;

        public double q_d;

        public double r_d;

        public Conclusion(Random rand)
        {
            p = rand.NextDouble() - 0.5;
            q = rand.NextDouble() - 0.5;
            r = rand.NextDouble() - 0.5;
        }

        public double compute(double x, double y)
        {
            return x * p + y * q + r;
        }
    }
}
