using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIWithNavMesh : MonoBehaviour, IRun
{
    private NavMeshAgent agent;
    public Transform player, destination;
    

    private void Start()
    {
        agent= GetComponent<NavMeshAgent>();
        destination = transform;
    }
    
    void Update()
    {
        agent.destination = player.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        destination = player;
        //could call an animation here
    }

    public float Speed { get; set; }

    public void Run()
    {
        
    }

    public void Run(float f)
    {
        throw new NotImplementedException();
    }
}
