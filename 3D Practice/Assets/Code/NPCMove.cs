using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour
{
    public List<Transform> _destination;

    NavMeshAgent _navMeshAgent;
    int targetIndex;


    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        targetIndex = 0;
    }


    void Update()
    {
        Vector3 targetVector = _destination[targetIndex].transform.position;
        _navMeshAgent.SetDestination(targetVector);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (targetIndex < 2)
            {
                targetIndex += 1;
            } else
            {
                targetIndex = 0;
            }
            
        }
    }
}