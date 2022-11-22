using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SphereCollider sphereCollider;
    
    private float forwardSpeed = 7f;

    private SpawnManager spawnManager;

    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        spawnManager = FindObjectOfType<SpawnManager>();
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
        }
    }
}
