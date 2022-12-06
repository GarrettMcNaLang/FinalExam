using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    //each of the locations that the player teleports to; BusPoint will be the area in the next scene that
    //the player teleports to
    Vector3 StartPoint;
    Vector3 BusPoint;
    Vector3 VanPoint;
    Vector3 DoorPoint;

    // Start is called before the first frame update
    void Start()
    {
        StartPoint = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bus"))
        {
            Debug.Log("YES");
            //
            transform.position = BusPoint;
        }
    }
}
