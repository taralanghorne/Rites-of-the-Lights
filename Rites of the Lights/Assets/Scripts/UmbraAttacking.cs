using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmbraAttacking : MonoBehaviour
{
    public bool hasAttacked = false;
    public GameObject cookie;
    //public GameObject collectible;
    public GameObject smokeElectricity;
    public GameObject smokeLeaf;
    public AudioClip explode;
    public AudioClip leaves;
    public AudioClip enemydeath;
    public AudioClip enemyAttack;

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
            AudioSource.PlayClipAtPoint(enemyAttack, transform.position);
            hasAttacked = true;
            Invoke("CanHitAgain", 2);
            gameObject.GetComponent<Animator>().SetBool("IsRunning", false);
        }
        else if (collision.transform.gameObject.tag == "Zap")
        {
            AudioSource.PlayClipAtPoint(enemydeath, transform.position);
            //clonePosition = trig.transform.position;
            //Instantiate(collectible, trig.transform.position, trig.transform.gameObject.transform.rotation);
            //cookie = (GameObject)Instantiate(collectible, gameObject.transform.position, gameObject.transform.rotation);
            //cookie.transform.localScale = new Vector3(0.138f, 0.138f, 0.27f);
            //Instantiate(smokeElectricity, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(collision.gameObject);
            cookie.SetActive(true);
            smokeElectricity.SetActive(true);
            AudioSource.PlayClipAtPoint(explode, transform.position);
            Debug.Log("Enemy Dying");
            Destroy(gameObject);
            //make it length of animation or audio
        }
        else if (collision.transform.gameObject.tag == "Leaf")
        {
            Debug.Log("Enemy Dying");
            AudioSource.PlayClipAtPoint(enemydeath, transform.position);
            //clonePosition = trig.transform.position;
            //Instantiate(collectible, trig.transform.position, trig.transform.gameObject.transform.rotation);
            //cookie = (GameObject)Instantiate(collectible, gameObject.transform.position, gameObject.transform.rotation);
            //cookie.transform.localScale = new Vector3(0.138f, 0.138f, 0.27f);
            //Instantiate(smokeElectricity, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(collision.gameObject);
            cookie.SetActive(true);
            smokeLeaf.SetActive(true);
            AudioSource.PlayClipAtPoint(leaves, transform.position);
            Destroy(gameObject);
            //make it length of animation or audio
        }
    }

    void CanHitAgain()
    {
        hasAttacked = false;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
    }
}
