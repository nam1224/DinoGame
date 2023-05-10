using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstacle;
    void Start()
    {
        SpawnObstacle(spawnTime);
        MoveObstacle();
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

    private GameObject[] clone;
    public float force = 0.1f;
    void MoveObstacle()
    {
        clone = GameObject.FindGameObjectsWithTag("Obstacle");
        //Debug.Log(GameObject.FindGameObjectsWithTag("Clone").Length);
        for(int i = 0; i < clone.Length; i++)
        {
            clone[i].transform.position = new Vector2(clone[i].transform.position.x + force, clone[i].transform.position.y);
        }
        pl = GameObject.Find("Player").GetComponent<Player>();
        if(pl.isGameOver == true)
        {
            for(int i = 0; i < clone.Length; i++)
            {
                Destroy(clone[i]);
            }
        }
    }

    void Update()
    {
        spawnTime += Time.deltaTime;
        MoveObstacle();
        SpawnObstacle(spawnTime);
    }
}
