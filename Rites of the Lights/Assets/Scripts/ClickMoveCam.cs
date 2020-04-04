using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMoveCam : MonoBehaviour
{
    //public GameObject buttonClicking;
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject pastBubble; // group of text/buttons that you have read - will disappear
    public GameObject newBubble; // group of text/buttons that is next - will appear
    public GameObject newBubble2; // group of text/buttons that is next - will appear
    public GameObject cam;
    public GameObject follow;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveCam()
    {
        pastBubble.SetActive(false); // makes old text/buttons disappear
        pastText.SetActive(false); // makes old text/buttons disappear
        cam.GetComponent<RitesCameraL2>().enabled = false;
        follow.SetActive(true);
        cam.GetComponent<RitesCamFollow>().enabled = true;
        Debug.Log("moving the cam");
        //cam.transform.position = Vector3.MoveTowards(cam.transform.position, target.position, speed * Time.deltaTime);
        StartCoroutine("ClickChoice");
    }

    IEnumerator ClickChoice()
    {
        yield return new WaitForSeconds(2);
        newText.SetActive(true); // makes new text/buttons appear
        newBubble.SetActive(true); // makes new text/buttons appear
        newBubble2.SetActive(true); // makes new text/buttons appear
    }
}
