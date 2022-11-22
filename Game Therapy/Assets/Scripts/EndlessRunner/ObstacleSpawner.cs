using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private int spawnInterval = 10;
    private int lastSpawnZ = 8;
    private int spawnAmount = 4;

    [SerializeField]
    private List<GameObject> obstacles;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SpawnObstacles()
    {
        lastSpawnZ += spawnInterval;

        for (int i = 0; i < spawnAmount; i++)
        {
            if (Random.Range(0, 4) == 0)
            {
                GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];

                Instantiate(obstacle, new Vector3(0, 0.5f, lastSpawnZ), obstacle.transform.rotation);
            }
        }
    }
}
