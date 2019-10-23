using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveHVArrows : ScriptableObject, IMove
{
    public Vector3 location { get; set; }
    public ScriptableObject mover;
    private IMove IMover;

    public void Move(CharacterController controller)
    {
        Debug.Log(name);
    }
}
