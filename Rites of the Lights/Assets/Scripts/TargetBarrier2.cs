﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBarrier2 : MonoBehaviour
{
    bool hasBeenHit = false;
    public GameObject target;
    public GameObject targetChar;
    public GameObject targetLeaf;
    public AudioClip explosion;
    public AudioClip leaves;
    public AudioClip wrong;
    public ParticleSystem explosionParticle;
    public GameObject leafParticle;
    public GameObject control;
    public GameObject dialogue;
    public GameObject barrier;

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
        if (!hasBeenHit)
        {
            if (trig.gameObject.tag == "Zap")
            {
                //ViviScore.playerscore += 20;
                //Targets.targetsHit++;
                //targetChar.SetActive(true);
                AudioSource.PlayClipAtPoint(wrong, transform.position);
                AudioSource.PlayClipAtPoint(leaves, transform.position);
                explosionParticle.Play();
                //hasBeenHit = true;
                //dialogue.SetActive(true);
                //barrier.SetActive(false);
                Destroy(trig.gameObject);
            }
            else if (trig.gameObject.tag == "Leaf")
            {
                ViviScore.playerscore += 20;
                Targets.targetsHit++;
                targetLeaf.SetActive(true);
                AudioSource.PlayClipAtPoint(leaves, transform.position);
                leafParticle.SetActive(true);
                hasBeenHit = true;
                dialogue.SetActive(true);
                control.SetActive(false);
                barrier.SetActive(false);
                Destroy(trig.gameObject);
            }
        }

    }
}
