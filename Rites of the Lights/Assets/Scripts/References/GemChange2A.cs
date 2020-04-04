using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemChange2A : MonoBehaviour
{
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject sound; // sound effect to play when transitioning
    public int amount; // amount of gems added or taken (taken will be negative)
    public static bool traded = false;

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
        Debug.Log(GemCount.gems);
        traded = true;
        Debug.Log(traded);
    }
}
