using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
   private Vector3 offsetPos;
   private float mouseZpos;
   
   public Camera camera;
   
   public bool canDrag { get; set; }

   private void Start()
   {
      camera = Camera.main;
   }

   private void OnMouseDown()
   {
      canDrag = true;
      mouseZpos = camera.WorldToScreenPoint(gameObject.transform.position).z;
      offsetPos = gameObject.transform.position - GetMouseWorldPos();
   }

   private Vector3 GetMouseWorldPos()
   {
      Vector3 mousePoint = Input.mousePosition;
      mousePoint.z = mouseZpos;
      return camera.ScreenToWorldPoint(mousePoint);
   }

   private void OnMouseDrag()
   {
      transform.position = GetMouseWorldPos() + offsetPos;
   }
}
