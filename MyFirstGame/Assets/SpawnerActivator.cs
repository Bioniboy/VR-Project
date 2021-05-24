using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnerActivator : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    
    void Start()
    {

    }

    public void Spawn()
    {
        Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
    } 
        
    
}
