using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RitesCollectibles : MonoBehaviour
{
    public int scoreAmount = 30;
    public AudioClip sound;
    public GameObject collectible;

    void OnTriggerEnter2D(Collider2D trig)
    {

        if (trig.gameObject.tag == "Player")
        {
            ViviScore.playerscore += scoreAmount;
            AudioSource.PlayClipAtPoint(sound, transform.position);
            Destroy(collectible);
        }
    }
}
