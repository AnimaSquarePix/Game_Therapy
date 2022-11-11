using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    private Rigidbody playerRB;
    [SerializeField] private float speed = 10f;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Accelerometer variable
        Vector3 tilt = Input.acceleration;

        // Acceleration * speed
        tilt = Quaternion.Euler(180, 0, 0) * tilt * speed;

        // Adds the force to the player rigidbody
        playerRB.AddForce(tilt, ForceMode.Acceleration);

        // Draws a blue line to see the direction he is going
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.blue);
    }
}
