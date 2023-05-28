using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject effectBullet;
    public Rigidbody rb;
    public GameObject bulletPref;
    void Start()
    {
        rb.AddForce(transform.forward * 15f * Time.deltaTime, ForceMode.VelocityChange);
        Destroy(gameObject, 4f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(effectBullet, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
