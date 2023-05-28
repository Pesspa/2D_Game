using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public AudioSource shot;
    public GameObject bulletPrefab;
    public Rigidbody rbBullet;
    public Transform bulletspawn;
    public float timeBetweenShoot;
    public float bulletSpeed;

    private float _timer = 0;
    void Update()
    {
        _timer += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && timeBetweenShoot < _timer)
        {
            if (_timer > timeBetweenShoot)
            {
                Shot();
            }
        }
    }
    public virtual void Shot()
    {
        GameObject newBullet = Instantiate(bulletPrefab, bulletspawn.position, bulletspawn.localRotation);
        newBullet.GetComponent<Rigidbody>().velocity = bulletspawn.forward * bulletSpeed;
        shot.pitch = Random.Range(1f, 1.2f);
        shot.Play();
        _timer = 0;
    }
    public virtual void AddBullet(int bullets)
    {
        
    }
 
}
