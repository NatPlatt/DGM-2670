using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    public Vector3 location;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        print("ran");
        transform.position += location;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
