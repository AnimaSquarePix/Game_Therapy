using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationManager : MonoBehaviour
{
    private Vector3 accel;
    private Vector3 prev;
    private const float kFilterFactor = 0.20f;
    private Matrix4x4 calibrationMatrix;
    private Vector3 accelerationSnapshot;
     
    public Vector2 acceleration;

    public void Start()
    {
        Calibrate();
    }

    public void Update()
    {
        // Normalizes the input interference and applies a filter to smooth the values
        accel = Input.acceleration.normalized * kFilterFactor + (1.0f - kFilterFactor) * prev;
        
        // Store current acceleration as previous for next update
        prev = accel;

        // Sets acceleration values ​​on the x and y axes
        acceleration.x = accel.x;
        acceleration.y = calibrationMatrix.MultiplyVector(accel).y;
    }

    public void Calibrate()
    {
        // Gets the input normalized acceleration
        accel = Input.acceleration.normalized;

        // Stores the initial acceleration reading
        accelerationSnapshot = accel;

        // Calculates the calibration matrix to transform the filtered acceleration
        Quaternion rotateQuaternion = Quaternion.FromToRotation(new Vector3(0.0f, 0.0f, -1.0f), accelerationSnapshot);
        Matrix4x4 matrix = Matrix4x4.TRS(Vector3.zero, rotateQuaternion, new Vector3(1.0f, 1.0f, 1.0f));
        calibrationMatrix = matrix.inverse;
    }
}
