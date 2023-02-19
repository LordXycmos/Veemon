using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathSound : MonoBehaviour
{
    //Variables
    public AudioSource audioPlayer;
    private bool gameActive = false;

    void Start()
    {
        //Defines the audio source
        audioPlayer = GetComponent<AudioSource>();
    }

    void Update()
    {
        //If a player is missing from the scene and the game is active then play the death sound
        if (GameObject.FindWithTag("Player1") == null && gameActive || GameObject.FindWithTag("Player2") == null && gameActive)
        {
            audioPlayer.Play();
            gameActive = false;
        }
    }

    //Defines the game as active
    public void ActivateGame()
    {
        gameActive = true;
    }
}
