using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenManager : MonoBehaviour
{
    //Variables
    public GameObject startScreen;
    public GameObject mainMenu;
    private bool available = true;

    void Update()
    {
        //Deactivates start screen and activates main menu
        if (Input.GetKeyDown(KeyCode.Space) && available)
        {
            startScreen.SetActive(false);
            mainMenu.SetActive(true);
            available = false;
        }
    }
}
