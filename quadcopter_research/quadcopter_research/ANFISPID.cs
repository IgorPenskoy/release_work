using System;

namespace quadcopter_research
{
    class ANFISPID
    {
        private ANFIS fis_P;
        private ANFIS fis_I;
        private ANFIS fis_D;
        private double d_err;
        private double i_max;
        private double max;
        private double dt;
        private double sumErr;
        private double prevErr;
        private double error_epsilon = 0.1;
        private double force;

        private double P;
        private double I;
        private double D;

        public ANFISPID(double dt_in = 0.001, double max_in = 0.0, double i_max_in = 0.0)
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
            sumErr = 0;
            prevErr = 0;
        }

        public void init_params(double dt_in, double max_in, double i_max_in)
        {
            dt = dt_in;
            max = max_in;
            i_max = i_max_in;
        }

        public void init_fis(ANFIS fis_P_in, ANFIS fis_I_in, ANFIS fis_D_in)
        {
            fis_P = fis_P_in;
            fis_I = fis_I_in;
            fis_D = fis_D_in;
        }

        public double get_effect_fis(double current, double target)
        {
            double err = target - current;
            if (Math.Abs(err) < error_epsilon)
                sumErr = 0.0;
            sumErr += err;
            if (Math.Abs(sumErr) > i_max)
                sumErr = i_max * Math.Sign(sumErr);

            d_err = (err - prevErr);

            P = fis_P.compute(err, d_err) * 50;
            I = fis_I.compute(err, d_err) * 1;
            D = fis_D.compute(err, d_err) * 30;

            force = P * err + I * sumErr * dt + D * d_err / dt;
            prevErr = err;
            if (Math.Abs(force) > max)
                force = max * Math.Sign(force);
            return force;
        }
    }
}
