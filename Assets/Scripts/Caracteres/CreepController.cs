using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class CreepController : MonoBehaviour
{
    NavMeshAgent angent;

    GameObject finalTarget;

     void Awake()
    {
        angent = GetComponent <NavMeshAgent>();
        GameObject obj = GameObject.FindWithTag("Finish");
        if (obj != null)
        {
            finalTarget = obj;
        }
        
    }

   
    void Start()
    {
        if (finalTarget != null)
        {
            angent.SetDestination(finalTarget.transform.position);
        }
    }
}
