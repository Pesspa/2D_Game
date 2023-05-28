using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantDeath : MonoBehaviour
{
    private PlayerHealth _playerHealth;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Death"))
        {
            _playerHealth.health = 0;
            Destroy(other.gameObject);
        }
    }
}
