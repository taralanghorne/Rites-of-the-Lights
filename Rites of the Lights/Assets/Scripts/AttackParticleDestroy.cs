using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackParticleDestroy : MonoBehaviour
{

    public AudioClip explosion;
    public GameObject explosionParticle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Barrier")
        {
            AudioSource.PlayClipAtPoint(explosion, transform.position);
            Instantiate(explosionParticle, gameObject.transform.gameObject.transform.position, gameObject.transform.gameObject.transform.rotation);
            Destroy(gameObject);
        }else if (trig.gameObject.tag == "Enemy")
        {

        }
    }
}
