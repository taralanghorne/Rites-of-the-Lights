using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileY : MonoBehaviour
{
    [SerializeField] private float lifeTime = 2.0f;
    private int lifeTimeFrames = 0;
    private int timeLived = 0;


    [SerializeField] private float relativeVelocity = 1f;
    private float velocity = 0f;
    public float emitVelocity;

    void Start()
    {

        Launch();
        lifeTimeFrames = (int)(lifeTime / Time.fixedDeltaTime);
    }

    public void Launch()
    {
        
        velocity = emitVelocity + relativeVelocity;
        if (ViviMove.isRight)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * velocity;
        }else if (ViviMove.isLeft)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.left * velocity;
        }
    }
    void FixedUpdate()
    {
        if (timeLived < lifeTimeFrames)
        {
            timeLived++;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
