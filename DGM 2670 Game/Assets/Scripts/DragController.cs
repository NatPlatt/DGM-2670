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
    }

    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
