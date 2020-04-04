using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSpeakerChange : MonoBehaviour
{
    private Animator anim;
    private Animator anim2;
    public GameObject npc;
    public GameObject npc2;

    // Start is called before the first frame update
    void Start()
    {
        anim = npc.GetComponent<Animator>();
        npc.GetComponent<Animator>().SetBool("IsTalking", false);
        anim2 = npc2.GetComponent<Animator>();
        npc2.GetComponent<Animator>().SetBool("IsTalking", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
