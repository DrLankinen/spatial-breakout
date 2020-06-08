using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    void Awake()
    {
        Time.timeScale = 0;
    }

    public void StartButtonClick()
    {
        Time.timeScale = 1;
    }
}
