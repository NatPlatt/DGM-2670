using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ActionPractice : MonoBehaviour
{
    public Button addButton;
    private UnityAction myFirstAction;
    
    public Renderer myObj;
    
    void Start()
    {
        addButton = GetComponent<Button>();
        myObj = GetComponent<Renderer>();
        myFirstAction += myFunction;
    }

    void myFunction()
    {
        myObj.material.color = Color.cyan;
    }
}
