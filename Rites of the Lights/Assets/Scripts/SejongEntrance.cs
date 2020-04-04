using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SejongEntrance : MonoBehaviour
{
    public GameObject front;
    public GameObject insides;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            front.SetActive(false);
            insides.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            front.SetActive(true);
            insides.SetActive(false);
        }
    }
}
