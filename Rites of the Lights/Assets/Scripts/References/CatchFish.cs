using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFish : MonoBehaviour
{
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newTextCaught; // group of text/buttons that is next - will appear
    public GameObject newTextMissed; // group of text/buttons that is next - will appear
    public GameObject sound; // sound effect to play when transitioning
    public GameObject fishCount; // the fish counter

    public void TryToCatch()
    {
        float chance = Random.Range(0.0f, 1.0f);
        //float chance = 0.1f;
        Debug.Log(chance);
        if (chance >= 0.5f)
        {
            MissedFish();
        }
        else if (chance < 0.5f)
        {
            CaughtFish();
        }
    }

    public void CaughtFish()
    {
        newTextCaught.SetActive(true); // makes new text/buttons appear
        pastText.SetActive(false); // makes old text/buttons disappear
        fishCount.SetActive(true); // turn on gem count
        FishCounter.fish += 1;
        sound.SetActive(true); // makes new text/buttons appear
    }

    public void MissedFish()
    {
        newTextMissed.SetActive(true); // makes new text/buttons appear
        //sound.SetActive(true); // makes new text/buttons appear
        //fishCount.SetActive(true); // turn on gem count
        FishCounter.fish = 0;
        pastText.SetActive(false); // makes old text/buttons disappear
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
