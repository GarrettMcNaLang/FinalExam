using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;
using UnityEngine.SceneManagement;

public class Startmenu : MonoBehaviour
{
    //public TextMeshProUGUI secretmessage;

    /*private void Start()
    {
        secretmessage.text = "The Field Trip";
    }

    private void FromBeyond()
    {
        secretmessage.text = "Who are You";
    }
    */
    public void LoadLevel(string MainGame)
    {
        SceneManager.LoadScene(MainGame);
    }
}
