using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwaningBall : MonoBehaviour
{
   
    public GameObject spawnee;
    public float spawnTime;
    void Start()
    {
        InvokeRepeating("SpawnObject",spawnTime,3);
    }

    public void SpawnObject()
    {
        Instantiate(spawnee,new Vector3(Random.Range(-15.0f,15.0f),11,1),Quaternion.identity);
    }
    
}
