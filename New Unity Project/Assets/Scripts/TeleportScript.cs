using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportScript : MonoBehaviour
{
    
    public Sprite Detective;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bus"))
        {
           // Debug.Log("YES");
            transform.position = new Vector3(60, -18, -1);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("YES");
            transform.position = new Vector3(-60, -40, -1);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Detective;
        }

        if (collision.gameObject.CompareTag("Door"))
        {
            //Debug.Log("YES");
            transform.position = new Vector3(10, -60, -1);

        }
        if (collision.gameObject.CompareTag("Closet"))
            {
            Debug.Log("Yes");

            SceneManager.LoadScene("StartMenu");
            }
           
        }
    }



