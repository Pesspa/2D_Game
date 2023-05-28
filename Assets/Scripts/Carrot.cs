using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    public Vector3 rotateCarrot;

    private Transform _playerTransf;
    public Rigidbody carrotBody;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            carrotBody.useGravity = true;
            rotateCarrot = Vector3.zero;
        }
    }
    private void Start()
    {
        _playerTransf = FindObjectOfType<PlayerMove>().transform;
        Vector3 toPlayer = (_playerTransf.position - transform.position).normalized;
        carrotBody.velocity = toPlayer * 8f;
    }
    void Update()
    {
        transform.Rotate(rotateCarrot * Time.deltaTime);  
    }
}
