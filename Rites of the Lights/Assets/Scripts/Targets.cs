using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Targets : MonoBehaviour
{
    public static int targetsHit; // score--needs to be static to carry over between levels
    public GameObject targetsUI;
    public int targetsToHit = 7;
    public static bool targetsAreHit = false;

    // Start is called before the first frame update
    void Start()
    {
        //targetsAreHit = false;
    }

    // Update is called once per frame
    void Update()
    {
        targetsUI.gameObject.GetComponent<Text>().text = (targetsHit + " / " + targetsToHit);

        if (targetsHit == targetsToHit)
        {
            targetsAreHit = true;
        }
    }
}
