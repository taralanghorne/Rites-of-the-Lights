using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChilumenFly : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject followR;
    public GameObject followL;
    public GameObject player;
    public GameObject chilumen;
    public Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        if (ViviMove.isLeft)
        {
            transform.position = Vector2.MoveTowards(transform.position, followR.transform.position, step);
        }else if (ViviMove.isRight)
        {
            transform.position = Vector2.MoveTowards(transform.position, followL.transform.position, step);
        }

        if (player.transform.position.x < chilumen.transform.position.x)
        {
            chilumen.GetComponent<SpriteRenderer>().flipX = true;
        }else if (player.transform.position.x > chilumen.transform.position.x)
        {
            chilumen.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
