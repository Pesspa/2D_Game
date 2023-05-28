using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToTargetEuler : MonoBehaviour
{
    public Vector3 leftEuler;
    public Vector3 rightEuler;

    public float speedRotate;
    private Vector3 _target;
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_target), Time.deltaTime * speedRotate);
    }
    public void RotateLeft()
    {
        _target = leftEuler;
    }
    public void RotateRight()
    {
        _target = rightEuler;
    }
}
