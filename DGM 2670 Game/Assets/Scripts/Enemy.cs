
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 2f;
    
    //private Transform target;
    //private int wavePointIndex = 0;
    public CharacterController character;
    private Vector3 movement;
    void Start()
    {
        //target = PathPoints.points[0];
        character = GetComponent<CharacterController>();
    }

    public void MoveEnemy(float myInput)
    {
        movement.x = moveSpeed * Input.GetAxis("Horizontal");
        movement.z = moveSpeed * Input.GetAxis("Vertical");
        movement = transform.forward * moveSpeed *Time.deltaTime;

        character.Move(movement);
    }

    void Rotate(float myInput)
    {
        
    }
    private void Update()
    {
        //Vector3 dir = target.position - transform.position;
        //transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        
        /*if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextPathPoint();
        }*/
        
        MoveEnemy(moveSpeed);
    }

   /* void GetNextPathPoint()
    {
        if (wavePointIndex >= PathPoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        
        wavePointIndex++;
        target = PathPoints.points[wavePointIndex];
    }*/
}
