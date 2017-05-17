using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class PID
    {
        private const double error_epsilon = 0.1;
        private double P;
        private double I;
        private double D;

        private double prevErr;
        private double sumErr;
        private double dt;
        private double max;
        private double min;

        public PID(double dt_in, double max_in, double min_in, double P_in = 1.0, double I_in = 0.0, double D_in = 0.0)
        {
            P = P_in;
            I = I_in;
            D = D_in;
            sumErr = 0.0;
            prevErr = 0.0;
            dt = dt_in;
            max = max_in;
            min = min_in;
        }

        public void set_PID(double dt_in, double max_in, double min_in, double P_in, double I_in, double D_in)
        {
            dt = dt_in;
            max = max_in;
            min = min_in;
            P = P_in;
            I = I_in;
            D = D_in;
        }

        public double get_effect(double current, double target)
        {
            double err = target - current;
            if (Math.Abs(err) < error_epsilon)
                sumErr = 0;
            sumErr += err;
            double force = P * err + I * sumErr * dt + D * (err - prevErr) / dt;
            prevErr = err;
            if (force > max)
                force = max;
            if (force < min)
                force = min;
            return force;
        }
    }
}
