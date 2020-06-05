using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingVelocity : MonoBehaviour
{
    public Rigidbody rb;
    public int e = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(Random.Range(-4.0f, 4.0f),
            Random.Range(1.0f, 4.0f),
            0);
        rb.velocity = new Vector3(0.0f,
            Random.Range(-2.0f,2.0f), Random.Range(-30.0f,-10.0f));
    }
}
