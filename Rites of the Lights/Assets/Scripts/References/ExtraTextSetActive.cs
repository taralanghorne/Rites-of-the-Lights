using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraTextSetActive : MonoBehaviour
{
    public GameObject extraText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GemChange2A.traded == true)
        {
            extraText.SetActive(true);
        }
    }
}
