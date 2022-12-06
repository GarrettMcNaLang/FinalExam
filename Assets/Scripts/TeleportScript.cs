using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bus"))
        {
            Debug.Log("YES");
            transform.position = new Vector3(60, -18, -1);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("YES");
            transform.position = new Vector3(-60, -40, -1);
        }

        if (collision.gameObject.CompareTag("Door"))
        {
            Debug.Log("YES");
            transform.position = new Vector3(10, -60, -1);
        }
    }



}
