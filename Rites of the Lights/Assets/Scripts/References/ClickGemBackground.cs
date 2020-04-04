using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickGemBackground : MonoBehaviour
{
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject sound; // sound effect to play when transitioning
    public int amount; // amount of gems added or taken (taken will be negative)
    public GameObject stopsound;
    public GameObject oldBackground;
    public GameObject newBackground;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GemChange()
    {
        newText.SetActive(true); // makes new text/buttons appear
        pastText.SetActive(false); // makes old text/buttons disappear                             
        sound.SetActive(true); // makes new text/buttons appear
        stopsound.SetActive(false); // makes gameobject with audio attached become active, set play on awake: will play sound effect
        GemCount.gems += amount;
        Debug.Log(GemCount.gems);
        oldBackground.SetActive(false);
        newBackground.SetActive(true);
    }
}
