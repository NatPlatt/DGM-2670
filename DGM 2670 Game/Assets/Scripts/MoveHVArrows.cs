using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveHVArrows : ScriptableObject, IMove
{
    public Vector3 location { get; set; }

    public void Move(CharacterController controller)
    {
        Debug.Log(name);
    }
}
