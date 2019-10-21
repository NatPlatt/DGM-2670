
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EventListening : MonoBehaviour, IListen
{
    public Object IRunObj;
    
    public IRun NewIRunObj { get; set; }

    public void Start()
    {
        NewIRunObj = IRunObj as IRun; 
       Event.AddListener(NewIRunObj.Run);
    }

    public UnityEvent Event { get; set; }
    
    private void OnMouseDown()
    {
        Event.Invoke();
        Event.RemoveListener(NewIRunObj.Run);
    }
}
