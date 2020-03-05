using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using NavGame.Core;
[RequireComponent(typeof(NavMeshAgent))]

public class CreepController : CombatGameobject
{
    NavMeshAgent angent;

    GameObject finalTarget;

     protected override void Awake()
    {
        base.Awake();
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
