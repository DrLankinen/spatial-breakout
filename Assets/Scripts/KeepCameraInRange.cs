﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepCameraInRange : MonoBehaviour
{
    public float xLeftRange = -3.6f;
    public float xRightRange = 3.6f;
    public float zFrontRange = 2.8f;
    public float zBackRange = -2.8f;

    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        if(x < xLeftRange)
        {
            transform.position = new Vector3(xLeftRange, y, z);
        }
        if(x > xRightRange)
        {
            transform.position = new Vector3(xRightRange, y, z);
        }
        if(z > zFrontRange)
        {
            transform.position = new Vector3(x, y, zFrontRange);
        }
        if(z < zBackRange)
        {
            transform.position = new Vector3(x, y, zBackRange);
        }
    }
}
