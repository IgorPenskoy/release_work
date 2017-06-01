using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_anfis
{
    class MembershipFunction
    {
        public double a;

        public double b;

        public double c;

        //gradient a
        public double α;

        //gradient b
        public double β;

        public double c_d;
        
        public MembershipFunction(double a_in, double b_in, double c_in)
        {
            a = a_in;
            b = b_in;
            c = c_in;
        }

        public double compute(double x)
        {
            if (x > a && x < b)
                return (x - a) / (b - a);
            else if (x == b)
                return 1;
            else if (x > b && x < c)
                return (c - x) / (c - b);
            else
                return 0;
        }

        public double deriv_a(double x)
        {
            if (x > a && x < b)
                return (x - b) / Math.Pow(b - a, 2);
            else
                return 0;
        }

        public double deriv_b(double x)
        {
            if (x > a && x < b)
                return (a - x) / Math.Pow(b - a, 2);
            else if (x > b && x < c)
                return (c - x) / Math.Pow(c - b, 2);
            else
                return 0;
        }

        public double deriv_c(double x)
        {
            if (x > b && x < c)
                return (x - b) / Math.Pow(c - b, 2);
            else
                return 0;
        }
    }
}
