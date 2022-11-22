using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    private int initAmout = 5;
    private float plotSize = 40f;
    private float xPosLeft = -26.25f;
    private float xPosRight = 26.75f;
    private float lastZPos = 8f;

    [SerializeField]
    private List<GameObject> plots;

    void Start()
    {
        for (int i = 0; i < initAmout; i++)
        {
            SpawnPlot();
        }
    }

    public void SpawnPlot()
    {
        GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        GameObject plotRight = plots[Random.Range(0, plots.Count)];

        float zPos = lastZPos + plotSize;

        Instantiate(plotLeft, new Vector3(xPosLeft, 0.5f, zPos), plotLeft.transform.rotation);
        Instantiate(plotRight, new Vector3(xPosRight, 0.5f, zPos), new Quaternion(0, 180, 0, 0));

        lastZPos += plotSize;
    }
}
