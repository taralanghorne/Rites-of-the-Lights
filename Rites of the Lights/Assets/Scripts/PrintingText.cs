using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintingText : MonoBehaviour
{
    public float delayTime = 0.1f;
    public string fullText;
    private string currentText = "";

    public bool finished = false;
    public GameObject skipButton;
    public GameObject regButton;
    public GameObject printTxt;
    public GameObject fullTxt;
    public GameObject fullTxt2;

    private void OnEnable()
    {
        StartCoroutine(ShowText());
    }

    public IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delayTime);
        }
        Debug.Log("done");
        finished = true;
    }

    public void Update()
    {
        if (finished)
        {
            skipButton.SetActive(false);
            regButton.SetActive(true);
        }
    }

    public void Pressed()
    {
        skipButton.SetActive(false);
        fullTxt.SetActive(true);
        regButton.SetActive(true);
        printTxt.SetActive(false);
    }

    public void Pressed2()
    {
        skipButton.SetActive(false);
        fullTxt.SetActive(true);
        fullTxt2.SetActive(true);
        regButton.SetActive(true);
        printTxt.SetActive(false);
    }
}
