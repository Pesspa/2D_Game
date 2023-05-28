using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootAmmo : MonoBehaviour
{
    public Automat Automat;
    public Transform gun;
    public int bullets = 30;
    public int gunIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerAmmunition>() is PlayerAmmunition playerAmmunition)
        {
            playerAmmunition.AddBullets(bullets, gunIndex);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        gun.Rotate(new Vector3(0f, 5f * Time.deltaTime, 0f));
    }
}
