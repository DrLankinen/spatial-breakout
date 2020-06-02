using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBricks : MonoBehaviour
{
    public GameObject brick;

    void Start()
    {
        var newBrick = Instantiate(brick, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        newBrick.transform.parent = gameObject.transform;
        newBrick.GetComponent<Brick>().numberOfHitsLeft = Random.Range(1, 6);
    }
}
