using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    class vector3
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public vector3(double x_in = 0.0, double y_in = 0.0, double z_in = 0.0)
        {
            x = x_in;
            y = y_in;
            z = z_in;
        }
    }

    class quadcopter_model
    {
        private const double k = 1;
        private const double b = 0.05;
        private const double g = 9.81;
        private const double dt_const = 0.001;
        private const double mass_frame_const = 0.5;
        private const double mass_engine_const = 0.1;
        private const double radius_const = 0.2;
        private const double arm_length_const = 0.25;

        private double dt;
        private double mass_frame;
        private double mass_engine;
        private double radius;
        private double arm_length;
        private double x;
        private double y;
        private double z;
        private double phi;
        private double theta;
        private double psi;
        private double u1;
        private double u2;
        private double u3;
        private double u4;

        private double Jxx;
        private double Jyy;
        private double Jzz;
        private double mass;
        private double v_x;
        private double v_y;
        private double v_z;
        private double w_x;
        private double w_y;
        private double w_z;
        private double equilibrium_thrust;

        private PID phi_PID;
        private PID theta_PID;
        private PID psi_PID;

        public double radian_to_angle(double radian)
        {
            return radian * 180.0 / Math.PI;
        }

        public double angle_to_radian(double angle)
        {
            return angle * Math.PI / 180.0;
        }

        public quadcopter_model(double mass_frame_in = mass_frame_const,
                                double mass_engine_in = mass_engine_const,
                                double radius_in = radius_const,
                                double arm_length_in = arm_length_const,
                                double dt_in = dt_const)
        {
            init(mass_frame_in, mass_engine_in, radius_in, arm_length_in, dt_in);
        }

        public void init(double mass_frame_in = mass_frame_const,
                                double mass_engine_in = mass_engine_const,
                                double radius_in = radius_const,
                                double arm_length_in = arm_length_const,
                                double dt_in = dt_const)
        {
            phi_PID   = new PID(dt_in, 10, -10, 100, 0, 20);
            theta_PID = new PID(dt_in, 10, -10, 100, 0, 20);
            psi_PID   = new PID(dt_in, 10, -10, 120, 10, 30);
            if (mass_frame_in <= 0)
                mass_frame = mass_frame_const;
            else
                mass_frame = mass_frame_in;
            if (arm_length_in <= 0)
                arm_length = arm_length_const;
            else
                arm_length = arm_length_in;
            if (mass_engine_in <= 0)
                mass_engine = mass_engine_const;
            else
                mass_engine = mass_engine_in;
            if (radius_in <= 0)
                radius = radius_const;
            else
                radius = radius_in;
            if (dt_in < dt_const)
                dt = dt_const;
            else
                dt = dt_in;
            x = y = z = 0.0;
            phi = theta = psi = 0.0;
            w_x = w_y = w_z = 0.0;
            v_x = v_y = v_z = 0.0;
            Jxx = Jyy = 2 * mass_frame * (Math.Pow(radius, 2)) / 5 + 2 * Math.Pow(arm_length, 2) * mass_engine;
            Jzz = 2 * mass_frame * (Math.Pow(radius, 2)) / 5 + 4 * Math.Pow(arm_length, 2) * mass_engine;
            mass = mass_frame + 4 * mass_engine;
            equilibrium_thrust = mass * g / (4 * k);
            u1 = u2 = u3 = u4 = equilibrium_thrust;
        }

        public void set_angles(double phi_in, double theta_in, double psi_in)
        {
            phi = angle_to_radian(phi_in);
            theta = angle_to_radian(theta_in);
            psi = angle_to_radian(psi_in);
        }

        public void reset()
        {
            x = y = z = 0.0;
            phi = theta = psi = 0.0;
            w_x = w_y = w_z = 0.0;
            v_x = v_y = v_z = 0.0;
            u1 = u2 = u3 = u4 = equilibrium_thrust;
        }

        private void update_coordinates()
        {
            x += v_x * dt;
            y += v_y * dt;
            z += v_z * dt;
        }

        private void update_speed()
        {
            double F_div_mass = k * (u1 + u2 + u3 + u4) / mass;
            v_x += dt * (Math.Cos(psi) * Math.Sin(theta) * Math.Cos(phi) + Math.Sin(psi) * Math.Sin(phi)) * F_div_mass;
            v_y += dt * ((Math.Sin(psi) * Math.Sin(theta) * Math.Cos(phi) - Math.Cos(psi) * Math.Sin(phi)) * F_div_mass);
            v_z += dt * (Math.Cos(phi) * Math.Cos(theta) * F_div_mass - g);
        }

        private void update_angles(vector3 reference)
        {
            u1 = u2 = u3 = u4 = equilibrium_thrust;
            double phi_effect = phi_PID.get_effect(phi, angle_to_radian(reference.x));
            double theta_effect = theta_PID.get_effect(theta, angle_to_radian(reference.y));
            double psi_effect = psi_PID.get_effect(psi, angle_to_radian(reference.z));
            u1 += -theta_effect / 2 - psi_effect / 2;
            u2 += -phi_effect / 2 + psi_effect / 2;
            u3 += theta_effect / 2 - psi_effect / 2;
            u4 += phi_effect / 2 + psi_effect / 2;
            phi = phi + dt * w_x;
            theta = theta + dt * w_y;
            psi = psi + dt * w_z;
            /*phi += dt * (w_x + Math.Sin(phi) * Math.Tan(theta) * w_y + Math.Cos(phi) * Math.Tan(theta) * w_z);
            theta += dt * (Math.Cos(phi) * w_y - Math.Sin(phi) * w_z);
            psi += dt * (Math.Sin(phi) / Math.Cos(theta) * w_y + Math.Cos(phi) / Math.Cos(theta) * w_z);*/
        }

        private void update_angular_speed()
        {
            w_x += dt * (arm_length * k * (u4 - u2) / Jxx);
            w_y += dt * (arm_length * k * (u3 - u1) / Jyy);
            w_z += dt * (b * (-u1 + u2 - u3 + u4) / Jzz);
            /*w_x += dt * ((arm_length * k * (u4 - u2) + (Jyy - Jzz) * w_y * w_z) / Jxx);
            w_y += dt * ((arm_length * k * (u3 - u1) + (Jzz - Jxx) * w_z * w_x) / Jyy);
            w_z += dt * ((b * (-u1 + u2 - u3 + u4) + (Jxx - Jyy) * w_x * w_y) / Jzz);*/
        }

        public vector3 get_angles()
        {
            return new vector3(radian_to_angle(phi), radian_to_angle(theta), radian_to_angle(psi));
        }

        public void update(vector3 reference)
        {
            update_speed();
            update_coordinates();
            update_angular_speed();
            update_angles(reference);
        }
    }
}
