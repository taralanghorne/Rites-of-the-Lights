using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickStopSound : MonoBehaviour
{
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject stopsound; // sound effect to play when transitioning
    public GameObject oldBackground;
    public GameObject newBackground;

    public void ChoiceStopSound()
    {
        newText.SetActive(true); // makes new text/buttons appear
        newBackground.SetActive(true); // makes new text/buttons appear
        oldBackground.SetActive(false); // makes old text/buttons disappear
        pastText.SetActive(false); // makes old text/buttons disappear
        stopsound.SetActive(false); // makes gameobject with audio attached become active, set play on awake: will play sound effect
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
