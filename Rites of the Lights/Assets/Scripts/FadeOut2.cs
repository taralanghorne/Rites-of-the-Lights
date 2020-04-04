using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut2 : MonoBehaviour
{
    SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        //Color c = rend.material.color;
        //c.a = 0f;
        //rend.material.color = c;
        startFading();

    }
    private void Update()
    {
    }

    IEnumerator FadeOut()
    {
        for (float f = 1f; f >= -0.05f; f -= 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void startFading()
    {
        StartCoroutine("FadeOut");
    }

}
