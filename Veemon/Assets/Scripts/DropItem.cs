using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    //Variables
    public GameObject hpBoost;
    private float hitCount = 2;
    private float dropChance;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //when hit by axe remove 1 hit count
        if (collision.gameObject.tag == "Axe" && hitCount > 0)
        {
            hitCount--;

            //if hit count is 0 then get a random number and if that number is 0 then spawn hp boost
            if(hitCount <= 0)
            {
                //gets random number
                dropChance = Random.Range(0, 15);

                if(dropChance == 3)
                {
                    //spawns the hp boost
                    Instantiate(hpBoost, transform.position, Quaternion.identity);
                }
            }
        }
    }
}
