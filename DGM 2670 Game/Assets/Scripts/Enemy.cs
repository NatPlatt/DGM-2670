
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;

    private Transform target;
    private int wavePointIndex = 0;
    public CharacterController controller;
    private Vector3 position;
    void Start()
    {
        target = PathPoints.points[0];
        controller = GetComponent<CharacterController>();
    }

    public void MoveEnemy(CharacterController controller)
    {
        position.x = speed * Input.GetAxis("Horizontal");
        position.z = speed * Input.GetAxis("Vertical");
    }
    private void Update()
    {
        //Vector3 dir = target.position - transform.position;
        //transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        controller.Move(position * Time.deltaTime);
        /*if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextPathPoint();
        }*/
    }

    void GetNextPathPoint()
    {
        if (wavePointIndex >= PathPoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        
        wavePointIndex++;
        target = PathPoints.points[wavePointIndex];
    }
}
