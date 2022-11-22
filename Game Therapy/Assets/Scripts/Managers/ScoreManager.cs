using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private GameObject player;

    [SerializeField]
    private Text uiDistance;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        int distance = Mathf.RoundToInt(player.transform.position.z);
        uiDistance.text = distance.ToString() + " m";
    }
}
