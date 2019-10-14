using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterMover : ScriptableObject
{
    public float moveSpeed = 10f, jumpSpeed = 30f, gravity = 3f;
    private CharacterController controller;
    private Vector3 position;
    
    public IntData jumpData;
    
    public void MoveCharacter(CharacterController controller)
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;

        if (Input.GetButtonDown("Jump") && jumpData.value < jumpData.maxValue)
        {
            position.y = jumpSpeed;
            jumpData.value++;
        }
        if (controller.isGrounded)
        {
            position.y = 0;
        }
        controller.Move(position * Time.deltaTime);
        
    }
}
