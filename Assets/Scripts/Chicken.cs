using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public Rigidbody chikenBody;
    private Transform _playerTransform;

    public float speed = 10f;
    public float time = 0.2f;
    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
        
    }
    void FixedUpdate()
    {
        Vector3 toPlayer = (_playerTransform.position - transform.position).normalized;
        Vector3 force = chikenBody.mass * (toPlayer * speed - chikenBody.velocity) / time;
        chikenBody.AddForce(force);
    }
}
