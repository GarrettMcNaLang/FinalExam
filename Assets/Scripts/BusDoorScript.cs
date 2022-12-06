using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class BusDoorScript : MonoBehaviour
{
    //announces the unityevent
    public UnityEvent BusDoors;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("YES");
            //when the player hits the doors, it will run all the scripts in the unityevents
            BusDoors.Invoke();
        }
    }

    

}
