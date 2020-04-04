using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickFadeOutAdjustable : MonoBehaviour
{
    public GameObject fade;
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public string levelToLoad;
    public float interval;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void End()
    {
        StartCoroutine("EndLevel");
        fade.SetActive(true);
        //newText.SetActive(true); // makes new text/buttons appear
        pastText.SetActive(false); // makes old text/buttons disappear
    }

    IEnumerator EndLevel()
    {
        yield return new WaitForSeconds(interval);
        //Debug.Log("new scene");
        SceneManager.LoadScene(levelToLoad);
    }
}
