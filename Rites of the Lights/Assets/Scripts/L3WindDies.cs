using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3WindDies : MonoBehaviour
{
    public GameObject[] anims;
    public GameObject[] enemies;
    public GameObject music;
    public GameObject windNoise;
    public GameObject windParticles;
    public AudioClip finalWindGust;

    // Start is called before the first frame update
    void Awake()
    {
        anims = GameObject.FindGameObjectsWithTag("Anims");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (GameObject anim in anims)
            {
                anim.GetComponent<Animator>().SetBool("NotBlowing", true);
            }
            

            music.SetActive(false);
            windNoise.SetActive(false);
            AudioSource.PlayClipAtPoint(finalWindGust, transform.position);
            windParticles.SetActive(false);
            foreach (GameObject enemy in enemies)
            {
                enemy.SetActive(false);
            }
        }
    }
}
