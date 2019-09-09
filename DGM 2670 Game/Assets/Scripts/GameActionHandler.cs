using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public GameAction gameActionObj;
    public UnityEvent handlerEvent;
    void Start()
    {
        gameActionObj.action += Action;
    }

    private void Action()
    {
        handlerEvent.Invoke();
    }
}
