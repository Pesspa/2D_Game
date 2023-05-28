using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCreator : MonoBehaviour
{
    public GameObject prefab;
    public Transform pointSpawn;

    public void Create()
    {
        Instantiate(prefab, pointSpawn.position, pointSpawn.rotation);
    }
}
