using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickChangeMusicNoBackground : MonoBehaviour
{
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    //public GameObject sound; // sound effect to play when transitioning
    public GameObject oldMusic;
    public GameObject newMusic;
    //public GameObject oldBackground;
    //public GameObject newBackground;

    public void ChoiceStopSound()
    {
        newText.SetActive(true); // makes new text/buttons appear
        newMusic.SetActive(true); // makes new text/buttons appear
        oldMusic.SetActive(false); // makes old text/buttons disappear
        //newBackground.SetActive(true);
        //oldBackground.SetActive(false);
        pastText.SetActive(false); // makes old text/buttons disappear
        //sound.SetActive(true); // makes gameobject with audio attached become active, set play on awake: will play sound effect
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
