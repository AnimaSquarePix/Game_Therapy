using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGyroscope : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    
    void Start()
    {
        GyroscopeManager.Instance.EnableGyroscope();
    }

    void Update()
    {
        transform.localRotation = GyroscopeManager.Instance.GetGyroscopeRotation() * baseRotation;
    }
}
