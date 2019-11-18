using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Mover : ScriptableObject
{
    public GameObject player;
    public int speed = 1;
    
    public void MoveIt()
    {
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0 , (Input.GetAxis("Vertical") )) ;

        player.transform.position = Movement * speed * Time.deltaTime;
    }
}
