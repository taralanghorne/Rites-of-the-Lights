using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStart : MonoBehaviour
{
    public GameObject playerPause;

    // Start is called before the first frame update
    void OnEnable()
    {
        playerPause.GetComponent<ViviPauseControl>().PlayerPause();
    }

    // Update is called once per frame
    void Update()
    {
        //playerPause.GetComponent<ViviPauseControl>().PlayerPause();
    }
}
