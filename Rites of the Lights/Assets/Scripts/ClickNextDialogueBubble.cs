using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNextDialogueBubble : MonoBehaviour
{
    //public GameObject buttonClicking;
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject pastBubble; // group of text/buttons that you have read - will disappear
    public GameObject newBubble; // group of text/buttons that is next - will appear
    public GameObject newBubble2; // group of text/buttons that is next - will appear

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
        newBubble2.SetActive(true); // makes new text/buttons appear
    }
}
