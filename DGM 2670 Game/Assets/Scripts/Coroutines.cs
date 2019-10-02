using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    private int jumpCount;
    public float jumpCountMax = 1;
    public float waitTime = 0.1f;

    IEnumerator OnMouseDown()
    {
        //yield return new WaitForSeconds(2);
       // print("ran");
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        while (jumpCount < jumpCountMax)
        {
            yield return new WaitForSeconds(waitTime);
            transform.position += Vector3.left;
            jumpCount++;
        }

        jumpCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
