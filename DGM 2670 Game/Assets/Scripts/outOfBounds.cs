using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float lowerBound = -2;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
