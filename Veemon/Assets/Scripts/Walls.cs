using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    //Variables
    public GameObject leftWall;
    public GameObject rightWall;
    private float leftPosition = -16.5f;
    private float rightPosition = 16.5f;
    private float countdown;
    private float nextMove;
    private float moves;
    private bool canMove = false;
    private bool nextMoveAvailable = true;
    private bool gameActive = false;
    private bool resetCountdown = true;

    private void Update()
    {
        //Walls only work if the game is active
        if (gameActive)
        {
            //Resets the countdown for the walls to start moving
            if (resetCountdown)
            {
                countdown = Time.time + 45;
                resetCountdown = false;
            }

            //Makes sure the walls are in the correct position
            leftWall.transform.position = new Vector3(leftPosition, 0.5f, 0);
            rightWall.transform.position = new Vector3(rightPosition, 0.5f, 0);

            //Makes the first move when the countdown is over
            if(countdown < Time.time && !canMove)
            {
                leftPosition = -14.5f;
                rightPosition = 14.5f;
                canMove = true;
            }

            if(canMove && moves <= 3)
            {
                //Resets the countdown for the walls to make the next move
                if (nextMoveAvailable)
                {
                    nextMove = Time.time + 15;
                    nextMoveAvailable = false;
                }

                //Moves the walls slightly
                if(nextMove < Time.time)
                {
                    leftPosition += 1;
                    rightPosition -= 1;
                    nextMoveAvailable = true;
                    moves++;
                }
            }

            //Calls for the walls to be reset when a player is missing/dead
            if(GameObject.FindWithTag("Player1") == null || GameObject.FindWithTag("Player2") == null)
            {
                ResetWalls();
            }
        }
    }

    //Activates the game
    public void GameActive()
    {
        gameActive = true;
    }

    //Resets the walls by repositioning the walls and changing all the variables to their original states
    public void ResetWalls()
    {
        leftPosition = -17.5f;
        rightPosition = 17.5f;
        canMove = false;
        nextMoveAvailable = true;
        resetCountdown = true;
        moves = 0;
        gameActive = false;
    }
}
