using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SphereCollider sphereCollider;
    private float forwardSpeed = 7f;

    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
        }
    }
}
