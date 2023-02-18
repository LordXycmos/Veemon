using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    //Variables
    public GameObject mainMenu;
    public GameObject crate;
    public GameObject pillar;
    public GameObject player1;
    public GameObject player2;
    public GameObject leftWall;
    public GameObject rightWall;
    public GameObject hpCounters;
    private bool canSpawn = true;
    private float lwx = -16.5f;
    private float rwx = 16.5f;
    private float x = -7.5f;
    private float y = 4.5f;

    //Do I need this?
    void Update()
    {
        if(GameObject.FindWithTag("Player1") == null || GameObject.FindWithTag("Player2") == null)
        {
            ResetWalls();
        }
    }

    //Calls for the map to be spawned in
    public void ActivateWorld()
    {
        mainMenu.SetActive(false);
        canSpawn = true;
        SpawnWorld();
    }

    //Spawns in all the pillars, crates and players
    public void SpawnWorld()
    {
        for(int i = 0; i <= 144; i++)
        {
            if (canSpawn)
            {
                if(i == 16 || i == 32 || i == 48 || i == 64 || i == 80 || i ==  96 || i == 112 || i == 128)
                {
                    //Sets the position to the next row
                    y--;
                    x -= 16;
                }
                
                if(i == 67)
                {
                    //Spawns player 1
                    player1.transform.position = new Vector3(x, y, 0);
                    player1.SetActive(true);
                    x++;
                }
                else if(i == 76)
                {
                    //Spawns player 2
                    player2.transform.position = new Vector3(x, y, 0);
                    player2.SetActive(true);
                    hpCounters.SetActive(true);
                    x++;
                }
                else if(i == 144)
                {
                    //Stops the spawning and resets the spawning positions
                    canSpawn = false;
                    i = 0;
                    x = -7.5f;
                    y = 4.5f;
                }
                else if (i == 5 || i == 10 || i == 16 || i == 19 || i == 24 || i == 28 || i == 31 || i == 50 || i == 52 || i == 59 || i == 61 || i == 64 || i == 70 || i == 73 || i == 79 || i == 82 || i == 84 || i == 91 || i == 93 || i == 112 || i == 115 || i == 119 || i == 124 || i == 127 || i == 133 || i == 138)
                {
                    //Spawns the pillars
                    Instantiate(pillar, new Vector3(x, y, 0), Quaternion.identity);
                    x++;
                }
                else
                {
                    //Spawns the crates
                    Instantiate(crate, new Vector3(x, y, 0), Quaternion.identity);
                    x++;
                }
            }
        }
    }

    //Do I need this?
    public void ResetWalls()
    {
        leftWall.transform.position = new Vector3(lwx, 0.5f, 0);
        rightWall.transform.position = new Vector3(rwx, 0.5f, 0);
    }
}
