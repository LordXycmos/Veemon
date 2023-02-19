using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    //Variables
    public GameObject crackedCrate;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //When hit by axe spawn a cracked crate and destroy current crate
        if(collision.gameObject.tag == "Axe")
        {
            Instantiate(crackedCrate, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
