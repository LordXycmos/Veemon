using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneReset : MonoBehaviour
{
    //Variables
    public GameObject endScreen;
    public GameObject redWins;
    public GameObject blueWins;
    public GameObject player1;
    public GameObject player2;
    private bool blueHasWon = false;
    private bool redHasWon = false;
    private bool gameActive = false;
    private float time;

    void Start()
    {
        //Do I need this?
        time = Time.time + 3;
    }

    void Update()
    {
        //Only works if the game is active
        if (gameActive)
        {
            //If player 1 dies then turn off the game and show the blue wins menu
            if(GameObject.FindWithTag("Player1") == null && time < Time.time && !blueHasWon)
            {
                redHasWon = true;
                DestroyMap();
                endScreen.SetActive(true);
                blueWins.SetActive(true);
                gameActive = false;
            }
            //If player 2 dies then turn off the game and show the red wins menu
            else if (GameObject.FindWithTag("Player2") == null && time < Time.time && !redHasWon)
            {
                blueHasWon = true;
                DestroyMap();
                endScreen.SetActive(true);
                redWins.SetActive(true);
                gameActive = false;
            }
        }
    }

    public void DestroyMap()
    {
        //Deletes all the crates in the scene
        GameObject[] crates = GameObject.FindGameObjectsWithTag("Crate1");
        foreach (GameObject crate in crates)
            GameObject.Destroy(crate);

        //Deletes all the pillars in the scene
        GameObject[] pillars = GameObject.FindGameObjectsWithTag("Pillar");
        foreach (GameObject pillar in pillars)
            GameObject.Destroy(pillar);

        //Makes the players disappear from the scene
        player1.SetActive(false);
        player2.SetActive(false);
    }

    public void GameActive()
    {
        //Resets variables and sets game to active
        gameActive = true;
        time = Time.time + 3;
        blueHasWon = false;
        redHasWon = false;
    }
}
