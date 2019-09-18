using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class eventsWithArgs : MonoBehaviour
{
    public UnityEvent<float> eventWithFloat;
    
    void Start()
    {
        
        eventWithFloat.AddListener(PassFloat);
    }

    public void PassFloat(float number)
    {
        print(number);
    }
    
    void Update()
    {
        eventWithFloat.Invoke(10);
    }
}
