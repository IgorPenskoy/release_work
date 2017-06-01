using UnityEngine;
using System.Collections;
using System.IO;
using System.Net;

public class quadcopterScript : MonoBehaviour {

    // Use this for initialization

    private string str;
    
	void Start () {
        str = string.Empty;
    }

    public static string Read(string filename)
    {
        //Load the text file using Reources.Load
        TextAsset theTextFile = Resources.Load<TextAsset>(filename);

        //There's a text file named filename, lets get it's contents and return it
        if (theTextFile != null)
            return theTextFile.text;

        //There's no file, return an empty string.
        return string.Empty;
    }

    // Update is called once per frame
    void FixedUpdate () {
        /*var uri = new System.Uri("file:///C:/Users/igor/Desktop/release_work/new_copter/test.txt");
        var converted = uri.AbsoluteUri;
        str = (new WebClient()).DownloadString(converted);*/
        WebRequest request = WebRequest.Create(@"C:/Users/igor/Desktop/release_work/new_copter/test.txt");
        WebResponse response = (WebResponse)request.GetResponse();
        StreamReader s = new StreamReader(response.GetResponseStream());

        str = s.ReadLine();

        Quaternion rotation = Quaternion.Euler(45, 0, 0);
        transform.rotation = rotation;
    }

    private void OnGUI()
    {
        GUI.contentColor = Color.black;
        GUI.Label(new Rect(10, 10, 500, 20), "File: " + str);
    }
}
