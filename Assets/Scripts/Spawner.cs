using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject prefabToSpawn;


    float spawnTime = float.MinValue;
    //Will let us control the rate of enemies/asteroids
    public float spawnRate = 2;
    
    void Update()
    {
        if(Time.time - (1/spawnRate) > spawnTime)
        {
            Instantiate(prefabToSpawn, new Vector3(Random.Range(-5.0f, 5), 0, 0), Quaternion.identity);
            spawnTime = Time.time;
        }
    }
	
}
