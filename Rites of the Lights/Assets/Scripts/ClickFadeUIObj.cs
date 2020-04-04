using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFadeUIObj : MonoBehaviour
{
    //public GameObject buttonClicking;
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject pastBubble; // group of text/buttons that you have read - will disappear
    public GameObject newBubble; // group of text/buttons that is next - will appear
    public GameObject obj1;
    public GameObject obj2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickChoice()
    {
        newText.SetActive(true); // makes new text/buttons appear
        pastText.SetActive(false); // makes old text/buttons disappear
        newBubble.SetActive(true); // makes new text/buttons appear
        pastBubble.SetActive(false); // makes old text/buttons disappear
        obj1.GetComponent<FadeInUI>().enabled = false;
        obj1.GetComponent<FadeOut>().enabled = true;
        obj2.GetComponent<FadeInUI>().enabled = false;
        obj2.GetComponent<FadeOut>().enabled = true;


    }
}
