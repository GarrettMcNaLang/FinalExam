using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Startmenu : MonoBehaviour
{
    public GameObject start ;
    public bool menuActive;
    
    void Update()
    {
        start.SetActive(false);
        menuActive = (true);

        Time.timeScale = 0f;

        if (Input.GetMouseButtonDown(0))
        {
            start.SetActive(true);
            menuActive = (false);

            Time.timeScale = 1f;
        }

    }
}
