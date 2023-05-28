using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawn : MonoBehaviour
{
    public GameObject ammoPrefab;
    public Transform spawnTransform;

    public void Create()
    {
        Instantiate(ammoPrefab, spawnTransform.position, Quaternion.identity);    
    }
}
