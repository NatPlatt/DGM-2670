using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public FloatData data;
    
    public UnityEvent triggerEnterEvents, triggerStayEvent;
    private void OnTriggerEnter(Collider other)
    {
        data.UpdateValue(-.1f);
        triggerEnterEvents.Invoke();
    }

   /* private void OnTriggerStay(Collider other)
    {
        triggerStayEvent.Invoke();
    }*/
}
