using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class ZieglerNichols
    {
        private const double p_coef_const = 1.0;
        private const double i_coef_const = 1.2;
        private const double d_coef_const = 0.075;

        PID pid;

        private double p_coef;
        private double i_coef;
        private double d_coef;

        private double P;
        private double I;
        private double D;

        private double period;

        public ZieglerNichols(double p_coef_in = p_coef_const, double i_coef_in = i_coef_const, double d_coef_in = d_coef_const)
        {
            p_coef = p_coef_in;
            i_coef = i_coef_in;
            d_coef = d_coef_in;
            pid = new PID();
        }

        public vector3 get_PID(double P_in, double max_in, double i_max_in, quadcopter_model qm, double dt)
        {
            pid.init(dt, max_in, i_max_in, P_in, 0.0, 0.0);

            period = 10; // TODO period eval

            P = P_in * p_coef;
            I = P_in / period * i_coef;
            D = P_in * period * d_coef;

            return new vector3(P, I, D);
        }

    }
}
