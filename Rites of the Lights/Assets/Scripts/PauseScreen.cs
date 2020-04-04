using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public GameObject pausescreen;
    public GameObject controlsMenu;
    //public Patrol[] werewolves;
    public static bool isPaused;

    // Start is called before the first frame update
    void Awake()
    {
        //finds each enemy, so we can disable and enable their patrols during pause
        //GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //werewolves = new Patrol[enemies.Length];
        /*for (int i = 0; i < enemies.Length; ++i)
        {
            werewolves[i] = enemies[i].GetComponent<Patrol>();
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseTheGame()
    {
        isPaused = true;
        Time.timeScale = 0;
        pausescreen.SetActive(true);
        //Disable any scripts that still work while timescale active
        /*foreach (Patrol script in werewolves)
        {
            script.enabled = false;
        }*/

    }

    public void ContinueTheGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        pausescreen.SetActive(false);
        //enable scripts again here
        /*foreach (Patrol script in werewolves)
        {
            script.enabled = true;
        }*/

    }
}
