﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Powerup : ScriptableObject, IRun
{
    public void Run()
    {
        Debug.Log("powerup");
    }
}
