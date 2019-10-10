using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleBoyAnim : MonoBehaviour
{
    public GameAction gameActionObj;

    private void OnMouseDown()
    {
        gameActionObj.Raise();
    }
}
