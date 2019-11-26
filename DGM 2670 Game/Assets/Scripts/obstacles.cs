using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public Animation obstacleAnim;
    public Animator animController = ;
    private bool isTriggered = false;
    public void OnTriggerEnter(Collider other)
    {
        isTriggered = true;
        print("I am triggered");
        //obstacleAnim.Play();
        var animControllerEnabled = animController.enabled;
    }
}
