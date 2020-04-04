using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject controlsButton;
    public GameObject controlsMenu;

    //On click
    public void OpenControls()
    {
        //pause the game code here:

        //open pause menu
        controlsMenu.SetActive(true); //bring up pause menu
        pauseMenu.SetActive(false); //turn off pause button so can't click again while in pause window
    }

    //On click
    public void ReturnToPauseMenu()
    {
        //pause the game code here:

        //open pause menu
        controlsMenu.SetActive(false); //bring up pause menu
        pauseMenu.SetActive(true); //turn off pause button so can't click again while in pause window
    }
}
