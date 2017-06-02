using System;
using System.Linq;

namespace quadcopter_research
{
    class ZieglerNichols
    {
        private const double p_coef_const = 0.6;
        private const double i_coef_const = 1.2;
        private const double d_coef_const = 0.075;
        private const double reference_x = 90.0;
        private const double reference_y = 90.0;
        private const double reference_z = 90.0;

        private const int periods_amount = 10;

        PID pid;
        quadcopter_model qm;

        private double p_coef;
        private double i_coef;
        private double d_coef;
        private double dt;

        private double P_u;

        private double P;
        private double I;
        private double D;

        private double period;
        private double[] periods;

        public ZieglerNichols(double p_coef_in = p_coef_const, double i_coef_in = i_coef_const, double d_coef_in = d_coef_const)
        {
            pid = new PID();
            qm = new quadcopter_model();
            periods = new double[periods_amount];

            p_coef = p_coef_in;
            i_coef = i_coef_in;
            d_coef = d_coef_in;
            P_u = P = I = D = period = dt = 0.0;
        }

        public void init(PID pid_in, quadcopter_model qm_in, double dt_in)
        {
            pid = pid_in;
            qm = qm_in;
            dt = dt_in;
        }

        private void apply_coef()
        {
            P = pid.P * p_coef;
            I = pid.P / period * i_coef;
            D = pid.P * period * d_coef;
        }

        public vector3 get_phi_PID()
        {
            if (pid.P == 0.0)
                return new vector3();

            int current_periods_amount = 0;
            double current_period = 0.0;
            double phi_effect = 0.0;
            vector3 angles = qm.get_angles();
            double prev_error = reference_x - angles.x;

            while (current_periods_amount < periods_amount)
            {
                phi_effect = pid.get_effect(angles.x, reference_x);
                qm.update(phi_effect, 0.0, 0.0);
                angles = qm.get_angles();
                current_period += dt;
                if (Math.Sign(prev_error) * Math.Sign(reference_x - angles.x) < 0)
                {
                    periods[current_periods_amount] = current_period;
                    current_period = 0.0;
                    current_periods_amount += 1;
                }
                prev_error = reference_x - angles.x;
            }

            periods[0] = periods.Sum() / periods.Count();
            period = periods.Sum() / periods.Count();

            apply_coef();

            return new vector3(P, I, D);
        }

        public vector3 get_theta_PID()
        {
            int current_periods_amount = 0;
            double current_period = 0.0;
            double theta_effect = 0.0;
            vector3 angles = qm.get_angles();
            double prev_error = reference_y - angles.y;

            if (pid.P == 0.0)
                return new vector3();

            while (current_periods_amount < periods_amount)
            {
                theta_effect = pid.get_effect(angles.y, reference_y);
                qm.update(0.0, theta_effect, 0.0);
                angles = qm.get_angles();
                current_period += dt;
                if (Math.Sign(prev_error) * Math.Sign(reference_y - angles.y) < 0)
                {
                    periods[current_periods_amount] = current_period;
                    current_period = 0.0;
                    current_periods_amount += 1;
                }
                prev_error = reference_y - angles.y;
            }

            periods[0] = periods.Sum() / periods.Count();
            period = periods.Sum() / periods.Count();

            apply_coef();

            return new vector3(P, I, D);
        }

        public vector3 get_psi_PID()
        {
            int current_periods_amount = 0;
            double current_period = 0.0;
            double psi_effect = 0.0;
            vector3 angles = qm.get_angles();
            double prev_error = reference_z - angles.z;

            if (pid.P == 0.0)
                return new vector3();

            while (current_periods_amount < periods_amount)
            {
                psi_effect = pid.get_effect(angles.z, reference_z);
                qm.update(0.0, 0.0, psi_effect);
                angles = qm.get_angles();
                current_period += dt;
                if (Math.Sign(prev_error) * Math.Sign(reference_z - angles.z) < 0)
                {
                    periods[current_periods_amount] = current_period;
                    current_period = 0.0;
                    current_periods_amount += 1;
                }
                prev_error = reference_z - angles.z;
            }

            periods[0] = periods.Sum() / periods.Count();
            period = periods.Sum() / periods.Count();

            apply_coef();

            return new vector3(P, I, D);
        }
    }
}
