using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public GameObject Animation;
    public string animName;
    public Animator animController;
    private bool isTriggered = false;

    private void Start()
    {
        Animation = GetComponent<GameObject>();
    }

    public void OnTriggerEnter(Collider other)
    {
        
        print("I am triggered");
        IsAnimating();
        
    }

    public void IsAnimating()
    {
        //Animator.Instantiate(Animation); need to fix
    }
}
