using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collections : ScriptableObject
{
    public List<Object> ObjectList;
    public List<FloatData> FloatDatas;
    public List<GameObject> GameObjects;


    public void FindObjectType(Object obj)
    {
        foreach (var currentObj in ObjectList)
        {
            if (currentObj == obj)
            {
                //Do work
                //could instantiate, add to collection, call something
            }
        }
    }

    public void AddToList(Object obj)
    {
        ObjectList.Add(obj);
    }

    public void RemoveFromList(Object obj)
    {
       foreach (var currentObj in ObjectList)
               {
                   if (currentObj == obj)
                   {
                       ObjectList.Remove(obj);
                   }
               }
    }
    
}
