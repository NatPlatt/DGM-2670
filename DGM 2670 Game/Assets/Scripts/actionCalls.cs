using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionCalls : MonoBehaviour
{
    public float speed = 1f;
    public float rotateSpeed = 10f;
    private Vector3 location;
    private Vector3 rotations;
    
    void Update()
    {
        OnMove();
        OnRotate();
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
}
