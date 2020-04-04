using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEstablishGems : MonoBehaviour
{
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject sound; // sound effect to play when transitioning
    public GameObject gemCount; // the gem counter
    //public GameObject gemText;
    //public static int gems = 50; // starting number of gems

    public void ClickGems()
    {
        newText.SetActive(true); // makes new text/buttons appear
        gemCount.SetActive(true); // turn on gem count
        //gemText.gameObject.GetComponent<Text>().text = ("" + gems);
        pastText.SetActive(false); // makes old text/buttons disappear
        sound.SetActive(true); // makes new text/buttons appear
        //AudioSource.PlayClipAtPoint(sound, transform.position);
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
