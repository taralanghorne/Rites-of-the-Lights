using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardHole : MonoBehaviour
{
    //public GameObject smokeElectricity;
    public AudioClip explode;
    public AudioClip enemydeath;
    //public GameObject cookie;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<ViviHealth>().TakeDamage();
            collision.GetComponent<ViviHealth>().RespawnHazard();
            //AudioSource.PlayClipAtPoint(enemyAttack, transform.position);
            //hasAttacked = true;
            //Invoke("CanHitAgain", 2);
            //gameObject.GetComponent<Animator>().SetBool("IsRunning", false);
        }
        /*else if (collision.transform.gameObject.name == "UmbraDog")
        {
            AudioSource.PlayClipAtPoint(enemydeath, transform.position);
            //clonePosition = trig.transform.position;
            //Instantiate(collectible, trig.transform.position, trig.transform.gameObject.transform.rotation);
            //cookie = (GameObject)Instantiate(collectible, gameObject.transform.position, gameObject.transform.rotation);
            //cookie.transform.localScale = new Vector3(0.138f, 0.138f, 0.27f);
            //Instantiate(smokeElectricity, gameObject.transform.position, gameObject.transform.rotation);
            //cookie.SetActive(true);
            //smokeElectricity.SetActive(true);
            AudioSource.PlayClipAtPoint(explode, transform.position);
            Debug.Log("Enemy Dying");
            Destroy(gameObject);
            //make it length of animation or audio
        }*/
    }
}
