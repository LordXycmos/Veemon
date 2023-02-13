using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneThrowing : MonoBehaviour
{
    //Variables
    public Transform firepoint;
    public GameObject axePrefab;
    public GameObject heldAxe;
    private float nextShot;
    public float bulletForce = 10f;
    public float cooldown = 0.5f;
    public bool canShoot = true;

    void Update()
    {
        //Throws axe when E is pressed
        if(Input.GetKeyDown(KeyCode.E) && canShoot)
        {
            Throw();
            canShoot = false;
            nextShot = Time.time + cooldown;
            heldAxe.SetActive(false);
        }

        //Can throw axe again when cooldown is over
        if(Time.time > nextShot)
        {
            canShoot = true;
            heldAxe.SetActive(true);
        }
    }

    void Throw()
    {
        //Spawns the axe and makes it move
        GameObject axe = Instantiate(axePrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = axe.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
