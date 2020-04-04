using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L2End : MonoBehaviour
{
    public GameObject fade;
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    //public GameObject pastBubble; // group of text/buttons that you have read - will disappear
    //public GameObject pastBubble2; // group of text/buttons that is next - will appear
    //public GameObject playerPause;
    //private Animator anim;
    public GameObject npc;
    public string levelToLoad;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject umbra1;
    public GameObject umbra2;
    public GameObject umbra3;
    public GameObject umbra4;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void End()
    {
        float step = speed * Time.deltaTime;
        StartCoroutine("EndLevel");
        fade.SetActive(true);
        newText.SetActive(true); // makes new text/buttons appear
        pastText.SetActive(false); // makes old text/buttons disappear
        enemy1.GetComponent<MoveTowards>().enabled = true;
        enemy2.GetComponent<MoveTowards>().enabled = true;
        enemy3.GetComponent<MoveTowards>().enabled = true;
        enemy4.GetComponent<MoveTowards>().enabled = true;
        umbra1.GetComponent<Animator>().SetBool("IsRunning", true);
        umbra2.GetComponent<Animator>().SetBool("IsRunning", true);
        umbra3.GetComponent<Animator>().SetBool("IsRunning", true);
        umbra4.GetComponent<Animator>().SetBool("IsRunning", true);
        //newBubble.SetActive(true); // makes new text/buttons appear
        //pastBubble.SetActive(false); // makes old text/buttons disappear
        //pastBubble2.SetActive(false); // makes new text/buttons appear
        //npc.GetComponent<Animator>().SetBool("IsTalking", false);
    }

    IEnumerator EndLevel()
    {
        yield return new WaitForSeconds(7);
        //Debug.Log("new scene");
        SceneManager.LoadScene(levelToLoad);
    }
}
