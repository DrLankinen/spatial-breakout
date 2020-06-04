using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingVelocity : MonoBehaviour
{
    public Rigidbody rb;
    public int e = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f, -2.0f, -40.0f);
        // rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // rb.velocity = new Vector3(0.0f, 0.0f, -2.0f);
    }
}
