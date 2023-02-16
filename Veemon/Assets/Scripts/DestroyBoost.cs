using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoost : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy object when colliding with a player or axe
        if(collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2" || collision.gameObject.tag == "Axe")
        {
            Destroy(gameObject);
        }
    }
}
