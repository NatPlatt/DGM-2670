using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodayne : MonoBehaviour
{
    public GameAction gameActionObj;

    void Talk()
    {
        Debug.Log("Rodayne");
    }

    public void Awake()
    {
        gameActionObj.action += Talk;
    }

    void Start()
    {
        
    }

    
}
