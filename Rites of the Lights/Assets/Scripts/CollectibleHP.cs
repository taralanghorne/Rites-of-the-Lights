using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleHP : MonoBehaviour
{
    public GameObject player;
    public GameObject health;
    public AudioClip heart;
    public int scoreAmount = 30;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.GetComponent<ViviHealth>().AddHealth();
            ViviScore.playerscore += scoreAmount;
            AudioSource.PlayClipAtPoint(heart, transform.position);
            Destroy(health);
        }
    }
}
