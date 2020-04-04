using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Look : MonoBehaviour
{
    public GameObject player;
    public GameObject npc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x < npc.transform.position.x)
        {
            npc.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (player.transform.position.x > npc.transform.position.x)
        {
            npc.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
