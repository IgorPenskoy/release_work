using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class TNorm
    {
        public double computeNorm(double μA, double μB)
        {

            if (μA > 0 || μB > 0)
                return (μA * μB) / (μA + μB - μA * μB);

            return 0;
        }
    }
}
