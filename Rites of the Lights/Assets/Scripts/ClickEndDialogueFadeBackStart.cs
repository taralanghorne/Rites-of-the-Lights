using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEndDialogueFadeBackStart : MonoBehaviour
{
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject newBubble; // group of text/buttons that you have read - will disappear
    //public GameObject pastBubble2; // group of text/buttons that is next - will appear
    public GameObject fade;
    public GameObject fadeFromBlack;
    //public GameObject playerPause;

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
        //pastBubble.SetActive(false); // makes old text/buttons disappear
        //pastBubble2.SetActive(false); // makes new text/buttons appear
        //fade.GetComponent<FadeFromBlackDisappear>().enabled = true;
        fadeFromBlack.SetActive(true);
        fade.SetActive(false);
        StartCoroutine("FromBlack");
        //playerPause.GetComponent<ViviPauseControl>().PlayerResume();
    }

    public IEnumerator FromBlack()
    {
        yield return new WaitForSeconds(2f);
        //fromBlack.SetActive(false);
        //StartCoroutine("FromBlack");
        newText.SetActive(true);
        newBubble.SetActive(true);
    }
}
