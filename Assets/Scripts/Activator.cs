using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public List<DistanceToEnemy> Enemies = new List<DistanceToEnemy>();
    public Transform playerTransform;

    private void Update()
    {
        for(int i = 0; i < Enemies.Count; i++)
        {
            Enemies[i].Checkdistance(playerTransform.position);
        }
    }
}
