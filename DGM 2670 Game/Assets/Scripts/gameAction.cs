using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject

{
    public UnityAction action;
    public UnityAction<Transform> transformAction;

    public void Raise()
    {
        if (action != null)
        {
            action();
        }
     
    }

    public void Raise(Transform transformObj)
    {
        transformAction.Invoke(transformObj);
    }
}
