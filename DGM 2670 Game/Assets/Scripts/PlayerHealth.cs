using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerHealth : ScriptableObject, IRun
{
    public void Run()
    {
        Debug.Log("oh no my health");
    }

    public void Run(float f)
    {
        throw new System.NotImplementedException();
    }
}
