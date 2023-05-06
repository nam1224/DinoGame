using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject spawn1; //up
    public GameObject spawn2; //down
    void Start()
    {

    }

    void SpawnObstacle()
    {
        float spawnTime = 0;
        spawnTime += Time.deltaTime;
        if (spawnTime >= 3)
        {
            int spawn = Random.Range(0, 2);
            Instantiate(obstacle, new Vector2(-10, 0), Quaternion.identity);
            spawnTime = 0;
        } 
    }

    void Update()
    {
        SpawnObstacle();
    }
}
