
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EventListening : MonoBehaviour
{
    private UnityEvent mouseClickEvent = new UnityEvent();
    public Object IRunObj;

    private void Start()
    {
       // mouseClickEvent.AddListener(MouseClick);
    }
    

    private void OnMouseDown()
    {
        mouseClickEvent.Invoke();
    }
}
