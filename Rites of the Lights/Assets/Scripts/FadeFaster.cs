using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeFaster : MonoBehaviour
{
    Image rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Image>();
        //Color c = rend.material.color;
        //c.a = 0f;
        //rend.material.color = c;
        startFading();

    }
    private void Update()
    {
    }

    IEnumerator FadeOutUI()
    {
        for (float f = 0f; f < 1.05f; f += 0.05f)
        {
            Color c = rend.color;
            c.a = f;
            rend.color = c;
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(0.2f);
        //gameObject.SetActive(false);
    }

    public void startFading()
    {
        StartCoroutine("FadeOutUI");
    }
}
