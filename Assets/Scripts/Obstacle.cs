using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject obstacle;

    void Start()
    {
        SpawnObstacle(spawnTime);
        MoveObstacle();
    }

    public Transform spawnUp; //up
    public Transform spawnDown; //down
    private float spawnTime= 3;

    void SpawnObstacle(float time)
    {
        if(time >= 3)
        {
            int spawnPos = Random.Range(0, 2);
            if (spawnPos == 0) //up
            {
                Instantiate(obstacle, new Vector2(spawnUp.position.x, spawnUp.position.y), Quaternion.identity).tag = "Obstacle";
            }
            else //down
                Instantiate(obstacle, new Vector2(spawnUp.position.x, spawnDown.position.y), Quaternion.identity).tag = "Obstacle";
            spawnTime = 0;
        }
    }

    void MoveObstacle()
    {
        GameObject[] clone = GameObject.FindGameObjectsWithTag("Obstacle");
        //Debug.Log(GameObject.FindGameObjectsWithTag("Clone").Length);
        for(int i = 0; i < clone.Length; i++)
        {
            clone[i].transform.position = new Vector2(clone[i].transform.position.x + 0.05f, clone[i].transform.position.y);
        }
    }

    void Update()
    {
        spawnTime += Time.deltaTime;
        SpawnObstacle(spawnTime);
        MoveObstacle();
    }
}
