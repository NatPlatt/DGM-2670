using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anthony : MonoBehaviour
{
    public GameAction gameActionObj;

    public void Yell()
    {
        Debug.Log("Anthony");
    }

    public void Awake()
    {
        
    }

    void Start()
    {
       gameActionObj.Raise();
    }

    
}
