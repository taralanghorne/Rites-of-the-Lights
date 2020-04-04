﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject launcher;
    public GameObject ball;
    float ballSpeed = 15f;
    public GameObject spawner;
    public void goUP()
    {
        launcher.transform.Rotate(Vector3.left * 5);
    }
    public void goDOWN(){
        launcher.transform.Rotate(Vector3.right * 5);
    }
    public void goLEFT(){
        launcher.GetComponent<Rigidbody>().AddForce(-30.0f, 0, 0);
    }
    public void goRIGHT()
    {
        launcher.GetComponent<Rigidbody>().AddForce(30.0f, 0, 0);
    }
    public void ThrowTheBall(){
        GameObject theBall = (GameObject)Instantiate(ball, spawner.transform.position + spawner.transform.forward, spawner.transform.rotation);
        theBall.GetComponent<Rigidbody>().AddForce(spawner.transform.forward * ballSpeed, ForceMode.Impulse);
    }
}
