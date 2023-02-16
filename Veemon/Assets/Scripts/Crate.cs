using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    //Variables
    public float hitPoints = 2;

    void Update()
    {
        //if no more hitpoints left then destroy crate
        if(hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //when hit by axe remove 1 hitpoint
        if(collision.gameObject.tag == "Axe")
        {
            hitPoints--;
        }
    }
}
