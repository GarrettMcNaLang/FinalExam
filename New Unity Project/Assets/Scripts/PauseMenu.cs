using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    public bool paused = false;
    
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            {

            if (Input.GetButtonDown("cancel"))
            {
                TogglePauseGame();
            }
        }
    }
    public void TogglePauseGame()
    {
        paused = !paused;

        menu.SetActive(paused);

        if(paused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }
   
}
