using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveAfterInterval : MonoBehaviour
{
    public GameObject item;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Activate");
    }

    private IEnumerator Activate()
    {
        yield return new WaitForSeconds(5);
        item.SetActive(true);
    }
}
