using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [Header("Spawn positions")]
    public Transform[] spawners; 

    public float Spawnrate = 2;
    public float NextSpawn = 2;

    [Header("Enemy")]
    public GameObject EnemyPrefab;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > Spawnrate){
            Spawnrate = Time.time + NextSpawn;
            spawnerselect();
            Debug.Log("Enemy spawned");
        }
        
            
        
    }


    void spawnerselect(){
        int omnom = Random.Range(0, spawners.Length);

        Instantiate(EnemyPrefab, spawners[omnom].position, spawners[omnom].rotation);
        //Debug.Log(omnom);
    }

}
