using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startmenu : MonoBehaviour
{
 
    public void ExitGame()
    {
        Debug.Log("Quitted");
        Application.Quit();
    }

    public void LoadLevel(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
}
