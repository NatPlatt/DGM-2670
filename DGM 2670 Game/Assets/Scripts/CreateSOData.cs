using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSOData : MonoBehaviour
{
    public IntData data;
    private IntData newData;
    void Start()
    {
        newData = Instantiate(data);
    }
    
}
