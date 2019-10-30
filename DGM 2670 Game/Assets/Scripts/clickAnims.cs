using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickAnims : MonoBehaviour
{
    public Animator animator;
    public ScriptableObject scriptObj;
    
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Active");
        }
    }
}
