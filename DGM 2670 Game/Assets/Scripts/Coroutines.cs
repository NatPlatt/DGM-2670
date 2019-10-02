using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    private int jumpCount;
    private int jumpCountMax = 10;
    

    IEnumerator Start()
    {
        //yield return new WaitForSeconds(2);
       // print("ran");
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        while (jumpCount < jumpCountMax)
        {
            yield return new WaitForSeconds(2);
            transform.position += Vector3.forward;
            jumpCount++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
