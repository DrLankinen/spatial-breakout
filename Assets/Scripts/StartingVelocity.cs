using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingVelocity : MonoBehaviour
{
    public Rigidbody rb;
    public float maxSpeed = 40.0f;
    public float minSpeed = 10.0f;
    private float forceMultiplier = 1.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(Random.Range(-4.0f, 4.0f),
            Random.Range(1.0f, 4.0f),
            15.0f);
        rb.velocity = new Vector3(0.0f,
            Random.Range(-2.0f,2.0f), Random.Range(-15.0f,-10.0f));
    }

    void FixedUpdate()
    {
        if(GetComponent<Rigidbody>().velocity.magnitude > maxSpeed)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * maxSpeed;
        }
        if(GetComponent<Rigidbody>().velocity.magnitude < minSpeed)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * minSpeed;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.name == "LeftControllerScriptAlias" ||
            other.gameObject.name == "RightControllerScriptAlias")) {
                rb.velocity = rb.velocity*forceMultiplier;
        }
    }
}
