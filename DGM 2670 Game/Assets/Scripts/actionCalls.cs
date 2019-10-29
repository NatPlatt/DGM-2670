using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class actionCalls : MonoBehaviour
{
    public float speed = 1f, rotateSpeed = 10f, scaleSpeed = 0.2f;
    private Vector3 location, rotations, scales;
    private UnityAction TransformAction;
    public GameAction gameActionObj;

   /* private void Start()
    {
        TransformAction = OnMove;
    }*/
    private void OnMouseDown()
    {
        gameActionObj.Raise();
        print("Character is animating");
    }
        
        /*if (TransformAction == OnMove)
        {
            TransformAction = OnRotate;
        }
        else if (TransformAction == OnRotate)
        {
            TransformAction = OnScale;
        } 
        else if (TransformAction == OnScale)
        {
            TransformAction = OnMove;
        }
    }

    void Update()
    {
        TransformAction();
    }
    public void OnMove()
    {
        location.x = speed * Time.deltaTime;
        transform.Translate(location);
    }

    public void OnRotate()
    {
        rotations.y = rotateSpeed * Time.deltaTime;
        transform.Rotate(rotations);
    }

    public void OnScale()
    {
        scales.Set(scaleSpeed,scaleSpeed,scaleSpeed);
        transform.localScale += scales;
    }*/
}
