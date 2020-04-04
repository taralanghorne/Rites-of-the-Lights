using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemCount : MonoBehaviour
{
    public GameObject gemCount; // the gem counter
    public GameObject gemText;
    public static int gems = 50; // starting number of gems

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gemText.gameObject.GetComponent<Text>().text = ("" + gems);
    }
}
