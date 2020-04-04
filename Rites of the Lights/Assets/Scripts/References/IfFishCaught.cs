using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfFishCaught : MonoBehaviour
{
    public GameObject choice2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FishCounter.fish == 1)
        {
            choice2.SetActive(true);
        }
    }
}
