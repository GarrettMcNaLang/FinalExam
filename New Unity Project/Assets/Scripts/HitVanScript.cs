using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HitVanScript : MonoBehaviour
{
    public UnityEvent HitVan;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HitVan.Invoke();
        }
    }
}
