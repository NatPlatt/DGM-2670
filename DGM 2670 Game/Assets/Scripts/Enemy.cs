
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1f;
    public CharacterController character;
    private Vector3 movement;
    
    void Start()
    {
        character = GetComponent<CharacterController>();

        MoveWithArrows.MoveArrows += MoveEnemy;
        MoveWithArrows.RotateArrows += RotateEnemy;
    }

    public void StopMoving()
    {
        MoveWithArrows.MoveArrows -= MoveEnemy;
        MoveWithArrows.RotateArrows -= RotateEnemy;
    }

    public void MoveEnemy(float myInput)
    {
        movement.z = myInput;
        movement = transform.TransformDirection(movement*speed*Time.deltaTime);

        character.Move(movement);
    }

    void RotateEnemy(float myInput)
    {
        transform.Rotate(0, myInput,0);
    }
    private void Update()
    {
        //MoveEnemy (Input.GetAxis("Horizontal"));
        //RotateEnemy (Input.GetAxis("Vertical"));
    }
}
