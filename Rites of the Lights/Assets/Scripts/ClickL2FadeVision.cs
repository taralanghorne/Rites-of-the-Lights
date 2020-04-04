using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickL2FadeVision : MonoBehaviour
{
    //public GameObject buttonClicking;
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject newText2; // group of text/buttons that is next - will appear
    public GameObject toBlack;
    public GameObject fromBlack;
    public GameObject player;
    public GameObject point;
    public GameObject cam;

    public void ClickChoice()
    {
        newText.SetActive(true); // makes new text/buttons appear
        pastText.SetActive(false); // makes old text/buttons disappear
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
        yield return new WaitForSeconds(5f);
        player.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //gameObject.transform.position = respawn.transform.position;
        player.gameObject.transform.position = point.transform.position;
        fromBlack.SetActive(true);
        toBlack.SetActive(false);
        newText.SetActive(false);
        cam.GetComponent<RitesCamera>().enabled = false;
        cam.GetComponent<RitesCameraL2>().enabled = true;
        StartCoroutine("FromBlack");
    }
    public IEnumerator FromBlack()
    {
        yield return new WaitForSeconds(3f);
        fromBlack.SetActive(false);
        //StartCoroutine("FromBlack");
        newText2.SetActive(true);
    }
}
