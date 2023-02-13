using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTwoMovement : MonoBehaviour
{
    //Variables
    public const float playerSpeed = 2f;
    private float healthPoints = 1;
    public TextMeshProUGUI hpCounter;
    public GameObject hpCounters;

    void Update()
    {
        //Eliminates player when he has 0 or less health points
        if (healthPoints <= 0)
        {
            gameObject.SetActive(false);
            hpCounters.SetActive(true);
        }

        //Defines current position
        Vector3 position = transform.position;

        //Changes position information
        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.y += playerSpeed * Time.deltaTime;
            transform.eulerAngles = Vector3.forward * 0;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= playerSpeed * Time.deltaTime;
            transform.eulerAngles = Vector3.forward * 90;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= playerSpeed * Time.deltaTime;
            transform.eulerAngles = Vector3.forward * 180;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += playerSpeed * Time.deltaTime;
            transform.eulerAngles = Vector3.forward * 270;
        }

        //Moves the player
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Removes a health point when hit by axe
        if (collision.gameObject.tag == "Axe")
        {
            healthPoints--;
            hpCounter.text = healthPoints.ToString() + " HP";
        }

        //Removes all the health points when hit by the moving wall
        if (collision.gameObject.tag == "MovingWallInside")
        {
            healthPoints = 0;
        }

        //Adds a health point when picking up a HP boost
        if (collision.gameObject.tag == "HP Boost")
        {
            healthPoints++;
            hpCounter.text = healthPoints.ToString() + " HP";
        }
    }

    public void GameActive()
    {
        //Resets health points
        healthPoints = 1;
        hpCounter.text = healthPoints.ToString() + " HP";
    }
}
