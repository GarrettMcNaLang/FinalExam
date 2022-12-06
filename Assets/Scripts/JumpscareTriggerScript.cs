using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JumpscareTriggerScript : MonoBehaviour
{
    public UnityEvent Jumpscare;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Jumpscare.Invoke();
        }
    }
}
