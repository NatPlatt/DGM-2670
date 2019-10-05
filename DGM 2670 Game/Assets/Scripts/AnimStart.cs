using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStart : MonoBehaviour
{
    public Animator anim;
    public WaitForSeconds wfs;
    private float holdTime = .1f;

    private void Awake()
    {
        wfs = new WaitForSeconds(holdTime);
    }

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
        }

        
    }

    /*private void OnMouseDown()
    {
        anim.enabled = true;
    }*/
}
