using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViviPauseControl : MonoBehaviour
{
    public GameObject player;
    public UmbraFollowFlat[] dogenemies;
    public UmbraFlyingFollow[] birdenemies;
    public static bool enemiesPaused;

    // Start is called before the first frame update
    void Awake()
    {
        //finds each enemy, so we can disable and enable their patrols during pause
        GameObject[] denemies = GameObject.FindGameObjectsWithTag("DogFollow");
        dogenemies = new UmbraFollowFlat[denemies.Length];
        for (int i = 0; i < denemies.Length; ++i)
        {
            dogenemies[i] = denemies[i].GetComponent<UmbraFollowFlat>();
        }
        //finds each enemy, so we can disable and enable their patrols during pause
        GameObject[] benemies = GameObject.FindGameObjectsWithTag("BirdFollow");
        birdenemies = new UmbraFlyingFollow[benemies.Length];
        for (int i = 0; i < benemies.Length; ++i)
        {
            birdenemies[i] = benemies[i].GetComponent<UmbraFlyingFollow>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerPause()
    {
        ViviMove.inControl = false;
        ViviAttack.inControlAttack = false;
        //ViviMove.moveX = 0;
        player.GetComponent<Animator>().SetBool("IsRunning", false);
        player.GetComponent<Animator>().SetBool("IsJumping", false);

        foreach (UmbraFollowFlat script in dogenemies)
        {
            script.enabled = false;
        }

        foreach (UmbraFlyingFollow script in birdenemies)
        {
            script.enabled = false;
        }
    }

    public void PlayerResume()
    {
        ViviMove.inControl = true;
        ViviAttack.inControlAttack = true;

        foreach (UmbraFollowFlat script in dogenemies)
        {
            script.enabled = true;
        }

        foreach (UmbraFlyingFollow script in birdenemies)
        {
            script.enabled = true;
        }
    }
}
