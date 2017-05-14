using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class PID
    {

        private double P;
        private double I;
        private double D;

        private double prevErr;
        private double sumErr;
        private double dt;

        public PID(double dt_in, double P_in = 1.0, double I_in = 0.0, double D_in = 0.0)
        {
            P = P_in;
            I = I_in;
            D = D_in;
            sumErr = 0.0;
            prevErr = 0.0;
            dt = dt_in;
        }

        public double get_effect(double current, double target)
        {
            double err = target - current;
            sumErr += err;
            prevErr = err;
            double force = P * err + I * sumErr * dt - D * Math.Abs(err - prevErr) / dt;
            return force;
        }
    }
}
