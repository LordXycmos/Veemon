using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    //Variables
    public float liveTime = 0.24f;
    public float rotSpeed;

    void Update()
    {
        //Spins the axe
        transform.Rotate(0, 0, rotSpeed);

        //Destroys the axe after certain amount of time
        Destroy(this.gameObject, liveTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroys the axe on collision
        Destroy(gameObject);
    }
}
