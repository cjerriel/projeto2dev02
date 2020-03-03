using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class CreepController : MonoBehaviour
{
    NavMeshAgent angent;

    public GameObject finalTarget;

     void Awake()
    {
        angent = GetComponent <NavMeshAgent>();
        
    }

   
    void Start()
    {
        if (finalTarget != null)
        {
            angent.SetDestination(finalTarget.transform.position);
        }
    }
}
