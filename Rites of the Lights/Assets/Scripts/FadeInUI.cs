using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInUI : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        //StartCoroutine("FadeIn");
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("FadeIn2");
    }

    private IEnumerator FadeIn2()
    {
        Debug.Log("fading");
        Color tmp = gameObject.GetComponent<Image>().color;
        tmp.a = 0f;
        gameObject.GetComponent<Image>().color = tmp;
        float _progress = 0.0f;

        while (_progress < 1)
        {
            Color _tmpColor = gameObject.GetComponent<Image>().color;
            GetComponent<Image>().color = new Color(_tmpColor.r, _tmpColor.g, _tmpColor.b, Mathf.Lerp(tmp.a, 255, _progress)); //startAlpha = 0 <-- value is in tmp.a
            _progress += Time.deltaTime * 0.003f;
            yield return null;
        }
    }
}
