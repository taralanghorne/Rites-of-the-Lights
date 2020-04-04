using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RitesLoseLevel : MonoBehaviour
{
    public GameObject loseText;
    public string levelToLoad;

    private void Update()
    {
        if (ViviHealth.lose == true)
        {
            Debug.Log("lose text");
            loseText.SetActive(true);
            StartCoroutine(Lose());
        }
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(3);
        //SceneManager.LoadScene(4);
        SceneManager.LoadScene(levelToLoad);
    }
}
