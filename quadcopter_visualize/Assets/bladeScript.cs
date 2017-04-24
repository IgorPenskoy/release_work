using UnityEngine;

public class bladeScript : MonoBehaviour
{

    [Range(100, 3000)]
    public float bladeSpeed = 1500;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.up * bladeSpeed * Time.deltaTime);
    }
}
