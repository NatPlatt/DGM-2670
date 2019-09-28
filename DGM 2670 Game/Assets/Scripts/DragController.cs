using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public static GameObject myDragSprite;
    private Vector3 startPosition;
    private float zDistance;
    private Vector3 touchOffset;
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (gameObject != null) myDragSprite = gameObject;
        startPosition = transform.position;
        zDistance = Mathf.Abs(startPosition.z - Camera.main.transform.position.z);
        touchOffset = startPosition - Camera.main.ScreenToWorldPoint
                          (new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistance));
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        {
            transform.position = Camera.main.ScreenToWorldPoint
                (new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistance));
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        myDragSprite = null;
        touchOffset = Vector3.zero;
    }
}
