using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GroundCheckScript : MonoBehaviour
{

    GameObject Player;



    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //CALL FROM INSIDE UPDATE< MOVE OUT OF UPDATE
        private void OnCollisionEnter2D(Collision2D collision)
        {
            
            if (collision.collider.tag == "Ground")
            {
                Player.GetComponent<PlayerMove>().isGrounded = true;
            }
        }


        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.collider.tag == "Ground")
            {
                Player.GetComponent<PlayerMove>().isGrounded = false;
            }
        }
    }
}
}
