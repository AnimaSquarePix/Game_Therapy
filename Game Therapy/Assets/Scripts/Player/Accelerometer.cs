using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    private bool isFlat = true;
    private Rigidbody playerRB;
    private float speed = 7f;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 tilt = Input.acceleration;

        if (isFlat)
        {
            tilt = Quaternion.Euler(180, 0, 0) * tilt * speed;
        }

        playerRB.AddForce(tilt);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.blue);
    }
}
