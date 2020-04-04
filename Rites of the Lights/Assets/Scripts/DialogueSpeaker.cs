using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSpeaker : MonoBehaviour
{
    private Animator anim;
    public GameObject npc;

    // Start is called before the first frame update
    void OnEnable()
    {
        anim = npc.GetComponent<Animator>();
        npc.GetComponent<Animator>().SetBool("IsTalking", true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
