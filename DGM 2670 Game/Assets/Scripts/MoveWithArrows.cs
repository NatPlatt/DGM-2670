using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveWithArrows : MonoBehaviour
{
    public static Action<float> MoveArrows;
    public static Action<float> RotateArrows;
    
    void Update()
    {
        if (MoveArrows != null)
            MoveArrows(Input.GetAxis("Vertical"));
            print("i should be moving");
        if (RotateArrows != null)
            RotateArrows(Input.GetAxis("Horizontal"));
            print("I should be rotating");
    }
}
