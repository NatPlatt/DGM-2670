using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickAnims : MonoBehaviour
{
    public Animator animator;
    public ScriptableObject scriptObj;
    public Animation animation;
    
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        //animation = gameObject.GetComponent<Animation>();
    }

    void OnClick()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.Play("littleBoyPage1");
            Debug.Log("little boy is animating");
        }
    }
}
