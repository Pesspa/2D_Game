using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootHeal : MonoBehaviour
{
    public Transform plus;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerHealth>())
        {
            other.attachedRigidbody.GetComponent<PlayerHealth>().AddHealth(1f);
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        plus.Rotate(new Vector3(0f, 5f, 0f));
    }
}
