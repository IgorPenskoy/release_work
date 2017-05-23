using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class TNorm
    {
        public double computeNorm(double mu_A, double mu_B)
        {

            if (mu_A > 0 || mu_B > 0)
                return (mu_A * mu_B) / (mu_A + mu_B - mu_A * mu_B);

            return 0;
        }
    }
}
