using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadcopter_research
{
    public class vector3
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

    public class quadcopter_model
    {
        private const double k = 0.01;
        private const double b = 0.001;
        private const double g = 9.81;
        private const double dt_const = 0.05;
        private const double mass_frame_const = 0.5;
        private const double mass_engine_const = 0.1;
        private const double radius_const = 0.2;
        private const double arm_length_const = 0.25;
        private const double s_x = 0.01;
        private const double s_y = 0.01;
        private const double s_z = 0.03;
        private const double c_d = 0.4;
        private const double air_p = 1.2;

        private const double air_x = c_d * air_p * s_x / 2.0;
        private const double air_y = c_d * air_p * s_y / 2.0;
        private const double air_z = c_d * air_p * s_z / 2.0;

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

        private double random_effect;
        private double thrust;

        Random rand;

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
                                double dt_in = dt_const,
                                double random_effect_in = 0.0)
        {
            rand = new Random();
            init(mass_frame_in, mass_engine_in, radius_in, arm_length_in, dt_in, random_effect_in);
        }

        public void init(double mass_frame_in = mass_frame_const,
                                double mass_engine_in = mass_engine_const,
                                double radius_in = radius_const,
                                double arm_length_in = arm_length_const,
                                double dt_in = dt_const,
                                double random_effect_in = 0.0)
        {
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
            thrust = equilibrium_thrust;
            u1 = u2 = u3 = u4 = equilibrium_thrust;
            random_effect = angle_to_radian(random_effect_in);
        }

        public void set_random_effect(double random_effect)
        {
            this.random_effect = random_effect;
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

        public void set_speed(double v_x, double v_y, double v_z)
        {
            this.v_x = v_x;
            this.v_y = v_y;
            this.v_z = v_z;
        }

        public vector3 get_coordinates()
        {
            return new vector3(x, y, z);
        }

        public void update_coordinates()
        {
            x += v_x * dt;
            y += v_y * dt;
            z += v_z * dt;
        }

        public vector3 get_speed()
        {
            return new vector3(v_x, v_y, v_z);
        }

        public void set_forces(double u1, double u2, double u3, double u4)
        {
            this.u1 = u1;
            this.u2 = u2;
            this.u3 = u3;
            this.u4 = u4;
        }

        public void update_speed()
        {
            double F_div_mass = k * (u1 + u2 + u3 + u4) / mass;
            v_x += dt * (Math.Cos(psi) * Math.Sin(theta) * Math.Cos(phi) + Math.Sin(psi) * Math.Sin(phi)) * F_div_mass - Math.Sign(v_x) * v_x * v_x * air_x;
            v_y += dt * ((Math.Sin(psi) * Math.Sin(theta) * Math.Cos(phi) - Math.Cos(psi) * Math.Sin(phi)) * F_div_mass - Math.Sign(v_y) * v_y * v_y * air_y);
            v_z += dt * (Math.Cos(phi) * Math.Cos(theta) * F_div_mass - g - Math.Sign(v_z) * v_z * v_z * air_z);
        }

        public vector3 get_angles()
        {
            return new vector3(radian_to_angle(phi), radian_to_angle(theta), radian_to_angle(psi));
        }

        public void update_angles()
        {
            if (rand.NextDouble() > 0.9)
            {
                phi += dt * w_x + rand.NextDouble() * 2 * random_effect - random_effect;
                theta += dt * w_y + rand.NextDouble() * 2 * random_effect - random_effect;
                psi += dt * w_z + rand.NextDouble() * 2 * random_effect - random_effect;
            }
            else
            {
                phi += dt * w_x;
                theta += dt * w_y;
                psi += dt * w_z;
            }
        }

        public vector3 get_angular_speed()
        {
            return new vector3(w_x, w_y, w_z);
        }

        public void update_angular_speed()
        {
            w_x += dt * (arm_length * k * (u4 - u2) / Jxx);
            w_y += dt * (arm_length * k * (u3 - u1) / Jyy);
            w_z += dt * (b * (- u1 + u2 - u3 + u4) / Jzz);
        }

        public double[] get_forces()
        {
            double[] forces = new double[4];
            forces[0] = u1;
            forces[1] = u2;
            forces[2] = u3;
            forces[3] = u4;

            return forces;
        }

        public double get_equilibrium_thrust()
        {
            return equilibrium_thrust;
        }

        public void update_forces(double phi_effect, double theta_effect, double psi_effect)
        {
            u1 = u2 = u3 = u4 = thrust;
            u1 += -theta_effect - psi_effect;
            u2 += -phi_effect + psi_effect;
            u3 += theta_effect - psi_effect;
            u4 += phi_effect + psi_effect;
        }

        public void update(double phi_effect, double theta_effect, double psi_effect)
        {
            update_forces(phi_effect, theta_effect, psi_effect);
            update_speed();
            update_coordinates();
            update_angular_speed();
            update_angles();
        }
    }
}
