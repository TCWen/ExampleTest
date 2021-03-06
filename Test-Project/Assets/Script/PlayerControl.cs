using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rb;
    public float forewardmov = 500;
    public float sidemov = 250;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(-forewardmov * Time.deltaTime, 0, 0);

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -sidemov);
        }
       
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, sidemov);
        }
    }
}
