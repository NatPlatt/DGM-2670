using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Object = System.Object;

public class TriggerEventListener : MonoBehaviour, IListen
{
    public IRun NewIRunObj { get; set; }
    public Object IRunObj;
    public void Start()
    {
        Event = new UnityEvent();
        NewIRunObj = IRunObj as IRun; 
        Event.AddListener(NewIRunObj.Run);
    }

    public UnityEvent Event { get; set; }

    private void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
        Event.RemoveListener(NewIRunObj.Run);
    }
}
