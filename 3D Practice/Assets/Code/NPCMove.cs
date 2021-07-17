using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour
{
    public List<GameObject> enemies;

    NavMeshAgent _navMeshAgent;
    GameObject target = null;


    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        //targetIndex = 0;
    }


    void Update()
    {
        if (target is null)
        {
            target = findClosestEnemy(enemies);
        }
        if (target != null)
        {
            _navMeshAgent.SetDestination(target.transform.position);
        }
        

        /*
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
        */
    }

    GameObject findClosestEnemy(List<GameObject> enemies)
    {
        GameObject nearestEnemy = null;
        float minDistance = Mathf.Infinity;
        Vector3 currPos = transform.position;
        foreach (GameObject enemy in enemies)
        {
            if (enemy.activeSelf)
            {
                float distance = Vector3.Distance(enemy.transform.position, currPos);
                if (distance < minDistance)
                {
                    nearestEnemy = enemy;
                    minDistance = distance;
                }
            }
        }
        return nearestEnemy;
    }
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        if (other.gameObject == target)
        {
            target = null;
        }
    }
}