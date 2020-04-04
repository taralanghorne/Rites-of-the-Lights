
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmbraFollowFlat : MonoBehaviour
{
    public float speed = 10.0f;
    //public GameObject followR;
    //public GameObject followL;
    public GameObject player;
    public GameObject umbra;
    public GameObject umbraLightRight;
    public GameObject umbraLightLeft;
    //public GameObject umbraAlertRight;
    //public GameObject umbraAlertLeft;
    public Vector2 position;
    public bool alerted = false;
    public GameObject dialogue;
    //public GameObject umbraTrigger;
    //public GameObject startPosition;
    public AudioClip alert;

    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        if (alerted && !umbra.GetComponent<UmbraAttacking>().hasAttacked /*&& umbraTrigger.GetComponent<UmbraAreaTrigger>().InRange*/)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x, transform.position.y), step);
            umbra.GetComponent<Animator>().SetBool("IsRunning", true);
        } /*else if (alerted && !umbraTrigger.GetComponent<UmbraAreaTrigger>().InRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, startPosition.transform.position, step);
            alerted = false;
        }*/

        if (player.transform.position.x < umbra.transform.position.x)
        {
            umbra.GetComponent<SpriteRenderer>().flipX = true;
            umbraLightLeft.SetActive(true);
            umbraLightRight.SetActive(false);
            //umbraAlertLeft.SetActive(true);
            //umbraAlertRight.SetActive(false);
        }
        else if (player.transform.position.x > umbra.transform.position.x)
        {
            umbra.GetComponent<SpriteRenderer>().flipX = false;
            umbraLightLeft.SetActive(false);
            umbraLightRight.SetActive(true);
            //umbraAlertLeft.SetActive(false);
            //umbraAlertRight.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!alerted && collision.gameObject.tag == "Player")
        {
            dialogue.SetActive(true);
            AudioSource.PlayClipAtPoint(alert, transform.position);
            StartCoroutine("DialogueOff");
        }
    }

    IEnumerator DialogueOff()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("dialogue off");
        dialogue.SetActive(false);
        alerted = true;
    }
}
