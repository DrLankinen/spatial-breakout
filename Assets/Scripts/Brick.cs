using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.collider.gameObject.tag == "Ball")
        {
            Debug.Log("destory");
            Destroy(gameObject, 0.1f);
        }
    }
}
