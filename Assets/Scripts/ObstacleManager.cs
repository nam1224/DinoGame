using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstacle;
    void Start()
    {
        SpawnObstacle(checkTime);
    }

    Player pl;
    public Transform spawnUp; //up
    public Transform spawnDown; //down
    private float checkTime = 3; //시간을 측정함
    private float spawnTime = 3; //스폰 타임의 기본값

    void SpawnObstacle(float time)
    {
        pl = GameObject.Find("Player").GetComponent<Player>();
        if (time >= spawnTime && pl.isGameOver == false)
        {
            int spawnPos = Random.Range(0, 2);
            if (spawnPos < 1) //up
            {
                Instantiate(obstacle, new Vector2(spawnUp.position.x, spawnUp.position.y), Quaternion.identity);
            }
            else if (spawnPos >= 1) //down
                Instantiate(obstacle, new Vector2(spawnUp.position.x, spawnDown.position.y), Quaternion.identity);
            checkTime = 0;
        }
    }

    void Update()
    {
        checkTime += Time.deltaTime;
        SpawnObstacle(checkTime);
    }
}
