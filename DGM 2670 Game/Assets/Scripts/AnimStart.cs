using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStart : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    private void OnMouseDown()
    {
        anim.enabled = true;
    }
}
