using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;
    public float horizontalInput;
    public float forwardInput;
    public float xRange = 7;
    public GameObject playerObj;
    //public Color redColor;
    
    delegate void MultiDelegate();

    private MultiDelegate myMulti;
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRange){ transform.position = new Vector3(xRange, transform.position.y, transform.position.z);}
        if (transform.position.x < -xRange){transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);}
        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
        
    }

    /*private void Start()
    {
        myMulti += TurnRed;
        
        if (myMulti != null)
        {
            myMulti();
        }
    }

    void TurnRed()
    {
       
    }
   private void OnTriggerEnter(Collider other)
    {
        playerObj.GetComponent<Color>();
    }*/
}
