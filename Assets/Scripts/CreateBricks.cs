using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBricks : MonoBehaviour
{
    public GameObject brick;

    void Start()
    {
        for(int r = 0; r < 3; r++)
        {
            for(int c = 0; c < 4; c++)
            {
                float width = brick.transform.localScale.x;
                float height = brick.transform.localScale.y;
                var newBrick = Instantiate(brick, 
                    new Vector3(transform.position.x + width * c, 
                                transform.position.y + height * r,
                                transform.position.z), Quaternion.identity);
                newBrick.transform.parent = gameObject.transform;
                newBrick.GetComponent<Brick>().numberOfHitsLeft = Random.Range(1, 6);
            }
        }
    }
}
