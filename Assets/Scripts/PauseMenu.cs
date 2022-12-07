using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu;
    public static bool ispaused;

    void Start()
    {
        pausemenu.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    public void PauseGame()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }

    public void ResumeGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }

    public void ExitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }
}
