﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RitesCheckpoints : MonoBehaviour
{
    // Attach this to your checkpoints. Checkpoints should have a collider set to trigger.
    // If you want to make a sprite animate on activating the checkpoint, let me know! It shouldn't be too hard to program.
    //public GameObject respawn;
    public bool activated = false;
    //public GameObject checkpoint;
    //public Material activeMat;
    public GameObject lightUp;
    public AudioClip activate;
    public GameObject checkpointDialogue;

    void Start()
    {
        //respawn = GameObject.FindGameObjectWithTag("Respawn");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!activated)
        {
            if (collision.CompareTag("Player"))
            {
                Debug.Log("Activated");
                AudioSource.PlayClipAtPoint(activate, transform.position);
                checkpointDialogue.SetActive(true);
                //GetComponent<Renderer>().material = activeMat;
                lightUp.SetActive(true);
                //animate?
                ViviHealth.lastCheck = transform.position;
                activated = true;
                StartCoroutine(DialogueOff());
            }
        }
    }

    IEnumerator DialogueOff()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("dialogue off");
        checkpointDialogue.SetActive(false);
    }
}
