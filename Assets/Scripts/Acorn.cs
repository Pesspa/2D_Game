using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    public Vector3 direction;
    public float maxRotationSpeed = 8f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
            Destroy(gameObject);
        else
            Destroy(gameObject);    
    }
    void Start()
    {
        float randAngularVelocuty = Random.Range(-maxRotationSpeed, maxRotationSpeed);
        GetComponent<Rigidbody>().AddRelativeForce(direction, ForceMode.VelocityChange);
        GetComponent<Rigidbody>().angularVelocity = new Vector3(randAngularVelocuty, randAngularVelocuty, randAngularVelocuty);
    }
}
