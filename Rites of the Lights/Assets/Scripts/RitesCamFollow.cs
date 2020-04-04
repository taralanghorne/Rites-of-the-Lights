using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RitesCamFollow : MonoBehaviour
{
    public GameObject follow;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    // Use this for initialization
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float x = Mathf.Clamp(follow.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(follow.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x + 2, y, gameObject.transform.position.z);
    }
}
