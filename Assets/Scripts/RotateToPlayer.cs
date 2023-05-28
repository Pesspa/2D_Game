using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    private Transform _playerPosition;
    private Vector3 _targetEuler;
    public float speedRotate = 7f;

    public Vector3 _leftEuler;
    public Vector3 _rightEuler;
    private void Start()
    {
        _playerPosition = FindObjectOfType<PlayerMove>().transform;
    }
    private void Update()
    {
        if (_playerPosition.position.x < transform.position.x)
        {
            _targetEuler = _rightEuler;
        }
        else
        {_targetEuler = _leftEuler;}

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_targetEuler), Time.deltaTime * speedRotate);
    }
}
