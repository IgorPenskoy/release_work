using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class quadcopterScript : MonoBehaviour {

    public double mass_frame;
    public double mass_engine;
    public double radius;
    public double arm_length;
    private const double k = 1;
    private const double b = 0.05;
    private const double g = 9.81;
    private const double dt = 0.001;
    private double Jxx;
    private double Jyy;
    private double Jzz;
    private double mass;

    public double x = 0;
    public double y = 0;
    public double z = 0;

    private double v_x;
    private double v_y;
    private double v_z;

    public double phi = 0;
    public double theta = 0;
    public double psi = 0;

    private double w_x;
    private double w_y;
    private double w_z;

    private double equilibrium_thrust;

    public double u1;
    public double u2;
    public double u3;
    public double u4;

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
        v_y += dt * ((Math.Sin(psi) * Math.Sin(theta) *  Math.Cos(phi) - Math.Cos(psi) * Math.Sin(phi)) * F_div_mass);
        v_z += dt * (Math.Cos(phi) * Math.Cos(theta) * F_div_mass - g);
    }

    private void update_angles()
    {
        phi += dt * w_x; //(w_x + w_y * (Math.Sin(phi) * Math.Tan(theta)) + w_z * (Math.Cos(phi) * Math.Tan(theta)))
        theta += dt * w_y; //(w_y * Math.Cos(phi) - w_z * Math.Sin(phi))
        psi += dt * w_z; //(Math.Sin(phi) / Math.Cos(theta) * w_y + Math.Cos(phi) / Math.Cos(theta) * w_z)
    }

    private void update_angular_speed()
    {
        w_x += dt * (arm_length * k * (u4 - u2) / Jxx);
        w_y += dt * (arm_length * k * (u3 - u1) / Jyy);
        w_z += dt * (b * (-u1 + u2 - u3 + u4) / Jzz);
    }

    // Use this for initialization
    void Start () {
        mass_frame = 0.5;
        arm_length = 0.25;
        mass_engine = 0.1;
        radius = 0.2;
        Jxx = Jyy = 2 * mass_frame * (Math.Pow(radius, 2)) / 5 + 2 * Math.Pow(arm_length, 2) * mass_engine;
        Jzz = 2 * mass_frame * (Math.Pow(radius, 2)) / 5 + 4 * Math.Pow(arm_length, 2) * mass_engine;
        mass = mass_frame + 4 * mass_engine;
        equilibrium_thrust = mass * g / 4;
        /*u1 = equilibrium_thrust;
        u2 = equilibrium_thrust;
        u3 = equilibrium_thrust;
        u4 = equilibrium_thrust;*/
        Time.fixedDeltaTime = (float)dt;
    }
    private void OnGUI()
    {
        GUI.contentColor = Color.black;
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;
        GUI.Label(new Rect(10, 10, 500, 20), "Position: " + String.Format("X: {0:000.000} Y: {1:000.000} Z: {2:000.000}", x, y, -z));
        GUI.Label(new Rect(10, 30, 500, 40), "Rotation: " + String.Format("Phi: {0:000.000} Theta: {1:000.000} Psi: {2:000.000}", phi, theta, psi));
        GUI.Label(new Rect(10, 50, 500, 60), "Speed: " + String.Format("Vx: {0:000.000} Vy: {1:000.000} Vz: {2:000.000}", v_x, v_y, v_z));
        GUI.Label(new Rect(10, 70, 500, 80), "Angular Speed: " + String.Format("Wx: {0:000.000} Wy: {1:000.000} Wz: {2:000.000}", w_x, w_y, w_z));
        GUI.Label(new Rect(10, 90, 500, 100), "Current Time: " + Time.fixedTime.ToString("0:000.000"));
    }
    // Update is called once per frame
    void FixedUpdate () {
        update_coordinates();
        update_speed();
        update_angles();
        update_angular_speed();
        Vector3 position = new Vector3((float)x, (float)-z, (float)y);
        transform.position = position;
        Quaternion rotation = Quaternion.Euler((float)phi, (float)psi, (float)theta);
        transform.rotation = rotation;
        if (phi >= 45.0)
        {
            w_x = 0;
            u1 = u2 = u3 = u4 = equilibrium_thrust;
        }
	}
}
