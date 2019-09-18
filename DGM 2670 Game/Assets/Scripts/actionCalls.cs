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

    private void Start()
    {
        TransformAction = OnMove;
    }

    public enum TransformStates
    {
        Move,
        Rotate,
        Scale
    }

    public TransformStates transformState;

    private void OnMouseDown()
    {
        switch (transformState)
        {
            case TransformStates.Move:
                transformState = TransformStates.Rotate;
                TransformAction = OnRotate;
                break;
            case TransformStates.Rotate:
                transformState = TransformStates.Scale;
                TransformAction = OnScale;
                break;
            case TransformStates.Scale:
                transformState = TransformStates.Move;
                TransformAction = OnMove;
                break;
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
    }
}
