using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFishExchange : MonoBehaviour
{
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject sound; // sound effect to play when transitioning
    public int amount; // amount of gems added or taken (taken will be negative)

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
        GemCount.gems += amount;
        FishCounter.fish -= 1;
        Debug.Log(GemCount.gems);
        Debug.Log(FishCounter.fish);
    }
}
