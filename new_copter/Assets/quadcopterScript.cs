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
        Screen.SetResolution(300, 300, false);
        Time.fixedDeltaTime = 0.001f;
    }

    void FixedUpdate () {
        var inStream = new FileStream("test.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
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
        GUI.Label(new Rect(10, 10, 100, 20), phi.ToString("0.00"));
        GUI.Label(new Rect(10, 30, 100, 40), theta.ToString("0.00"));
        GUI.Label(new Rect(10, 50, 100, 60), psi.ToString("0.00"));
    }
}
