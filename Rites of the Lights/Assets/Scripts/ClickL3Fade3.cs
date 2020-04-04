using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickL3Fade3 : MonoBehaviour
{
    //public GameObject buttonClicking;
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject newText2; // group of text/buttons that is next - will appear
    public GameObject toBlack;
    public GameObject fromBlack;
    //public GameObject player;
    //public GameObject point;
    public GameObject pastBubble;
    public GameObject newBubble;
    public GameObject cam;

    public void ClickChoice()
    {
        newText.SetActive(true); // makes new text/buttons appear
        pastText.SetActive(false); // makes old text/buttons disappear
        pastBubble.SetActive(false);
        toBlack.SetActive(true);
        StartCoroutine("ToBlack");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator ToBlack()
    {
        yield return new WaitForSeconds(2f);
        //player.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //gameObject.transform.position = respawn.transform.position;
        //player.gameObject.transform.position = point.transform.position;
        fromBlack.SetActive(true);
        toBlack.SetActive(false);
        newText.SetActive(false);
        cam.GetComponent<RitesCamL3>().enabled = false;
        cam.GetComponent<RitesCamL3_2>().enabled = true;
        StartCoroutine("FromBlack");
    }
    public IEnumerator FromBlack()
    {
        yield return new WaitForSeconds(2f);
        fromBlack.SetActive(false);
        //StartCoroutine("FromBlack");
        newText2.SetActive(true);
        newBubble.SetActive(true);
    }
}
