using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class PlayerController : MonoBehaviour
{
    NavMeshAgent angent;
    public LayerMask walkableLayer;
    Camera cam;

    void Awake()
    {
        angent = GetComponent <NavMeshAgent>();
        cam = Camera.main;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, Mathf.Infinity, walkableLayer))
            {
                angent.SetDestination(hit.point);
            }
        }
    }
}
