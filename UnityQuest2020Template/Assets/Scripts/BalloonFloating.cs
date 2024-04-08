using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonFloating : MonoBehaviour
{
    public float floatStrength = 3.5f;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * floatStrength);
    }
}
