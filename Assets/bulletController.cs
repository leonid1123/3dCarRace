using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward*200,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
