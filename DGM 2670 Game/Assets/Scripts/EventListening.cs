
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EventListening : MonoBehaviour
{
    private UnityEvent mouseClickEvent = new UnityEvent();
    public Object IRunObj;
    public IRun newIRunObj;

    private void Start()
    {
       
       newIRunObj = IRunObj as IRun; 
       mouseClickEvent.AddListener(newIRunObj.Run);
    }
    

    private void OnMouseDown()
    {
        mouseClickEvent.Invoke();
        mouseClickEvent.RemoveListener(newIRunObj.Run);
    }
}
