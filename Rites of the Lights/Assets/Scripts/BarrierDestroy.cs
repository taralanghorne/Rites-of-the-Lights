using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierDestroy : MonoBehaviour
{
    public AudioClip explosion;
    public AudioClip leaves;
    public GameObject explosionParticle;
    public GameObject leafParticle;

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
            if (trig.gameObject.tag == "Zap")
            {
                //ViviScore.playerscore += 20;
                //Targets.targetsHit++;
                //targetChar.SetActive(true);
                AudioSource.PlayClipAtPoint(explosion, transform.position);
                explosionParticle.SetActive(true);
                //hasBeenHit = true;
                Destroy(trig.gameObject);
            }
            else if (trig.gameObject.tag == "Leaf")
            {
                //ViviScore.playerscore += 20;
                //Targets.targetsHit++;
                //targetLeaf.SetActive(true);
                AudioSource.PlayClipAtPoint(leaves, transform.position);
                leafParticle.SetActive(true);
                //hasBeenHit = true;
                Destroy(trig.gameObject);
            }

    }
}
