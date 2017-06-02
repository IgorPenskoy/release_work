using UnityEngine;
using System.Collections;
using System.IO;
using System.Threading;
using System.Net;

public class quadcopterScript : MonoBehaviour {

    private string str;
    private float phi;
    private float theta;
    private float psi;
    
	void Start () {
        Screen.SetResolution(350, 350, false);
        Time.fixedDeltaTime = 0.001f;
    }

    void FixedUpdate () {
        var inStream = new FileStream("copter_fis.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        var sr = new StreamReader(inStream);

        string phi_s = sr.ReadLine();
        string theta_s = sr.ReadLine();
        string psi_s = sr.ReadLine();
        sr.Close();

        phi = (float)double.Parse(phi_s.Replace(",", "."));
        theta = (float)double.Parse(theta_s.Replace(",", "."));
        psi = (float)double.Parse(psi_s.Replace(",", "."));

        Quaternion rotation = Quaternion.Euler(phi, theta, psi);
        transform.rotation = rotation;
    }

    private void OnGUI()
    {
        GUI.contentColor = Color.black;
        GUI.Label(new Rect(10, 10, 200, 20), "Нейро-нечеткая сеть");
        GUI.Label(new Rect(10, 40, 100, 50), phi.ToString("X: 0.00"));
        GUI.Label(new Rect(10, 60, 100, 70), theta.ToString("Y: 0.00"));
        GUI.Label(new Rect(10, 80, 100, 90), psi.ToString("Z: 0.00"));
    }
}
