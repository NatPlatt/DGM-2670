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
    
    void Update()
    {
        OnMove();
        OnRotate();
        OnScale();
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
