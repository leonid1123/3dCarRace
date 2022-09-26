using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    float speed = 2f;
    float turnSpeed = 0.2f;
    Rigidbody rb;
    bool canFire=true;
    public GameObject bullet;
    public Transform firePoint;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical")>0)
        {
            rb.AddRelativeForce(Vector3.forward*speed);
        }
        float turn = Input.GetAxisRaw("Horizontal");
        if (turn!=0)
        {
            Quaternion rotation = Quaternion.Euler(new Vector3(0, turn*turnSpeed, 0));
            rb.MoveRotation(rb.rotation * rotation);
        }
        if (canFire & Input.GetButton("Jump"))
        {
            Instantiate(bullet, firePoint.position, transform.rotation);
            canFire = false;
            StartCoroutine(Fire());
        }
        IEnumerator Fire()
        {
            yield return new WaitForSeconds(1);
            canFire = true;

        }
    }
}
