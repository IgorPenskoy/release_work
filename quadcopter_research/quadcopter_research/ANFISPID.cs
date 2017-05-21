using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class ANFISPID : PID
    {
        private ANFIS fis_P;
        private ANFIS fis_I;
        private ANFIS fis_D;
        private double d_err;

        public ANFISPID(double dt_in = 0.001, double max_in = 0.0, double i_max_in = 0.0) : base(dt_in, max_in, i_max_in)
        {
            init(new ANFIS(new Random()), new ANFIS(new Random()), new ANFIS(new Random()), dt_in, max_in, i_max_in);
        }

        public void init(ANFIS fis_P_in, ANFIS fis_I_in, ANFIS fis_D_in, double dt_in, double max_in, double i_max_in)
        {
            fis_P = fis_P_in;
            fis_I = fis_I_in;
            fis_D = fis_D_in;
            dt = dt_in;
            max = max_in;
            i_max = i_max_in;
            d_err = 0.0;
        }

        public override double get_effect(double current, double target)
        {
            err = target - current;
            if (Math.Abs(err) < error_epsilon)
                sumErr = 0.0;
            sumErr += err;
            if (Math.Abs(sumErr) > i_max)
                sumErr = i_max * Math.Sign(sumErr);

            d_err = (err - prevErr) / dt;

            P = fis_P.compute(err, d_err);
            I = fis_I.compute(err, d_err);
            D = fis_D.compute(err, d_err);

            force = P * err + I * sumErr * dt + D * d_err;
            prevErr = err;
            if (Math.Abs(force) > max)
                force = max * Math.Sign(force);
            return force;
        }
    }
}
