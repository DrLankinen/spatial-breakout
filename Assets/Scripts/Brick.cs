using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int numberOfHitsLeft = 2;

    void setColor(Color color) {
        this.gameObject.GetComponent<Renderer>().material.color = color;
    }

    void updateColor() {
        switch(numberOfHitsLeft)
        {
            case 1:
                setColor(new Color(0.0f, 1.0f, 0.5f, 0.9f));
                break;
            case 2:
                setColor(new Color(0.0f, 0.8f, 1.0f, 0.9f));
                break;
            case 3:
                setColor(new Color(0.0f, 0.2f, 1.0f, 0.9f));
                break;
            case 4:
                setColor(new Color(0.9f, 0.0f, 1.0f, 0.9f));
                break;
            case 5:
                setColor(new Color(1.0f, 0.0f, 0.0f, 0.9f));
                break;
        }
    }

    void Start()
    {
        updateColor();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.collider.gameObject.tag == "Ball")
        {
            numberOfHitsLeft--;
            if(numberOfHitsLeft <= 0) Destroy(gameObject, 0.1f);
            updateColor();
        }
    }
}
