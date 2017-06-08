using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    public class Conclusion
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

        public Conclusion(double p, double q, double r)
        {
            this.p = p;
            this.q = q;
            this.r = r;
        }

        public double compute(double x, double y)
        {
            return x * p + y * q + r;
        }
    }
}
