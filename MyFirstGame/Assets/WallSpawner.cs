using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{

    public Transform spawnPos;
    public GameObject spawnee;
    public Transform groundPos;
    public GameObject ground;

    //private Vector3 position = (spawnPos.position.x, groundPos.position.y, spawnPos.position.z);

    private void position(Vector3 pos){
        pos.x = spawnPos.position.x;
        pos.y = groundPos.position.y;
        pos.z = spawnPos.position.z;
    }

    private Vector3 pos;

    // Update is called once per frame
    public void Spawn(){
        position(pos);
        Instantiate(spawnee, pos, groundPos.rotation);
    }
}