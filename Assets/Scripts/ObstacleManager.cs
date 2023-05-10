using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstacle;
    void Start()
    {
        SpawnObstacle(spawnTime);
    }

    Player pl;
    public Transform spawnUp; //up
    public Transform spawnDown; //down
    private float spawnTime= 3;

    void SpawnObstacle(float time)
    {
        pl = GameObject.Find("Player").GetComponent<Player>();
        if (time >= 3 && pl.isGameOver == false)
        {
            int spawnPos = Random.Range(0, 2);
            if (spawnPos < 1) //up
            {
                Instantiate(obstacle, new Vector2(spawnUp.position.x, spawnUp.position.y), Quaternion.identity);
            }
            else if (spawnPos >= 1) //down
                Instantiate(obstacle, new Vector2(spawnUp.position.x, spawnDown.position.y), Quaternion.identity);
            spawnTime = 0;
        }
    }

    void Update()
    {
        spawnTime += Time.deltaTime;
        SpawnObstacle(spawnTime);
    }
}
