using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : ScriptableObject, IRun
{
    public void Run()
    {
        Debug.Log("oh no my health");
    }
}
