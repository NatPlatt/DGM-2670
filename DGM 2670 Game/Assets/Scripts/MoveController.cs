using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveController : MonoBehaviour
{
    private CharacterController controller;
    public ScriptableObject mover;
    private IMove IMover;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        IMover = mover as IMove;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
