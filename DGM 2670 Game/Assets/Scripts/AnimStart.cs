using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStart : MonoBehaviour
{
    public Animator anim;

    private bool isAnimated = false;

    public string animName;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            anim.enabled = true;
            //isAnimated = true;
        }
       /* else
        {
            isAnimated = false;
            
        }

        if (isAnimated == true)
        {
            //anim.SetBool(animName, true);
            anim.enabled = true;
        }

        if (isAnimated == false)
        {
            //anim.SetBool(animName, false);
            anim.enabled = false;
        }*/


    }

    /*private void OnMouseDown()
    {
        anim.enabled = true;
    }*/
}
