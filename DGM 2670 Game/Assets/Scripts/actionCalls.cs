using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionCalls : MonoBehaviour
{
    public float speed = 1f, rotateSpeed = 10f, scaleSpeed = 0.2f;
    private Vector3 location, rotations, scales;
    
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
                break;
            case TransformStates.Rotate:
                transformState = TransformStates.Scale;
                break;
            case TransformStates.Scale:
                transformState = TransformStates.Move;
                break;
        }
    }

    void Update()
    {
        switch (transformState)
        {
            case TransformStates.Move:
                OnMove();
                break;
            case TransformStates.Rotate:
                OnRotate();
                break;
            case TransformStates.Scale:
                OnScale();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
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
