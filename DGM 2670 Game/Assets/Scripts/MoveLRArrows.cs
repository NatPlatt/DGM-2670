using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class MoveLRArrows : ScriptableObject, IMove
{
    public Vector3 location { get; set; }

    public void Move(CharacterController controller)
    {
        location.Set(Input.GetAxis("Horizontal"), 0, 0);
        controller.Move(location);
    }
}
