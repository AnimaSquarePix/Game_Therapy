using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    PlotSpawner plotSpawner;
    ObstacleSpawner obstacleSpawner;

    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        plotSpawner = GetComponent<PlotSpawner>();
        obstacleSpawner = GetComponent<ObstacleSpawner>();
    }

    void Update()
    {
        
    }

    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        plotSpawner.SpawnPlot();
        obstacleSpawner.SpawnObstacles();
    }
}
