using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleCreate : MonoBehaviour
{
    public Transform enemy;
    void Start()
    {
        for (int i=0; i < 5; i++)
        {
            Instantiate(enemy, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }

    
}
