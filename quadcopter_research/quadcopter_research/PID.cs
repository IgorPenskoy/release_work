using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class PID
    {
        protected const double error_epsilon = 0.1;

        public double P { get; protected set; }
        protected double I;
        protected double D;

        protected double force;
        protected double err;
        protected double prevErr;
        protected double sumErr;
        protected double dt;
        protected double max;
        protected double i_max;

        public PID(double dt_in = 0.001, double max_in = 0.0, double i_max_in = 0.0, double P_in = 1.0, double I_in = 0.0, double D_in = 0.0)
        {
            init(dt_in, max_in, i_max_in, P_in, I_in, D_in);
        }

        public void init(double dt_in, double max_in, double i_max_in, double P_in, double I_in, double D_in)
        {
            sumErr = 0.0;
            prevErr = 0.0;
            P = P_in;
            I = I_in;
            D = D_in;
            dt = dt_in;
            max = max_in;
            i_max = i_max_in;
        }

        public virtual double get_effect(double current, double target)
        {
            err = target - current;
            if (Math.Abs(err) < error_epsilon)
                sumErr = 0.0;
            sumErr += err;
            if (Math.Abs(sumErr) > i_max)
                sumErr = i_max * Math.Sign(sumErr);
            force = P * err + I * sumErr * dt + D * (err - prevErr) / dt;
            prevErr = err;
            if (Math.Abs(force) > max)
                force = max * Math.Sign(force);
            return force;
        }
    }
}
