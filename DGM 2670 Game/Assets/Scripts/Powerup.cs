using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Powerup : ScriptableObject, IRun, ITest
{
    public void Run()
    {
        Debug.Log("powerup");
    }

    public void Run(float f)
    {
        
    }


    public void Test()
    {
        Debug.Log("powerup test");
    }
}
