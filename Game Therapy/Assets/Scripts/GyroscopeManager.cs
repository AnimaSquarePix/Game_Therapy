using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeManager : MonoBehaviour
{
    #region Instance
    private static GyroscopeManager instance;
    public static GyroscopeManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GyroscopeManager>();
                if (instance == null)
                {
                    instance = new GameObject("Spawned Gyroscope Manager", typeof(GyroscopeManager)).GetComponent<GyroscopeManager>();
                }
            }

            return instance;
        }
        set
        {
            instance = value;
        }
    }
    #endregion

    private Gyroscope gyro;
    private Quaternion rotation;
    private bool isGyroActive;

    void Update()
    {
        if (isGyroActive)
        {
            rotation = gyro.attitude;
        }
    }

    public void EnableGyroscope()
    {
        // If Activated
        if (isGyroActive)
            return;
        
        // If not yet
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            isGyroActive = gyro.enabled;
        }
        else
        {
            Debug.Log("Gyroscope is not suported on this device.");
        }
    }

    public Quaternion GetGyroscopeRotation()
    {
        return rotation;
    }

}