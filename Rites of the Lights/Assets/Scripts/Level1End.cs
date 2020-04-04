using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1End : MonoBehaviour
{
    public GameObject jihunD1;
    public GameObject jihunTargets;
    public GameObject jihunEndD;
    public static bool talked = false;
    //public GameObject dialogue;
    public GameObject speechBubble;
    public GameObject speechT;
    public GameObject speechDots;
    //public AudioClip talk;
    //public bool deactivateTrigger = true;
    bool trigger = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!talked && trigger)
        {
            Debug.Log("not talked");
            if (Input.GetKeyDown(KeyCode.S) && !PauseScreen.isPaused)
            {
                talked = true;
                trigger = false;
                jihunD1.SetActive(true);
                speechT.SetActive(false);
                speechDots.SetActive(true);
            }

        }
        if (talked && trigger)
        {
            Debug.Log("talked");
            if (Targets.targetsAreHit)
            {
                if (Input.GetKeyDown(KeyCode.S) && !PauseScreen.isPaused)
                {
                    trigger = false;
                    jihunEndD.SetActive(true);
                    speechT.SetActive(false);
                    speechDots.SetActive(true);
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.S) && !PauseScreen.isPaused)
                {
                    trigger = false;
                    jihunTargets.SetActive(true);
                    speechT.SetActive(false);
                    speechDots.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D trig)
    {

        if(trig.gameObject.tag == "Player")
        {
            speechBubble.SetActive(true);
            speechT.SetActive(true);
            speechDots.SetActive(false);
            trigger = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            speechBubble.SetActive(false);
            trigger = false;
        }
    }
}
