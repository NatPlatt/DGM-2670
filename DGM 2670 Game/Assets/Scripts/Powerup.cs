using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : ScriptableObject, IRun
{
    public void Run()
    {
        Debug.Log("powerup");
    }
}
