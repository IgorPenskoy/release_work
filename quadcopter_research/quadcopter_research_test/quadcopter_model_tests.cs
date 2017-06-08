using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using quadcopter_research;

namespace quadcopter_research_test
{
    [TestClass]
    public class quadcopter_model_tests
    {
        [TestMethod]
        public void TestRadianToAngle_1()
        {
            quadcopter_model qm = new quadcopter_model();
            double radian_in = Math.PI;
            double angle_out = 180;
            Assert.AreEqual(qm.radian_to_angle(radian_in), angle_out);
        }

        [TestMethod]
        public void TestRadianToAngle_2()
        {
            quadcopter_model qm = new quadcopter_model();
            double radian_in = 0;
            double angle_out = 0;
            Assert.AreEqual(qm.radian_to_angle(radian_in), angle_out);
        }

        [TestMethod]
        public void TestRadianToAngle_3()
        {
            quadcopter_model qm = new quadcopter_model();
            double radian_in = 1;
            double angle_out = 57.3;
            Assert.AreEqual(Math.Round(qm.radian_to_angle(radian_in), 1), angle_out);
        }

        [TestMethod]
        public void TestAngleToRadian_1()
        {
            quadcopter_model qm = new quadcopter_model();
            double angle_in = 180;
            double radian_out = Math.PI;
            Assert.AreEqual(qm.angle_to_radian(angle_in), radian_out);
        }

        [TestMethod]
        public void TestAngleToRadian_2()
        {
            quadcopter_model qm = new quadcopter_model();
            double angle_in = 0;
            double radian_out = 0;
            Assert.AreEqual(qm.angle_to_radian(angle_in), radian_out);
        }

        [TestMethod]
        public void TestAngleToRadian_3()
        {
            quadcopter_model qm = new quadcopter_model();
            double angle_in = 57.3;
            double radian_out = 1;
            Assert.AreEqual(Math.Round(qm.angle_to_radian(angle_in)), radian_out);
        }

        [TestMethod]
        public void TestSetAngles()
        {
            quadcopter_model qm = new quadcopter_model();
            double phi_in = 45;
            double theta_in = 45;
            double psi_in = 45;
            qm.set_angles(phi_in, theta_in, psi_in);
            vector3 angles = qm.get_angles();
            Assert.AreEqual(angles.x, phi_in);
            Assert.AreEqual(angles.y, theta_in);
            Assert.AreEqual(angles.z, psi_in);
        }

        [TestMethod]
        public void TestUpdateCoordinates()
        {
            quadcopter_model qm = new quadcopter_model();
            double v_x = 5;
            double v_y = 10;
            double v_z = 15;
            double x_out = 0.25;
            double y_out = 0.5;
            double z_out = 0.75;
            qm.set_speed(v_x, v_y, v_z);
            qm.update_coordinates();
            vector3 coordinates = qm.get_coordinates();
            Assert.AreEqual(coordinates.x, x_out);
            Assert.AreEqual(coordinates.y, y_out);
            Assert.AreEqual(coordinates.z, z_out);
        }

        [TestMethod]
        public void TestUpdateSpeed()
        {
            quadcopter_model qm = new quadcopter_model();
            double v_x_out = 0;
            double v_y_out = 0;
            double v_z_out = 0;
            qm.update_speed();
            vector3 speed = qm.get_speed();
            Assert.AreEqual(speed.x, v_x_out);
            Assert.AreEqual(speed.y, v_y_out);
            Assert.AreEqual(speed.z, v_z_out);
        }

        [TestMethod]
        public void TestUpdateAngularSpeed()
        {
            quadcopter_model qm = new quadcopter_model();
            double w_x_out = 0;
            double w_y_out = 0;
            double w_z_out = 0;
            qm.update_angular_speed();
            vector3 angular_speed = qm.get_angular_speed();
            Assert.AreEqual(angular_speed.x, w_x_out);
            Assert.AreEqual(angular_speed.y, w_y_out);
            Assert.AreEqual(angular_speed.z, w_z_out);
        }

        [TestMethod]
        public void TestUpdateAngles()
        {
            quadcopter_model qm = new quadcopter_model();
            double phi_out = 0;
            double theta_out = 0;
            double psi_out = 0;
            qm.set_random_effect(0);
            qm.update_angles();
            vector3 angles = qm.get_angles();
            Assert.AreEqual(angles.x, phi_out);
            Assert.AreEqual(angles.y, theta_out);
            Assert.AreEqual(angles.z, psi_out);
        }

        [TestMethod]
        public void TestUpdateForces()
        {
            quadcopter_model qm = new quadcopter_model();
            double phi_effect = 0;
            double theta_effect = 0;
            double psi_effect = 0;
            double u1_out = qm.get_equilibrium_thrust();
            double u2_out = qm.get_equilibrium_thrust();
            double u3_out = qm.get_equilibrium_thrust();
            double u4_out = qm.get_equilibrium_thrust();
            qm.update_forces(phi_effect, theta_effect, psi_effect);
            double[] forces = qm.get_forces();
            Assert.AreEqual(forces[0], u1_out);
            Assert.AreEqual(forces[1], u2_out);
            Assert.AreEqual(forces[2], u3_out);
            Assert.AreEqual(forces[3], u4_out);
        }
    }
}
