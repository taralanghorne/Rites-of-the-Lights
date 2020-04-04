using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ViviMove : MonoBehaviour
{
    public int playerSpeed = 10;
    public int playerJumpPower = 1250;
    public static float moveX;

    [Tooltip("Only change this if your character is having problems jumping when they shouldn't or not jumping at all.")]
    public float distToGround = 1.0f;
    public static bool inControl = true;
    //public AudioClip jumping;

    [Tooltip("Everything you jump on should be put in a ground layer. Without this, your player probably* is able to jump infinitely")]
    public LayerMask GroundLayer;

    public static bool isRight;
    public static bool isLeft;
    public GameObject player;
    public static bool isJump = false;

    public GameObject attackR;
    public GameObject attackL;
    public GameObject attacker;

    public AudioClip jump;
    //public AudioClip land;

    private void Start()
    {
        isRight = true;
        /*Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "2-SCENE ONE")
        {
            isRight = true;
            isLeft = false;
        }
        else if (currentScene.name == "3-SCENE TWO")
        {
            isRight = false;
            isLeft = true;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (inControl)
        {
            PlayerMove();
        }
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Debug.Log("jump");
            isJump = true;
            AudioSource.PlayClipAtPoint(jump, transform.position);
            player.GetComponent<Animator>().SetBool("IsJumping", true);
            player.GetComponent<Animator>().SetBool("IsRunning", false);
        }
        /*else if (!isJump)
        {
            player.GetComponent<Animator>().SetBool("IsJumping", false);
        }*/
        if (!IsGrounded())
        {
            isJump = true;
            player.GetComponent<Animator>().SetBool("IsJumping", true);
            player.GetComponent<Animator>().SetBool("IsRunning", false);
        }
        else
        {
            isJump = false;
            player.GetComponent<Animator>().SetBool("IsJumping", false);
            /*if (ViviAttack.AttackY || ViviAttack.AttackP)
            {
                Debug.Log("stop");
                inControl = false;
            }
            else if (!ViviAttack.AttackY && !ViviAttack.AttackP)
            {
                Debug.Log("go");
                inControl = true;
            }*/
        }

        if (isRight)
        {
            attacker.transform.position = attackR.transform.position;
        } else if (isLeft)
        {
            attacker.transform.position = attackL.transform.position;
        }

    }

    void PlayerMove()
    {
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            //Debug.Log("Space");
            Jump();
        }

        //ANIMATIONS
        if (moveX != 0 && !isJump)
        {
            Debug.Log("moving");
            player.GetComponent<Animator>().SetBool("IsRunning", true);
        }
        else
        {
            player.GetComponent<Animator>().SetBool("IsRunning", false);
        }

        //PLAYER DIRECTION
        if (moveX < 0.0f)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            Debug.Log("flipping");
            isRight = false;
            isLeft = true;
        }
        else if (moveX > 0.0f)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            Debug.Log("flipping false");
            isRight = true;
            isLeft = false;
        }

        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        //JUMPING CODE
        isJump = true;
        Debug.Log("jump");
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
       // AudioSource.PlayClipAtPoint(jumping, transform.position);
    }

    public bool IsGrounded()
    {
        //Debug.Log("ground");
        isJump = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distToGround, GroundLayer);
        if (hit.collider != null)
        {
            return true;
        }
        return false;

    }

    public void SetControl(bool b)
    {
        inControl = b;
    }
}
