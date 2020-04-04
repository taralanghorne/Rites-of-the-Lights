using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishCounter : MonoBehaviour
{
    public GameObject fishCount; // the gem counter
    public GameObject fishText;
    public static int fish = 0; // starting number of fish

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(fish != 0)
        {
            fishCount.SetActive(true);
        }else if (fish == 0)
        {
            fishCount.SetActive(false);
        }

        fishText.gameObject.GetComponent<Text>().text = ("" + fish);
    }
}
