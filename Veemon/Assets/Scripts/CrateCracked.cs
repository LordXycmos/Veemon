using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateCracked : MonoBehaviour
{
    //Variables
    public GameObject hpBoost;
    private float dropChance;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Only works when hit by an axe
        if (collision.gameObject.tag == "Axe")
        {
            //calculates random number between 0 and 10
            dropChance = Random.Range(0, 10);

            //if the random number is 3 then spawn in an HP boost
            if(dropChance == 3)
            {
                //Spawns in the HP boost
                Instantiate(hpBoost, transform.position, Quaternion.identity);
            }

            //Destroys the crate
            Destroy(gameObject);
        }
    }
}
