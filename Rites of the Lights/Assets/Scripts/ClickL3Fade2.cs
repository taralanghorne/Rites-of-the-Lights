using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickL3Fade2 : MonoBehaviour
{
    //public GameObject buttonClicking;
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject speechBubble; // group of text/buttons that is next - will appear
    public GameObject newText2; // group of text/buttons that is next - will appear
    public GameObject toBlack;
    public GameObject fromBlack;
    public GameObject player;
    public GameObject player2;
    public GameObject chilumen1;
    public GameObject chilumen2;
    public GameObject point;
    public GameObject cam;

    public void ClickChoice()
    {
        //newText.SetActive(true); // makes new text/buttons appear
        pastText.SetActive(false); // makes old text/buttons disappear
        speechBubble.SetActive(false);
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
        //player.GetComponent<SpriteRenderer>().flipX = true;
        //player.GetComponent<Animator>().SetBool("IsJumping", false);
        //player.SetActive(false);
        player2.SetActive(true);
        chilumen1.SetActive(false);
        chilumen2.SetActive(true);
        //fromBlack.SetActive(true);
        //toBlack.SetActive(false);
        //newText.SetActive(false);
        newText2.SetActive(true);
        cam.GetComponent<RitesCameraL2>().enabled = false;
        cam.GetComponent<RitesCamL3>().enabled = true;
        StartCoroutine("FromBlack");
    }
    public IEnumerator FromBlack()
    {
        yield return new WaitForSeconds(2f);
        //fromBlack.SetActive(false);
        //StartCoroutine("FromBlack");
        //newText2.SetActive(true);
        //speechBubble.SetActive(true);
    }
}
