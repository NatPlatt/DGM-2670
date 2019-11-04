using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anthony : MonoBehaviour
{
    public Marty santa;
    public Rodayne larry;

    public void Yell()
    {
        Debug.Log("Anthony");
    }
    void Start()
    {
        larry.talk();
        Marty.FMinus();
    }

    
}
