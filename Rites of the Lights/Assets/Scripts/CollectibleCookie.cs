using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleCookie : MonoBehaviour
{
    public int scoreAmount = 30;
    public AudioClip sound;
    public GameObject collectible;
    public ParticleSystem chew;

    void OnTriggerEnter2D(Collider2D trig)
    {

        if (trig.gameObject.tag == "Player")
        {
            ViviScore.playerscore += scoreAmount;
            AudioSource.PlayClipAtPoint(sound, transform.position);
            chew.Play();
            Destroy(collectible);
        }
    }
}
