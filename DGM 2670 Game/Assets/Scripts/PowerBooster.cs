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
       if (powerState == PowerStates.Normal)
       {
           Normal();
       } else if (powerState == PowerStates.Fast)
       {
           Fast();
       } else if (powerState == PowerStates.Slow)
       {
           Slow();
       } else if (powerState == PowerStates.Stop)
       {
           Stop();
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
