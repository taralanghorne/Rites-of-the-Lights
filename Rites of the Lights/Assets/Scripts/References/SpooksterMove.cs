﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpooksterMove : MonoBehaviour
{
    public int playerSpeed = 10;
    public int playerJumpPower = 1250;
    private float moveX;

    [Tooltip("Only change this if your character is having problems jumping when they shouldn't or not jumping at all.")]
    public float distToGround = 1.0f;
    private bool inControl = true;
    public AudioClip jumping;

    [Tooltip("Everything you jump on should be put in a ground layer. Without this, your player probably* is able to jump infinitely")]
    public LayerMask GroundLayer;

    public static bool isRight;
    public static bool isLeft;
    public GameObject player;
    public bool isJump = false;

    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "2-SCENE ONE")
        {
            isRight = true;
            isLeft = false;
        } else if (currentScene.name == "3-SCENE TWO")
        {
            isRight = false;
            isLeft = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inControl)
        {
            PlayerMove();
        }
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            player.GetComponent<Animator>().SetBool("IsJumping", true);
            player.GetComponent<Animator>().SetBool("IsRunning", false);
        }
        else if (!isJump)
        {
            player.GetComponent<Animator>().SetBool("IsJumping", false);
        }
        if (!IsGrounded()) {
            isJump = true;
        }
        else
        {
            isJump = false;
        }

    }

    void PlayerMove()
    {
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }

        //ANIMATIONS
        if (moveX != 0 && !isJump)
        {
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
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        AudioSource.PlayClipAtPoint(jumping, transform.position);
    }

    public bool IsGrounded()
    {
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
