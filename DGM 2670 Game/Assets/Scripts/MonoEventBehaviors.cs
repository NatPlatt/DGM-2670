﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehaviors : MonoBehaviour
{
    
    public UnityEvent StartEvent;
    void Start()
    {
        StartEvent.Invoke();
    }
}
