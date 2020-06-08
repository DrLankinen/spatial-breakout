using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    // Start is called before the first frame update
    public static int livesLeft;
    Text lives;
    void Start()
    {
        livesLeft = 10;
        lives = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        lives.text = "Lives: " + livesLeft;
    }
}
