using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmbraAreaTrigger : MonoBehaviour
{
    public bool InRange = false;
    bool exited = true;
    public GameObject umbraFollow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (umbraFollow.GetComponent<UmbraFlyingFollow>().alerted)
        {
            InRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            InRange = false;
        }
    }
}
