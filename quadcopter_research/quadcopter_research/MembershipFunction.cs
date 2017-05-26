using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class MembershipFunction
    {
        public double a;

        public double b;

        public double a_d;

        public double b_d;

        public MembershipFunction(Random rand)
        {
            a = rand.NextDouble() - 0.5;
            b = rand.NextDouble() - 0.5;
        }

        public MembershipFunction(double a_in, double b_in)
        {
            a = a_in;
            b = b_in;
        }

        public double compute(double x)
        {
            return 1.0 / (1 + Math.Exp(b * (x - a)));
        }
    }
}
