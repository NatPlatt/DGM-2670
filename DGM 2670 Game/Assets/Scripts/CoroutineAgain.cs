using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineAgain : MonoBehaviour
{
   private WaitForSeconds wfs;
   public float holdTime = 0.1f;
   public bool canRun = true;
   public UnityEvent OnRunEvent;
   
   private void Awake()
   {
      wfs = new WaitForSeconds(holdTime);
   }

   private IEnumerator OnStart()
   {
      while (canRun)
      {
         print("Run");
         OnRunEvent.Invoke();
         yield return wfs;
      } 
   }
}
