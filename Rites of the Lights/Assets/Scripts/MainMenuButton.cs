using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void OpenMainMenu()
    {
        ViviHealth.lives = 5;
        ViviHealth.lose = false;
        ViviScore.playerscore = 0; // reset Score
        Targets.targetsHit = 0;
        Targets.targetsAreHit = false;
        Level1End.talked = false;
        //Extra_Life.extraLifeObtained = false;
        PauseScreen.isPaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
