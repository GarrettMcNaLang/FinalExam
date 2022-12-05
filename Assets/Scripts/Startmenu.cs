using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startmenu : MonoBehaviour
{
    public GameObject menu;
    public bool paused;



    public void Update()
    {
        if (paused == true)
        {
            menu.SetActive(true);

            Time.timeScale = 0f;
        }
        else
        {
            menu.SetActive(false);

            Time.timeScale = 1f;
        }
    }

    public void ExitGame()
    {
        Debug.Log("Quitted");
        Application.Quit();
    }
}
