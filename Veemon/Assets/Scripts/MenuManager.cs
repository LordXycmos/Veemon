using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    //Variables
    public GameObject exitMenu;
    public GameObject mainMenu;
    public GameObject helpMenu;
    public GameObject endMenu;
    public GameObject blueWinsScreen;
    public GameObject redWinsScreen;

    //Disables main menu and activates exit menu
    public void ExitMenuButton()
    {
        mainMenu.SetActive(false);
        exitMenu.SetActive(true);
    }

    //Disables exit menu and activates main menu
    public void CancelExitMenuButton()
    {
        exitMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    //Disables main menu and activates help menu
    public void HelpMenuButton()
    {
        mainMenu.SetActive(false);
        helpMenu.SetActive(true);
    }

    //Disables help menu and activates main menu
    public void ExitHelpMenuButton()
    {
        helpMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    //Closes the application
    public void QuitGame()
    {
        Application.Quit();
        print("Quit the game");
    }

    //Disables end menu and activates main menu
    public void ExitEndScreenToMenu()
    {
        blueWinsScreen.SetActive(false);
        redWinsScreen.SetActive(false);
        endMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    //Disables end menu
    public void NewGame()
    {
        blueWinsScreen.SetActive(false);
        redWinsScreen.SetActive(false);
        endMenu.SetActive(false);
    }
}
