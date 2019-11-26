using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public Animation obstacleAnim;
    public Animator animController;
    public void OnTriggerEnter(Collider other)
    {
        //obstacleAnim.Play();
        var animControllerEnabled = animController.enabled;
    }
}
