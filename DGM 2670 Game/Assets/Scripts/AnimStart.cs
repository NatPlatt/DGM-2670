using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStart : MonoBehaviour
{
    public Animator anim = null;

    //private bool isAnimated = false;
    //public GameObject character = null;
    //public string animName;
    public GameAction gameActionObj;
    
   /* private void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }*/

    private void OnMouseDown()
    {
        gameActionObj.Raise();
    }

    /*private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.enabled = true;

            /*Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider coll = character.GetComponent<Collider>();
            
            if (coll.OverlapPoint(pos))
            {anim.enabled = true;}*/
            //isAnimated = true;
        
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
