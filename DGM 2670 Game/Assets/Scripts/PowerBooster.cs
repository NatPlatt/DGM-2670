using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBooster : MonoBehaviour
{
    public float speed = 1.0f;
   public enum PowerStates
   {
      Normal,
      Fast,
      Slow,
      Stop
   }

   public PowerStates powerState = PowerStates.Normal;

   private void Update()
   {
       switch (powerState)
       {
           case PowerStates.Normal:
               Normal();
               break;
           case PowerStates.Fast:
               Fast();
               break;
           case PowerStates.Slow:
               Slow();
               break;
           case PowerStates.Stop:
               Stop();
               break;
       }
   }

   public void Normal()
   {
       speed = 1f;
   }

   public void Fast()
   {
       speed = 5f;
   }

   public void Slow()
   {
       speed = 0.2f;
   }

   public void Stop()
   {
       speed = 0;
   }
}
