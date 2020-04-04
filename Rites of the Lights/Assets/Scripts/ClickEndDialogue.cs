﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEndDialogue : MonoBehaviour
{
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    //public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject pastBubble; // group of text/buttons that you have read - will disappear
    public GameObject pastBubble2; // group of text/buttons that is next - will appear
    public GameObject playerPause;

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
        //newText.SetActive(true); // makes new text/buttons appear
        pastText.SetActive(false); // makes old text/buttons disappear
        //newBubble.SetActive(true); // makes new text/buttons appear
        pastBubble.SetActive(false); // makes old text/buttons disappear
        pastBubble2.SetActive(false); // makes new text/buttons appear
        playerPause.GetComponent<ViviPauseControl>().PlayerResume();
    }
}
